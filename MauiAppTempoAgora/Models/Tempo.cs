using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTempoAgora.Models
{
    public class Tempo
    {
        public string? Title { get; set; }
        public string? Temperature { get; set; }
        public string? Wind { get; set; }
        public string? Humidity { get; set; }
        public string? Visibility { get; set; }
        public string? Sunrise { get; set; }
        public string? Sunset { get; set; }
        public string? Weather {  get; set; } 
        public string? WeatherDescription {  get; set; }

        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

    }
}
