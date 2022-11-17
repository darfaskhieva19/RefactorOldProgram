using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Class4
    {
        private double rost;
        private double ves;

        public double getV
        {
            set
            {
                ves = value;
            }
        }
        public double getR
        {
            set
            {
                rost = value;
            }
        }
        public string MassaT
        {
            get
            {
                double mas = ves / (Math.Pow(rost / 100, 2));
                if (mas <= 18.5)
                {
                    return "Дефицит массы тела";
                }
                else if (mas > 18.5 && mas < 25)
                {
                    return "Норма";
                }
                else
                {
                    return "Избыточная массa тела";
                }
            }
        }
    }
}
