using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Fanctions
    {
        private string str { get; set; }

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

        public bool SearchDot(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 46)
                {
                    return true;
                }
            }
            return false;
        }

        public string DotToCommas(string text)
        {
            str = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == (char)46)
                {
                    str += (char)44;
                }
                else
                {
                    str += text[i];
                }

            }
            return str;
        }

        public int GetIndexCommas(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == (char)44)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
