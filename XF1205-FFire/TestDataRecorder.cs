using CsvHelper;
using DevExpress.XtraSpreadsheet.Model;
using DevExpress.XtraSpreadsheet.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO.Packaging;
using OfficeOpenXml.Drawing.Chart;
using DevExpress.Spreadsheet;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Utils;
using DevExpress.Data.Filtering;
using DevExpress.Spreadsheet.Charts;

using MSExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace XF1205_FFire
{
    /* 直接从传感器采集数据的版本(从SignalR客户端获取传感器数据的版本另做开发) */
    public class TestDataRecorder
    {
        //计时线程
        private readonly System.Threading.Timer _timer;
        // 数据采集计数器
        private int _counter;
        // 传感器最新数据
        //private SensorData _sensorData;
        // 传感器原始数据缓存
        private List<SensorData> _sensorDataBuffer;
        // 样品数据模型
        private DataModel? _dataModel;
        // 样品试验视图窗体对象
        private TestForm? _view;
        // 视图显示模型
        private TestViewModel _viewModel;

        private ProgressForm progress;
        public TestDataRecorder()
        {
            _timer = new(RecordData);
            _counter = 0;
            //_sensorData = new SensorData();
            _sensorDataBuffer = new List<SensorData>();
            _viewModel = new();
            progress = new ProgressForm();
        }

        public void BindView(TestForm view)
        {
            _view = view;
        }

        /* 从全局传感器数据缓存中获取最新传感器数据
           返回值:
                  true - 成功获取传感器最新数据
                  false - 获取最新数据失败
        */
        private bool FetchSensorData()
        {
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            if (sensorData is not null)
            {
                //_sensorData.OilTemperature = sensorData.OilTemperature;
                _viewModel.SensorData.OilTemperature = sensorData.OilTemperature;
            }

            return true;
        }
        // 根据获取的最新传感器数据计算对应实时数据
        private void DoCaculate()
        {
            // 计算当前温度升高速度
            // ...
        }

        // 试验数据记录线程函数
        private void RecordData(object? status)
        {
            // 获取传感器最新数据,如果获取失败则跳过本轮,
            if (!FetchSensorData())
                return;

            // 保存传感器最新数据
            _sensorDataBuffer.Add(new SensorData
            {
                Timer = _counter,
                OilTemperature = _viewModel.SensorData.OilTemperature
            });

            // 计算实时数据
            DoCaculate();

            // 更新样品试验视图界面显示
            _viewModel.Counter = _counter;
            _view?.UpdateDisplay(_viewModel);

            // 增加采集计数器
            _counter++;
        }

        public void Start()
        {
            _timer.Change(0, 1000);
        }

        public void Stop()
        {
            _timer.Change(0, Timeout.Infinite);

        }

        public void OutputTestData()
        {
            progress.Show();
            progress.Invoke(new Action(() =>
            {
                progress.Update();
            }));

            _dataModel = AppData.Data?["TestData"] as DataModel;
            if (_dataModel == null)
            {
                MessageBox.Show("系统未检测到已录入的样品信息,无法生成报告。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            /* 创建本地存储目录 */
            string prodpath = $"D:\\XF 1205-2014 FFire\\{_dataModel.SampleId}";
            string smppath = $"{prodpath}\\{_dataModel.TestId}";
            string datapath = $"{smppath}\\data";
            string rptpath = $"{smppath}\\report";

            try
            {
                /* 创建本次试验结果文件的存储目录 */
                //试验样品根目录
                Directory.CreateDirectory(prodpath);
                //本次试验根目录
                Directory.CreateDirectory(smppath);
                //本次试验原始数据目录
                Directory.CreateDirectory(datapath);
                //本次试验报表目录
                Directory.CreateDirectory(rptpath);

                /* 保存本次试验数据文件 */
                // 使用CsvHelper保存传感器采集数据
                using (var writer = new StreamWriter($"{datapath}\\sensordata.csv", false))
                using (var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    //写入数据内容
                    csvwriter.WriteRecords(_sensorDataBuffer);
                }

                // 使用EPPlus加载csv格式传感器数据
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var format = new ExcelTextFormat()
                {
                    Delimiter = ',',
                    EOL = "\r"    // 修改行尾结束符,默认为 "\r\n" ("\r"为回车符 "\n"为换行符);
                                  // 字符类型引用符 format.TextQualifier = '"';
                };
                using (ExcelPackage excelPack = new ExcelPackage(new FileInfo(@"D:\\XF 1205-2014 FFire\\chart_template.xlsx")))
                {
                    // 加载传感器温度原始数据
                    excelPack.Workbook.Worksheets[0].Cells["A1"].LoadFromText(new FileInfo($"{datapath}\\sensordata.csv"), format,
                        OfficeOpenXml.Table.TableStyles.None, true);
                    // 保存至指定文件夹
                    excelPack.SaveAs($"{datapath}\\chart.xlsx");
                }

                /* 使用DevExpress Office API生成图表并复制到Word报表中 */
                using (DevExpress.Spreadsheet.Workbook workbook = new())
                {
                    // 加载报表文件并保存温度图表为本地文件
                    //workbook.LoadDocument($"{datapath}\\chart.xlsx");
                    MSExcel.Application oApp;
                    MSExcel.Workbook oWorkbook;
                    MSExcel.Worksheet oWorksheet;

                    oApp = new MSExcel.Application();
                    oApp.Visible = false;
                    oWorkbook = oApp.Workbooks.OpenXML($"{datapath}\\chart.xlsx");
                    oWorksheet = oWorkbook.Worksheets.Item[1];
                    oWorksheet.Shapes.Item(1).Copy();

                    Clipboard.GetImage().Save($"{datapath}\\chart.png");
                    Clipboard.Clear();

                    oWorkbook.Close();
                    oApp.Quit();

                    // 使用 DevExpress Office API 填写Word格式的试验报表
                    using (var wordProcessor = new RichEditDocumentServer())
                    {
                        wordProcessor.LoadDocument(@"D:\\XF 1205-2014 FFire\\template.docx");

                        Document document = wordProcessor.Document;
                        // 设置Word格式试验报表的表格数据
                        /* 填充非表格化数据 */
                        // 检验日期
                        document.Replace(document.FindAll("[testdate]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.TestDate.ToString("yyyy年MM月dd日"));
                        // 检验人员
                        document.Replace(document.FindAll("[operator]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.Operator);
                        // 设置实验室湿度
                        document.Replace(document.FindAll("[humidity]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.Humidity.ToString());
                        // 设置实验室温度
                        document.Replace(document.FindAll("[labtemp]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.LabTemperature.ToString());
                        // 设置报告编号
                        document.Replace(document.FindAll("[rptno]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.ReportId);
                        // 产品名称 
                        document.Replace(document.FindAll("[productname]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.ProductName);
                        // 样品编号
                        document.Replace(document.FindAll("[sampleid]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.SampleId);
                        // 试验编号(标识号)
                        document.Replace(document.FindAll("[testid]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.TestId);
                        // 检验依据
                        document.Replace(document.FindAll("[testaccord]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.TestAccord);
                        // 样品养护时间
                        document.Replace(document.FindAll("[productpreparetime]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.ProductPrepareTime);
                        // 设备检定日期
                        document.Replace(document.FindAll("[apparatuscheckdate]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.ApparatusCheckDate);
                        // 设备编号
                        document.Replace(document.FindAll("[apparatusid]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.ApparatusId);
                        // 试验结论1
                        document.Replace(document.FindAll("[result1]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.Result1 ? "■ 符合要求 \r□ 不符合要求" : "□ 符合要求 \r■ " + _dataModel.NGReason1 + ",不符合要求");
                        // 试验结论2
                        document.Replace(document.FindAll("[result2]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.Result2 ? "■ 符合要求 \r□ 不符合要求" : "□ 符合要求 \r■ " + _dataModel.NGReason2 + ",不符合要求");
                        // 试验结论3
                        document.Replace(document.FindAll("[result3]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.Result3 ? "■ 符合要求 \r□ 不符合要求" : "□ 符合要求 \r■ " + _dataModel.NGReason3 + ",不符合要求");
                        // 试验备注
                        document.Replace(document.FindAll("[memo]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], _dataModel.Memo);

                        // 在表格中插入温度曲线图
                        Image img = Image.FromFile($"{datapath}\\chart.png");
                        DevExpress.XtraRichEdit.API.Native.Table table = document.Tables[0];
                        table.BeginUpdate();
                        document.Images.Insert(table[10, 0].Range.Start, img);
                        table.EndUpdate();

                        wordProcessor.SaveDocument($"{rptpath}\\report.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                        img.Dispose();
                    }
                }

                //MSWord.Application wdApp = new MSWord.Application();
                //wdApp.Visible = false;
                //MSWord.Document wdDoc = wdApp.Documents.Open($"{rptpath}\\report.docx");
                //wdDoc.Activate();
                //MSWord.Table wdTable = wdDoc.Tables[1];
                //wdTable.Cell(11, 1).Range.InlineShapes.AddPicture("E:\\chart.png", Type.Missing, Type.Missing, Type.Missing);

                //wdDoc.Save();
                //wdDoc.Close();
                //wdApp.Quit();

                progress.Invoke(new Action(() =>
                {
                    progress.Close();
                }));


                MessageBox.Show("生成报告成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            // 重置试验控制变量
            _counter = 0;
        }
    }
}
