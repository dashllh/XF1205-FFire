using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF1205_FFire
{
    public class SensorData
    {
        // 计时器
        public int Timer { get; set; } = 0;
        // 油面温度
        public double OilTemperature { get; set; } = 8888;
        public SensorData() { }
    }
}
