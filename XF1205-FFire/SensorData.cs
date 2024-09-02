using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF1205_FFire
{
    public class SensorData
    {
        // 油面温度
        public double OilTemperature { get; set; } = 8888.8;

        // 燃气电磁阀状态
        public bool GasValveStatus { get; set; } = false;
        public SensorData() { }
    }
}
