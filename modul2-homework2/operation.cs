using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2_homework2
{
    internal class operation
    {
        internal double Reverse(double input)
        {
            string result = " ";
            string numberasstring = input.ToString();
            string[] parts = numberasstring.Split(',');
            result = parts[1]+","+parts[0];
            double inputN = double.Parse(result);
            return inputN;
        }
    }
}
