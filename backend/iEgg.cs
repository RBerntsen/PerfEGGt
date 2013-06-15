using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace backend
{
    interface IEgg
    {
        int BoilTime { get; set; }
        string Tip { get; set; }
        string ToString();
    }

}
