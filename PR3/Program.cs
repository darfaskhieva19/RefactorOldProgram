using System;

namespace PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1");
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Class1 obj = new Class1(n);
            Console.WriteLine(obj);
            Class1 obj1 = new Class1();
            Console.WriteLine(obj1);

            Console.WriteLine("Задача №2");
            Console.WriteLine("Введите строку: ");
            Class2.txt = Console.ReadLine();
            Console.WriteLine("Введите индекс: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Class2.remov(k);

            Console.WriteLine("Задача №4");
            Class4 ind = new Class4();
            Console.WriteLine("Введите рост: ");
            ind.getR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес: ");
            ind.getV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ind.MassaT);

            Console.WriteLine("Задача №3");
            Console.WriteLine("Введите первую строку: ");
            string st = Console.ReadLine();
            Console.WriteLine("Введите первый символ: ");
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите вторую строку: ");
            string st2 = Console.ReadLine();
            Console.WriteLine("Введите второй символ: ");
            char s2 = Convert.ToChar(Console.ReadLine());
            Class3 l = new Class3(st, s);
            Class3 l1 = new Class3(st2, s2);
            Console.WriteLine(l + l1);
            Console.WriteLine(l - l1);
        }
    }
}
