using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2_homework2
{
    internal class capitalize
    {
        internal string Capitalize(string inputS)
        {
            inputS = char.ToUpper(inputS[0])+ inputS.Substring(1).ToLower();
            return inputS;
        }
    }
}
