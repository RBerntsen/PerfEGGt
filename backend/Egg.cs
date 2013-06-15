using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace backend
{
    public class Egg : IEgg
    {
        //Fields + get/set
        public int BoilTime { get; set; }
        public string Tip { get; set; }

        //Constructor
        public Egg(int boilTime, string tip)
        {
            this.BoilTime = boilTime;
            this.Tip = tip;
        }

        public override string ToString()
        {
            return "This is an egg. A delicious egg. Boiltime is: " + BoilTime.ToString() + ". Tip is: " +
                   Tip + ".";
        }

    }
}
