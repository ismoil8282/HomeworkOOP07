using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP07
{
    internal class Lion : Hero
    {
        public readonly int NormalHealth = 50;
        public Lion(string name, int attackstrength, int speed, int health)
            : base(name, attackstrength, speed, health)
        {
            
        }
        public override void Run()
        {
            if(NormalHealth > Health)
            {
                Console.WriteLine($"{Name}'s speed is decrease in {Speed - (Speed * 0.4)}/hp ");   
            }
            else
            {
                Console.WriteLine($"{Name} is running {Speed}");
            }
        }
    }
}
