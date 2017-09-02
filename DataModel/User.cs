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
        public string Name { get; set; }
        public string Password { get; set; }
        public int Tarif { get; set; }
        public int Duration { get; set; }
        public int Sort { get; set; }
        public bool Ufo { get; set; }

        public List<BotProgram> BotProgramList { get; set; }

        public User()
        {}

        public User(UserCollection user)
        {
            this.Name = user.Name;
            this.Password = user.Password;
            this.Tarif = user.Tarif;
            this.Duration = user.Duration;
            this.Sort = user.Sort;
            this.Ufo = user.Ufo;

            this.BotProgramList = user.BotProgramList.ToList();
    }

        public User(string Name, string Password) : this()
        {
            this.Name = Name;
            this.Password = Password;
            Tarif = 8;
            Duration = 2;
            Sort = 1;
            Ufo = true;

            BotProgramList = new List<BotProgram>
            {
                new BotProgram("Standard", new List<int>() { 0, 1, 2, 3, 4, 5 })
            };
        }

        public override string ToString()
        {
            return this.Name;
        }

        [JsonConstructor]
        public User(string Name, string Password, int Tarif, int Duration, int Sort, bool Ufo, List<BotProgram> BotProgramList)
        {
            this.Name = Name;
            this.Password = Password;
            this.Tarif = Tarif;
            this.Duration = Duration;
            this.Sort = Sort;
            this.Ufo = Ufo;
            this.BotProgramList = BotProgramList;
        }
    }
}
