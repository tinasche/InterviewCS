using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InterviewCS.Classes
{
    public class Car
    {
        [JsonPropertyName("make")]
        public string Make { get; set; } = string.Empty;
        [JsonPropertyName("model")]
        public string Model { get; set; } = string.Empty;
        [JsonPropertyName("colour")]
        public string Colour { get; set; } = string.Empty;
        [JsonPropertyName("release_year")]
        [DataType(DataType.Date)]
        public DateTime ReleaseYear { get; set; }
        [JsonPropertyName("transmission")]
        public string Transmission { get; set; } = string.Empty;
        [JsonPropertyName("fuel")]
        public string Fuel { get; set; } = string.Empty;

        public Car(string make, string model, string colour, DateTime releaseYear, string trasmission, string fuel)
        {
            Make = make;
            Model = model;
            Colour = colour;
            ReleaseYear = releaseYear;
            Transmission = trasmission;
            Fuel = fuel;
        }

        public Car() { }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            return $"The {this.Make} {this.Model} released in {this.ReleaseYear.Year} with a colour of {this.Colour}.";
        }
    }
}