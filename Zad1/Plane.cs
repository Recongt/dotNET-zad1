using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Plane :Zabawka, IAccelerate
    {
        private int Accelertate;
        private Plane Plane1;
        private string name;

        public Plane(Plane Plane1)
        {
            // TODO: Complete member initialization
            this.Plane1 = Plane1;
        }

        public Plane(string name)
        {
            // TODO: Complete member initialization
            this.name = name;
        }
        
        



        public void AccelerateChangeTo(int change)
        {
            Accelertate = change;
        }




        public int getAccelerate()
        {
            return this.Accelertate;
        }



    }
}
