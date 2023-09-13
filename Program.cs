using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the For loop");
            for (int i = 0; i <= 5; i++)
            
            {
            Console.WriteLine(i);
                Console.WriteLine("Hii, we are looping");
                Console.WriteLine("This is i+2 " + Convert.ToInt32(i+2));
            }

            Console.WriteLine("********************");
            Console.WriteLine("*****************END OF FOR LOOP******************");
            Console.WriteLine("This is the While loop");
            int j = 0;

            while (j <= 5) 
            {
            Console.WriteLine(j);
                j++;
            }

            // Outer loop
            for (int a = 1; a <= 2; ++a)
            {
                Console.WriteLine("Outer: " + a);  // Executes 2 times

                // Inner loop
                for (int k = 1; k <= 3; k++)
                {
                    Console.WriteLine(" Inner: " + k); // Executes 6 times (2 * 3)
                }

               
            }
            
        }


    }
}
