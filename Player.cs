using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millioner
{
    public class Player
    {
        private int points = 0;

        public int Points { get { return points; } }

        public void IncresePoints(int value)
        {
            if (value > 0)
                points += value;
        }
    }
}
