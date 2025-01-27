using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class TemperatureUtil
    {
        public TemperatureUtil() { }

        public double CelsiusVersFahrenheit(double temp)
        {
            return temp * 1.8 + 32;
        }

        public double CelsiusVersKelvin(double temp)
        {
            return temp + 273.15;
        }


        public double FahrenheitVersCelsius(double temp)
        {
            return (temp - 32) / 1.8;
        }

        public double FahrenheitVersKelvin(double temp)
        {
            return FahrenheitVersCelsius(temp) + 273.15; ;
        }


        public double KelvinVersCelsius(double temp)
        {
            return temp - 273.15;
        }

        public double KelvinVersFahreinheit(double temp)
        {
            return CelsiusVersFahrenheit(KelvinVersCelsius(temp));
        }
    }
}
