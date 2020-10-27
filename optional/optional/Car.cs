using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional
{
    class Car
    {
        public int stoptime(int speed, int breakeforce = 1)
        {
            int stoptime = speed / breakeforce;
            return stoptime;
        }
    }
}
