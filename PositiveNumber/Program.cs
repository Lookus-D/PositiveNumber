using System;

namespace PositiveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App to check that number is positive or negative");
            Console.WriteLine("Write any number");
            string number = Console.ReadLine();
            int chosenNumber = 0;
            Int32.TryParse(number, out chosenNumber);

            switch (chosenNumber) 
            {
                case >=0:
                    Console.WriteLine("Your number is positive");
                        break;
                case <0:
                    Console.WriteLine("Your number is negative");
                        break;
            }
        }
        
    }

}
