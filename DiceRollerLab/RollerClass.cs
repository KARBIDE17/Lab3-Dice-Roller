using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab
{
    internal class RollerClass
    {
        public static int Roller()
        { 
            Random random = new Random();
            return random.Next();
        }

    }
}
