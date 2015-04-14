using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Plane : IAccelerate
    {
        private int Accelertate;
        private int Dive;
        private int Rise;



        public void AccelerateChangeTo(int change)
        {
            Accelertate = change;
        }

        public Plane(int nAccelerate, int nDive, int nRise)
        {
            Accelertate = nAccelerate;
            Dive = nDive;
            Rise = nRise;
        }
    }
}
