using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Car :Zabawka,  IAccelerate
    {
        private int Accelerate;
        private string Nazwa;








        public Car(int a)
        {
            this.Accelerate = a;
        }


        public Car(string Nazwa)
        {
            // TODO: Complete member initialization
            this.Nazwa = Nazwa;
        }

        public void AccelerateChangeTo(int change)
        {
            this.Accelerate = change;

        }
        public int getAccelerate()
        {
            return this.Accelerate;
        }




    }
}
