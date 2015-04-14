using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Submarine :IDive
    {
        private int Accelertate;
        private int Dive;
        private int Rise;

        public void DiveChangeTo(int change)
        {
            Dive = change;
        }
    }
}
