using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Greeting();
            Console.WriteLine();
            Console.WriteLine("-------------testing line-----------");
            Console.WriteLine();
            Greeting();
            Console.WriteLine();

            int number = 24;
            Console.WriteLine("The value of number in the Main is {0}.", number);
            DisplayVariable();
            Console.WriteLine("The value of number in the Main is {0}.", number);
            Console.WriteLine();

            DisplayPassedVariable(number);
            Console.WriteLine("The value of number in the Main is {0}.", number);
            Console.WriteLine();

            DisplayProduct(27, number);
            Console.WriteLine();

            Console.WriteLine("The double value returned from this method is {0}.",GetNumberTimesTwo(number));// could use var: int double = GetNumberTimesTwo(number) and put the variable in the end
            Console.WriteLine();

            int[] numbers = new int[5] { 16, 19, 4, 14, 20 };

            foreach (int n in numbers)
            {
                Console.Write("{0} ", n); // foreach loop goes through all elements and prints them in order

            }

            Console.WriteLine();
            UpdateOneElement(number);
            Console.WriteLine();

            //int[] numbers = new int[5] {16, 19, 4, 14, 20};
            // in the foreach loop elements printed initial values 
            foreach (int n in numbers)
            {
                Console.Write("{0} ", n); // foreach loop goes through all elements and prints them in order

            }

            Console.WriteLine();
            Console.WriteLine();
            UpdateWholeArray(numbers);
        
            Console.WriteLine();

            // foreach loop goes through all elements and prints them in order - this time updated - because AFTER the method, which updates them -  UpdateWholeArray(numbers);
            foreach (int n in numbers)
            {
                Console.Write("{0} ", n); 

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'enter' to exit..");
            Console.ReadKey();
        }
        //my own methods

        static void UpdateOneElement(int number) {
            Console.WriteLine();
            Console.WriteLine("The value of number before change is {0}.", number);
            number = 17;
            Console.WriteLine("The value of number after change is {0}.", number);

        }

        //method taking array as argument
        static void UpdateWholeArray(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Element {0} before change : {1}", i, numbers[i]); // i = number of place in the array; numbers[i] - value of variable in that place of array
                numbers[i] += 10;
                Console.WriteLine("- and after the change it's {0}.", numbers[i]);
            }

            Console.WriteLine();
        }


        static int GetNumberTimesTwo(int number) {
            return number * 2;
        }

        static void DisplayVariable() {
            int number = 42;
            Console.WriteLine("The value of number in the  method is {0}.", number);
           
            
        }

        static void DisplayPassedVariable(int num) {

            Console.WriteLine("The value of passed number in the  method before the change is {0}.", num);
            num = 59;
            Console.WriteLine("The value of the passed number in this method is {0}.", num);
        }

        static void DisplayProduct(int x, int y) {
            Console.WriteLine("{0} times {1} equals {2}", x, y, x * y);
        }

        static void Greeting() {

            Console.WriteLine("Hello world!");
            Console.WriteLine("My name is Natasha.");
            Console.WriteLine("Professor Morris is a good teacher!");
        }
    }
}
