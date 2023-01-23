using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab
{
    public static class RollerClass
    {
        public static Random random = new Random();
        public static int Roller6()
        { 
            return random.Next(1,7);
        }
        public static int Roller(int sides)
        {
            return random.Next(1, sides + 1);
        }

    }
}
