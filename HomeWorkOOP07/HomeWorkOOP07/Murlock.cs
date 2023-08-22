using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP07
{
    internal class Murlock : Hero           
    {
        public int NightAttack { get; set; }
        public int NightSpeed { get; set; }

        public Murlock(string name, int attackstrength, int speed, int health)
            : base(name, attackstrength, speed, health)
        {
            NightAttack = attackstrength+20;
            NightSpeed = speed+20;
        }
        public override void Attack()
        {
            if(DateTime.Now.Hour > 18)
             {
                Console.WriteLine($"{Name} Attacking with strength {NightAttack}");
            }
            else
            {
                Console.WriteLine($"{Name} Attacking with strength {AttackStrength}");
            }
        }
        public override void Run()
        {
            if (DateTime.Now.Hour > 18)
            {
                Console.WriteLine($"{Name} is running {NightSpeed}");
            }
            else
            {
                Console.WriteLine($"{Name} is  running {Speed}");
            }
        }

    }
}
