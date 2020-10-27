using System;
using static System.Console;

namespace Module4A
{
    class Program
    {
        static void Main(string[] args)
        {
            int userValue1, userValue2;

            WriteLine("Please enter an integer: ");
            userValue1 = int.Parse(ReadLine());

            WriteLine("Please enter another integer: ");
            userValue2 = int.Parse(ReadLine());

            //print the values before being passed to the method
            WriteLine($"First initial value is {userValue1} and second value is {userValue2}");

            int mainSum = Addition(userValue1, userValue2);

            WriteLine($"After method call the first initial value {userValue1} and second value is {userValue2}");

            WriteLine($"The answer of the addition is {mainSum}");

        }

        static int Addition(int number1, int number2)
        {
            number1 = number1 * 2;
            number2 = number2 * 2;

            WriteLine($"The first paramameter's value in the method is {number1} and the second is {number2}");
            int sum = number1 + number2;
            

            return sum;
        }
    }
}
