using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP07
{
    internal class Hero
    {
        public string Name { get; set; }
        public int AttackStrength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public Hero(string name, int attackstrength, int speed, int health)
        {
            Name = name;
            AttackStrength = attackstrength;
            Speed = speed;
            Health = health;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacking with strength {AttackStrength}");
        }
        public virtual void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
        public void Defend()
        {
            Console.WriteLine($"{Name} is defending");
        }
        public  void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"AttackStrength : {AttackStrength}");
            Console.WriteLine($"Speed : {Speed}");
            Console.WriteLine($"Health : {Health}");
        }

    }
}
