using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Submarine :Zabawka, IDive, IAccelerate
    {
        private int Accelertate;
        private int Dive;
        private string name;
        


        public Submarine(int nAccelerate, int nDive)
        {
            // TODO: Complete member initialization
            Accelertate = nAccelerate;
            Dive = nDive;
            
        }

        public Submarine(string name)
        {
            // TODO: Complete member initialization
            this.name = name;
        }

        public void DiveChangeTo(int change)
        {
            Dive = change;
        }

        public void AccelerateChangeTo(int change)
        {
            Accelertate = change;
        }


        public int getDive()
        {
            return this.Dive;
        }

        
       
        public int getAccelerate()
        {
            return this.Accelertate;
        }



    }
}
