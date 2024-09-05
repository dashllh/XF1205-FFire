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
        private SensorData _sensorData;
        // 传感器原始数据缓存
        private List<SensorData> _sensorDataBuffer;
        // 样品数据模型
        private DataModel? _dataModel;
        // 样品试验视图窗体对象
        private TestForm? _view;
        // 视图显示模型
        private TestViewModel _viewModel;
        public TestDataRecorder()
        {
            _timer = new(RecordData);
            _counter = 0;
            _sensorData = new SensorData();
            _sensorDataBuffer = new List<SensorData>();
            _viewModel = new();
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
            _sensorDataBuffer.Add(_sensorData);

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

        public async void OutputTestData()
        {
            _dataModel = AppData.Data?["TestData"] as DataModel;
            if(_dataModel == null)
            {
                MessageBox.Show("系统未检测到已录入的样品信息,无法生成报告。","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            /* 创建本地存储目录 */
            string prodpath = $"D:\\XF 1205-2014\\{_dataModel.SampleId}";
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
                //传感器采集数据
                using (var writer = new StreamWriter($"{datapath}\\sensordata.csv", false))
                using (var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    //写入数据内容
                    await csvwriter.WriteRecordsAsync(_sensorDataBuffer);
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var format = new ExcelTextFormat()
                {
                    Delimiter = ',',
                    EOL = "\r"    // 修改行尾结束符,默认为 "\r\n" ("\r"为回车符 "\n"为换行符);
                                  // 字符类型引用符 format.TextQualifier = '"';
                };
                using (ExcelPackage excelPack = new ExcelPackage())
                {
                    // 创建sheet
                    ExcelWorksheet sheetRawData = excelPack.Workbook.Worksheets.Add("rawdata");
                    ExcelWorksheet sheetChart = excelPack.Workbook.Worksheets.Add("chart");
                    // 加载传感器温度原始数据
                    await sheetRawData.Cells["A1"].LoadFromTextAsync(new FileInfo($"{datapath}\\sensordata.csv"), format, OfficeOpenXml.Table.TableStyles.Custom, true);
                    // 创建温度图并设置显示属性
                    ExcelLineChart chart = sheetChart.Drawings.AddLineChart("temperature", eLineChartType.Line) as ExcelLineChart;
                    chart.SetPosition(0, 10, 0, 10);
                    chart.SetSize(540, 200);
                    chart.Legend.Remove();

                    var dataSource = sheetRawData.Cells[$"A2:A{_sensorDataBuffer.Count}"];
                    chart.Series.Add(dataSource);

                    excelPack.SaveAs($"{datapath}\\chart.xlsx");
                }

                /* 使用DevExpress Office API打开报表文件，复制图标至ClipBorad */
                using (DevExpress.Spreadsheet.Workbook workbook = new())
                {
                    // 加载报表文件
                    workbook.LoadDocument($"{datapath}\\chart.xlsx");
                    DevExpress.Spreadsheet.Worksheet worksheet = workbook.Worksheets[1];
                    OfficeImage chartImg = worksheet.Charts[0].GetImage();

                    using (var wordProcessor = new RichEditDocumentServer())
                    {
                        wordProcessor.LoadDocument(@"D:\\XF 1205-2014\\template.docx");

                        Document document = wordProcessor.Document;
                        // 设置表格数据
                        DevExpress.XtraRichEdit.API.Native.Table table = document.Tables[0];
                        table.BeginUpdate();
                        document.Images.Insert(table[10, 0].Range.Start, chartImg.NativeImage);
                        table.EndUpdate();
                        
                        wordProcessor.SaveDocument($"{rptpath}\\report.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                    }
                }
                MessageBox.Show("生成报告成功!","系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //FileStream stream = File.Create($"{datapath}\\chart.xlsx");
                //stream.Close();
                // 复制曲线图文件至Word报表文件
                
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
