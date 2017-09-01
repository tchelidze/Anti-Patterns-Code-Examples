using System;

namespace Prototype.CaseOne
{
    public class Forecast : IClonable
    {
        public decimal Temperature { get; set; }

        public TemperatureScale Scale { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public object Clone() => new Forecast
        {
            Location = Location,
            Date = Date,
            Temperature = Temperature,
            Scale = Scale
        };
    }
}