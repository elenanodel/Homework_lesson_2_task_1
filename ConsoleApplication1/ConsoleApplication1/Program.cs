using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting
            Console.WriteLine("// Hi, user! This is a simple program that calculates two numbers you set. Let's try!");

            //addition
            Console.WriteLine("At first we're going to calculate a sum of numbers...");

            string num1;
            string num2;

            Console.Write("Please, enter the first number: ");
            num1 = Console.ReadLine();

            Console.Write("Please, enter the second number: ");
            num2 = Console.ReadLine();

            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);
            Console.WriteLine("The sum of numbers is: " + (number1 + number2));
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            //subtraction
            Console.WriteLine("Ok! And now we're going to subtract two numbers...");

            string num3;
            string num4;

            Console.Write("Please, enter the first number: ");
            num3 = Console.ReadLine();

            Console.Write("Please, enter the second number: ");
            num4 = Console.ReadLine();

            int number3 = int.Parse(num3);
            int number4 = int.Parse(num4);

            Console.WriteLine("The result of substraction is: " + (number3 - number4));
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            //multiplication
            Console.WriteLine("It's time for multiplication! We're waiting for your values... ");

            string num5;
            string num6;

            Console.Write("Please, enter the first number: ");
            num5 = Console.ReadLine();

            Console.Write("Please, enter the second number: ");
            num6 = Console.ReadLine();

            int number5 = int.Parse(num5);
            int number6 = int.Parse(num6);

            Console.WriteLine("The result of multiplication is: " + (number5 * number6));
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            //division
            Console.WriteLine("Let's calculate a division of two numbers... ");

            string num7;
            string num8;

            Console.Write("Please, enter the first number: ");
            num7 = Console.ReadLine();

            Console.Write("Please, enter the second number: ");
            num8 = Console.ReadLine();

            double number7 = double.Parse(num7);
            double number8 = double.Parse(num8);

            Console.WriteLine("The result of division is: " + (number7 / number8));
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            //rest of division
            Console.WriteLine("The last feature of this program is to calculate a rest of division!.. ");

            string num9;
            string num10;

            Console.Write("Please, enter the first number: ");
            num9 = Console.ReadLine();

            Console.Write("Please, enter the second number: ");
            num10 = Console.ReadLine();

            int number9 = int.Parse(num9);
            int number10 = int.Parse(num10);

            Console.WriteLine("The rest of division is: " + (number9 % number10));
            Console.WriteLine("Please, press 'Enter'...");
            Console.ReadLine();

            //End
            Console.WriteLine("Thank you for your attention! Goodbye!");
            Console.ReadLine();
        }
    }
}
