using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherResult
    {
        public string Reason { get; set; }
        public WeatherDetail Result { get; set; }
        public string Error_Code { get; set; }
    }
    public class WeatherDetail
    {
        public string City { get; set; }
        public WeatherRealTime RealTime { get; set; }
        public List<WeatherFuture> Future { get; set; }
    }

    public class WeatherRealTime
    {
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string Info { get; set; }
        public string Wid { get; set; }
        public string Direct { get; set; }
        public string Power { get; set; }
        public string Aqi { get; set; }
    }

    public class WeatherFuture
    {
        public string Date { get; set; }
        public string Temperature { get; set; }
        public string Weather { get; set; }
        public Wid Wid { get; set; }
        public string Direct { get; set; }
    }

    public class Wid
    {
        public string Day { get; set; }
        public string Night { get; set; }
    }
}
