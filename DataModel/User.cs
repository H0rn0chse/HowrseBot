using HowrseBot.Bot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.DataModel
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
        public int tarif { get; set; }
        public int duration { get; set; }
        public int sort { get; set; }
        public bool ufo { get; set; }

        public List<BotProgram> BotProgramList { get; set; }

        public User()
        {}

        public User(UserCollection user)
        {
            this.name = user.Name;
            this.password = user.Password;
            this.tarif = user.Tarif;
            this.duration = user.Duration;
            this.sort = user.Sort;
            this.ufo = user.Ufo;

            this.BotProgramList = user.BotProgramList.ToList();
    }

        public User(string Name, string Password) : this()
        {
            name = Name;
            password = Password;
            tarif = 8;
            duration = 2;
            sort = 1;
            ufo = true;

            BotProgramList = new List<BotProgram>(); 
            BotProgramList.Add(new BotProgram("Standard", new List<int>() { 0, 1, 2, 3, 4, 5 }));
        }

        [JsonConstructor]
        public User(string Name, string Password, int Tarif, int Duration, int Sort, bool Ufo, List<BotProgram> BotProgramList)
        {
            name = Name;
            password = Password;
            tarif = Tarif;
            duration = Duration;
            sort = Sort;
            ufo = Ufo;
            this.BotProgramList = BotProgramList;
        }
    }
}
