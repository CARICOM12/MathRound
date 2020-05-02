using System;

namespace MathRound
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int integerNumber = 45;
            integerNumber = (int)Math.Round(34.67);
            Console.WriteLine(integerNumber);

            int number = 20;
            number = (int)Math.Round(21.32);
            Console.WriteLine(number);

            string str = "Hello world!";
            str = str + "!";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Substring(0, 9));
            char a = str[0];
            Console.WriteLine(a);
            str = null;

            string st = Console.ReadLine();
            int number = int.Parse(st);
            number = number + 1;
            st = number.ToString();
            Console.WriteLine(number + 1);
        }
    }
}
