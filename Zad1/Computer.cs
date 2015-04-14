using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Computer  : IDive, IRise
    {
        private int Accelertate;
        private int Dive;
        private int Rise;

        public void RiseChangeTo(int change)
        {
            Rise = change;
        }
        public void DiveChangeTo(int change)
        {
            Dive = change;
        }
    }
}
