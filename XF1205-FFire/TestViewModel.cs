using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF1205_FFire
{
    public class TestViewModel
    {
        // 试验计时器
        public int Counter { get; set; }

        // 传感器数据
        public SensorData SensorData { get; set; }
        public TestViewModel() 
        {
            Counter = 0;
            SensorData = new SensorData();
        }
    }
}
