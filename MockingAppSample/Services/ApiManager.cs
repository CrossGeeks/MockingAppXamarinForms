using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MockingAppSample.Models;

namespace MockingAppSample.Services
{
    public class ApiManager: IApiManager
    {
        public string BaseUrl = "";
        public async Task<bool> LoginUser(User user)
        {
            //Do request here
            return true;
        }

        public async Task<List<Dog>> GetDogs()
        {
            //Do request here
            return null;
        }
    }
}
