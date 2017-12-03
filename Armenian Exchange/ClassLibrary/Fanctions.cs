using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Fanctions
    {
        public bool SearchComma(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == 44)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
