﻿namespace ECS_2 
{
    public class ECS 
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;
       private readonly IWindow _window;

        public ECS(int thr, ITempSensor ts, IHeater h, IWindow w)
        {
            SetThreshold(thr);
            _tempSensor = ts;
            _heater = h;
           _window = w;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
           if (t < _threshold)
           {
              _heater.TurnOn();
              _window.Close();
           }
           else
           {
              _heater.TurnOff();
              _window.Open();
           }

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
           return _tempSensor.RunSelfTest() && _heater.RunSelfTest() && _window.RunSelfTest();
        }
    }
}
