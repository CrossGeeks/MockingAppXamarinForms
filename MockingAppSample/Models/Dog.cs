using System;
using Newtonsoft.Json;

namespace MockingAppSample.Models
{
    public class Dog
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Age")]
        public string Age { get; set; }

        [JsonProperty("Race")]
        public string Race { get; set; }

        [JsonProperty("Photo")]
        public string Photo { get; set; }
    }
}
