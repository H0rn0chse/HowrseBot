using HowrseBot.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.DataModel
{
    
    public sealed class StaticData
    {
        private static volatile StaticData instance;
        private static object syncRoot = new Object();


        private StaticData()
        {
            
        }

        public static StaticData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new StaticData();
                    }
                }

                return instance;
            }
        }

        public ObservableCollection<Item> GetItemList(string type)
        {
            ObservableCollection<Item> data = new ObservableCollection<Item>();
            switch(type)
            {
                case "CommandPool":
                    data.Add(new Item() { Caption = "Reitstunde", Text = "rs" });
                    data.Add(new Item() { Caption = "füttern", Text = "feed" });
                    data.Add(new Item() { Caption = "streicheln", Text = "stroke" });
                    data.Add(new Item() { Caption = "tränken", Text = "drink" });
                    data.Add(new Item() { Caption = "schlafen", Text = "sleep" });
                    data.Add(new Item() { Caption = "striegeln", Text = "groom" });
                    break;
                case "Duration":
                    data.Add(new Item() { Caption = "1 Tag", Value = 1, Text = "tarif1" });
                    data.Add(new Item() { Caption = "3 Tag", Value = 3, Text = "tarif2" });
                    data.Add(new Item() { Caption = "10 Tag", Value = 10, Text = "tarif3" });
                    data.Add(new Item() { Caption = "30 Tag", Value = 30, Text = "tarif4" });
                    data.Add(new Item() { Caption = "60 Tag", Value = 60, Text = "tarif5" });
                    break;
                case "Sort":
                    data.Add(new Item() { Caption = "Name", Text = "nom" });
                    data.Add(new Item() { Caption = "Alter", Text = "age" });
                    data.Add(new Item() { Caption = "Rasse", Text = "race" });
                    data.Add(new Item() { Caption = "Geburtsdatum", Text = "naissance" });
                    data.Add(new Item() { Caption = "Fähigkeiten", Text = "competence" });
                    data.Add(new Item() { Caption = "Genetisches Potenzial", Text = "potentiel-genetique" });
                    break;
                case "Tarif":
                    for (int i = 20; i <= 200; i += 10)
                    {
                        data.Add(new Item() { Caption = i + " / Tag", Value = i });
                    }
                    break;
            }
            return data;
        }
    }
}
