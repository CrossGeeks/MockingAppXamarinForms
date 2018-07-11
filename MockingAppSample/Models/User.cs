using System;
using Newtonsoft.Json;

namespace MockingAppSample.Models
{
    public class User
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}
