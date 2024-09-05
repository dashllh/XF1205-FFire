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
        public string SampleId { get; set; } = string.Empty;
        public string TestId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductPrepareTime { get; set; } = string.Empty;
        public string ReportId { get; set; } = string.Empty ;
        public DateTime TestDate { get; set; }
        public string Operator { get; set; } = string.Empty;
        public string TestAccord {  get; set; } = string.Empty;
        public string ApparatusId { get; set; } = string.Empty;
        public string ApparatusName { get;set; } = string.Empty;
        public string ApparatusCheckDate { get; set; } = string.Empty;
        public string Memo {  get; set; } = string.Empty;

        public DataModel()
        {            
        }
    }
}
