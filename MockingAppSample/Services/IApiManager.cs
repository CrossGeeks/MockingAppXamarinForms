using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MockingAppSample.Models;

namespace MockingAppSample.Services
{
    public interface IApiManager
    {
        Task<bool> LoginUser(User user);
        Task<List<Dog>> GetDogs();
    }
}
