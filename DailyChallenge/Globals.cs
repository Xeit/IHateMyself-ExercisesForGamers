using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Globals
{
    public static Random rand;
    public static Int32 a = 15;

    public static Boolean InitializeGlobals()
    {
        rand = new Random((Int32)DateTime.Now.Ticks); //Gets seed for random number generator (We don't care about data loss)
        a = 35;
        return true;
    }
}
