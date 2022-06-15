using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Army army = new Army();
        }
    }

    class Army
    {
        private List<Soldier> _soldiers = new List<Soldier> {new Soldier("Иван","Ак-74","Рядовой",12), new Soldier("Андрей", "Ак-74", "Рядовой", 8), new Soldier("Василий", "Ак-74М", "Сержант", 48) };

        public Army()
        {
            ShowNamesAndRanks();
        }

        private void ShowNamesAndRanks()
        {
            var sortedSoldiers = from Soldier soldier in _soldiers select new { name = soldier.Name, rank = soldier.Rank };

            foreach (var soldier in sortedSoldiers)
            {
                Console.WriteLine($"Имя: {soldier.name} Звание: {soldier.rank}");
            }
        }
    }

    class Soldier
    { 
        public string Name { get; private set; } 
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int ServiceTime { get; private set; }

        public Soldier(string name, string weapon, string rank, int serviceTime)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServiceTime = serviceTime;
        }
    }
}