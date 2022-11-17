using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Class3
    {
        string s;
        char c;
        public Class3(string s, char c)
        {
            this.s = s;
            this.c = c;
        }
        public static int operator +(Class3 a, Class3 b)
        {
            return a.s.Length + b.s.Length;
        }
        public static string operator -(Class3 a, Class3 b)
        {
            int k = (int)a.c - (int)b.c;
            if (k < 0)
            {
                return "Разность отрицательная";
            }
            else
            {
                return Convert.ToString((char)k);
            }
        }
    }
}
