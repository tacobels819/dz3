using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoriz
{
    public class Class1
    {
        public static void avtoriz (string a, string l, out bool d)
        {
            d = false;
            if (a == "ADMIN" && l == "ADMIN")
                d = true;
        }
    }
}
