using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            Console.WriteLine(age);

            age++;
            Console.WriteLine(age);
            Console.WriteLine(++age);

            long bigNumber = 9000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2;
            Console.WriteLine(negative);

            string textPrecision = "35.140001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "100.54";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            string name = "John Doe";
            Console.Write("Your name is: ");
            name += " and you are a student.";
            Console.Write(name);
            Console.WriteLine();

            char letter = 'A';
            Console.WriteLine(letter);


            bool value = true;
            Console.WriteLine(value);

            value = false;
            Console.WriteLine(value);

            

            Console.ReadLine();
        }
    }
}