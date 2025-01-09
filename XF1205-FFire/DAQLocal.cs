namespace XF1205_FFire
{
    public class DAQLocal
    {
        private readonly System.Threading.Timer _timer;
        public DAQLocal()
        {
            _timer = new System.Threading.Timer(RefreshSensorData);
        }

        private void RefreshSensorData(object? status)
        {
            var _sensorData = AppData.Data?["SensorData"] as SensorData;
            var _apparatus = AppData.Data?["Apparatus"] as ApparatusOperator;
            // 获取温度修正值
            double temp = 0;
            double.TryParse(AppData.Data?["Delta"].ToString(),out temp);

            if (_sensorData != null && _apparatus != null)
            {
                _sensorData.OilTemperature = _apparatus.GetOilTemperature() / 10.0 + temp;
            }
        }

        public void StartDAQ()
        {
            _timer.Change(0, 1000);
        }

        public void StopDAQ()
        {
            _timer.Change(0, Timeout.Infinite);
        }
    }
}
