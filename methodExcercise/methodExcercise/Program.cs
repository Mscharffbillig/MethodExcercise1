using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExcercise
{
    class MethodExcerscise
    {
        
        public static void Main() 
        {
            
            
        }

        public static void AdLib() 
        
            {
                string str1;
                string str2;
                string str3;
                string str4;

                Console.WriteLine("Hello, please pick a name...");

                str1 = Console.ReadLine();
                Console.WriteLine("Perfect! Now, please pick a color");

                str2 = Console.ReadLine();
                Console.WriteLine("One of my favorites! How about an animal?");

                str3 = Console.ReadLine();
                Console.WriteLine("Wow. Didnt expect that. Okay. what about a Band?");

                str4 = Console.ReadLine();
                Console.WriteLine($"{str1} {str2} {str3} {str4}");

                Console.WriteLine("Want to hear a story about what you've chosen?");
                Console.WriteLine("Hit Enter!");
                Console.ReadLine();

                Console.WriteLine($"There once was a Zookeeper name {str1}");
                Console.WriteLine($"He/She was doing rounds and feeding the animals when");
                Console.WriteLine($"out of nowhere a {str2} {str3} came running out of a cage!");
                Console.WriteLine($"It barelled into some trash cans and made quite the racket!");
                Console.WriteLine($"The sound was music to {str1}'s ears.");
                Console.WriteLine($"{str1} being inspired, started a band called {str4}!");
                Console.ReadLine();

            }
        
       
    }

}


