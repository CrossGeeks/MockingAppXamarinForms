﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MockingAppSample.Models;
using Newtonsoft.Json;

namespace MockingAppSample.Services
{
    public class ApiMockManager: IApiManager
    {
        public async Task<bool> LoginUser(User user)
        {
            await Task.Delay(1000);

            if (user.UserName == "char" && user.Password == "1234")
                return true;
            else
                return false;
        }

        public async Task<List<Dog>> GetDogs()
        {
            await Task.Delay(1000);

            /*
            var dogs = new List<Dog>();
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlbg/795cde9d92.png", Name = "Charles", Age = "2 years", Race = "Dalmata" });
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlcj/e0004196da.png", Name = "Terry", Age = "4 years", Race = "Bulldog" });
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlc3/c34b240f69.png", Name = "Chanik", Age = "2 years", Race = "Caniche" });
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlbN/227f0f5a68.png", Name = "Peter", Age = "6 years", Race = "Basenji" });
*/
            var stringResponse = "[{\"Name\":\"Lael\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Lilah\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Claire\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Cameron\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Claire\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Maia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Claire\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Leslie\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Candice\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Gloria\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Laurel\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Genevieve\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Cheryl\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Lara\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Dahlia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Quyn\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Vielka\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Melanie\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Madison\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Skyler\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Marcia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Dora\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Beverly\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Basia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Dara\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Quincy\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Sophia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Maisie\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Mariko\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Bethany\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Jamalia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Margaret\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Rylee\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Yoko\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Shafira\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Shaeleigh\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Reagan\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Paloma\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Uma\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Rina\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Olga\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Leilani\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Noel\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Kaitlin\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Halla\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Scarlett\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Sade\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Mary\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Jeanette\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Jade\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Nayda\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Shoshana\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Serena\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Ivana\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Claudia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Ivory\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Kendall\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Lilah\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Britanney\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Giselle\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Alika\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Margaret\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Zelenia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Shelley\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Colette\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Zenia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Marcia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Fay\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Isadora\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Angelica\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Regan\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Aileen\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Haley\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Rebecca\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Sybill\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"MacKenzie\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Kelsie\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Roary\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Claudia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Skyler\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Raya\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Hanna\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Georgia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Illiana\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Courtney\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Jayme\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Daryl\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Nevada\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Imani\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Althea\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Chloe\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Uma\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Joelle\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Marah\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Chiquita\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Larissa\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Claudia\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Sydnee\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Rhona\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"},{\"Name\":\"Aiko\",\"Age\":\"2 years\",\"Race\":\"Race\",\"Photo\":\"https://puu.sh/AUlbg/795cde9d92.png\"}]";
            var dogs = await Task.Run(() => JsonConvert.DeserializeObject<List<Dog>>(stringResponse));
                    
            return dogs;
        }
    }
}
