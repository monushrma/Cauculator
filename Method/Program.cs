using System;

namespace Method
{
    class Program
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
        //Method with no argument and no return type
        static void Main(string[] arg)
        {
            int a =20;
            int b = 50;
            Program max = new Program();
            int c = max.FindMax(a, b);
            Console.WriteLine("Max value is:"+c);
            Console.ReadLine();
        }
    }

  
}




