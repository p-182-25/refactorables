using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, counter = 0;
            UserInput.Input(out n);
            Console.WriteLine("Refactorable numbers within the range from 1 to {0}:", n);
        
            for (int i = 1; i <= n; i++) //iterte through each number
            {
                for (int j = 1; j <= i/2; j++) //itarete through each potential divider
                {
                    if (i % j == 0) counter++; //looking for and counting dividers
                }
            counter++; //finally add the number itself (i) to its dividers as we iterate only up to i/2
            
            if (i % counter == 0) Console.WriteLine(i); //check the refactorable condition and print
                
            counter = 0; //reset counter before checking next number (i)
            }
        }
    }
    
    class UserInput
    {
        public static void Input(out int x)
        {
            x = 1;
            //Console.Write("Enter the max of the range (from 1 to max): ");
            try
            {
                x = int.Parse(Console.ReadLine());
                if (x < 1)
                {         
                   Console.WriteLine("Wrong input. You should enter a positive integer number.");
                   Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input. You should enter a positive integer number.");
                Console.WriteLine(e);
            }
        }
    }
}