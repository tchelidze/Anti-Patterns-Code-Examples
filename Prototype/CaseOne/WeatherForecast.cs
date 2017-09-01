using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Prototype.CaseOne
{
    public class WeatherForecast : IClonable
    {
        readonly List<Forecast> _forecastHistory = new List<Forecast>();

        public WeatherForecast(string location) => Location = location;

        public WeatherForecast(string location, IEnumerable<Forecast> forecastHistory)
        {
            Location = location;
            _forecastHistory = forecastHistory.ToList();
        }

        public IEnumerable<Forecast> ForecastHistory => _forecastHistory;

        public string Location { get; }

        public object Clone() => new WeatherForecast(Location, ForecastHistory.Select(it => it.Clone()).Cast<Forecast>());

        public void Load(DateTime from, DateTime until)
        {
            for (var it = from; it < until; it = it.AddDays(1))
            {
                //Impersonate remote API call (time intensive task).
                Thread.Sleep(100);
                _forecastHistory.Add(new Forecast
                {
                    Date = it,
                    Scale = TemperatureScale.Celsius,
                    Location = Location,
                    Temperature = new Random().Next(28, 39)
                });
            }
        }
    }
}