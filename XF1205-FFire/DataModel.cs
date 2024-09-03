using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF1205_FFire
{
    public class DataModel
    {
        public double LabTemperature { get; set; } = 25.0;
        public double Humidity { get; set; } = 80.0;
        public int SampleId { get; set; } = 0;
        public int TestId { get; set; } = 0;
        public string ProductName { get; set; } = string.Empty;
        public DateTime ProductPrepareTime { get; set; }
        public string ReportId { get; set; } = string.Empty ;
        public DateTime TestDate { get; set; }
        public string Operator { get; set; } = string.Empty;
        public string TestAccord {  get; set; } = string.Empty;
        public string ApparatusId { get; set; } = string.Empty;
        public string ApparatusName { get;set; } = string.Empty;
        public string ApparatusCheckDate { get; set; }
        public string Memo {  get; set; } = string.Empty;

        public DataModel()
        {
            
        }
    }
}
