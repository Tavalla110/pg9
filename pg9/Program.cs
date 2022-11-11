using System;

namespace pg9
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string str = Console.ReadLine();
            float val = (float)Convert.ToDouble(str);
            Console.WriteLine(calculate(val));
        }
        private static double calculate(double x)
        { 
            double y = Math.Sqrt(x);
            return y;
        }
    }
}
