/*
    Author: Yao Xiao   
    Date: 1/30/2019
    Comments: This C# Console application code demonstrates the use of
              Arrays after getting input from users. 
*/

using System; 

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer between 1 and 25: ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                Console.WriteLine("");
                int[] countdown = new int[value_of_input];
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("You have entered the number: " + value_of_input);
                Console.WriteLine("Therefore, " + value_of_input + " elements should be populated in the array.");
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("");
                int pop_array = 0;
                for (int i = 0; i < value_of_input; i++)
                {
                    countdown[i] = pop_array;
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            }
        }
    }
}
