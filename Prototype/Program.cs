using System;
using Prototype.CaseOne;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region CaseOne

            var augustWeatherForecastForQutaisi = new WeatherForecast("Qutaisi");
            augustWeatherForecastForQutaisi.Load(DateTime.Parse("2017/08/01"), DateTime.Parse("2017/08/31"));

            //we want to have weather forecast for july and august of 2017, we have 2 way to achieve this
            //1) create brand new WeatherForecast and retrieve data for july and august via remote api (time and resource intensive task). 
            //2) BUT, in fact we already have weather forecast for august, so why don't reuse that data ?

            var julyAndAugustWeatherForecastForQutaisi = (WeatherForecast)augustWeatherForecastForQutaisi.Clone();
            //Now we only need to load July, since we already have august.
            julyAndAugustWeatherForecastForQutaisi.Load(DateTime.Parse("2017/07/01"), DateTime.Parse("2017/07/31"));

            #endregion
        }
    }
}