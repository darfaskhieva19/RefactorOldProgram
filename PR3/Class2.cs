using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Class2
    {
        public static string txt;
        public static void remov(int k)
        {
            txt = txt.Remove(k);
            Console.WriteLine($"Измененная строка: {txt}");
        }
    }
}
