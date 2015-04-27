using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Dino : Zabawka, IRise
    {

        private int Rise;
        private string name;


        public Dino(int rise)
        {

            this.Rise = rise;
        }

        public Dino(string name)
        {
            // TODO: Complete member initialization
            this.name = name;
        }



        public void RiseChangeTo(int change)
        {
            this.Rise = change;
        }

        public int getRise()
        {
            return this.Rise;
        }



    }


    

}
