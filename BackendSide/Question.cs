using System;
using System.Collections.Generic;

namespace BackendSide
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class Question
    {
        public string questionText { get; set; }

        public List<option> options { get; set; }

        public string explanation;
    }

    public class option
    {
        public string text;
        public int score;
    }
}