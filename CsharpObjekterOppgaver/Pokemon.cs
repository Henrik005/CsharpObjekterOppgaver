using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpObjekterOppgaver
{
    public class Pokemon
    {
        public int Level { get; set; }
        public int Health { get; set; }
        private string Name { get; set; }
        public string Specie { get; set; }

        public Pokemon(int level, int health, string name, string specie)
        {
            Name = name;
            Health = health;
            Level = level;
            Specie = specie;
        }
        public void PrintStats()
        {


            Console.WriteLine($" Name: {Name}. Specie: {Specie}. Level: {Level}. Health: {Health}.");
            

        }
        //Console.WriteLine($"Name: {Name}");
        //Console.WriteLine($"Specie: {Specie}");
        //Console.WriteLine($"Level: {Level}");
        //Console.WriteLine($"Health: {Health}");
        //public string GetName()
        //{
        //    return Name;
        //}
        //public string ChangeName(string newName)
        //{
        //    Name = newName;
        //    return GetName();
        //}
    }

}
