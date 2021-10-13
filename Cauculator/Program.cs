using System;

namespace Calculator      //Learn OOPS concept
{
    public class Calculator
    {
        int num1;
        int num2;
        int result;

        void Add()
        {
            result = (num1 + num2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void Subtract()
        {
            result = (num1 - num2);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        void Multiple()
        {
            result = (num1 * num2);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        void Division()
        {
            result = (num2 / num1);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public static void Main(string[] arg)
        {
            Console.WriteLine("MonuSharma");
            Console.ReadLine();
            Calculator obj = new Calculator();
            obj.num1 = 10;
            obj.num2 = 20;
         
            obj.Subtract();
            obj.Add();
            obj.Multiple();
            obj.Division();

            Calculator obj1 = new Calculator();
            obj1.num1 = 50;
            obj1.num2 = 100;
            obj1.Add();
            obj1.Subtract();
            obj1.Multiple();
            obj1.Division();

        }



    }


}








        
