using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Class1
    {
        private int n;

        public Class1(int n)
        {
            this.n = n % 10;
        }
        public Class1()
        {
            n = -1;
        }
        public override string ToString()
        {
            return "Значение целочисленного поля: " + n;
        }
    }
}
