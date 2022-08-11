using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_and_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Color Change, Welcome Notice and Title//
            Console.Title = "The Game";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Game Version 1.0.0 \nby Matvei Cloutier\n");

            //Assign Game Color and Run Verification Method//
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello User, My Name is \"T43-G4AM3\" or \"THE GAME\" to Humans...");
            Console.WriteLine("Please Enter Your Name and Validate That You Are Human..");
            //Run THE GAME WELCOME//
            THEGAME();
            
            
            //Wait to close//
            Console.ReadKey();
        }

        //Verification Sequence Asking User's Name and Species//
        static void THEGAME()
        {
            Console.Write("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Are You Human? [Y or N]");
            string answer = Console.ReadLine();

            //If-NOT FIRST ALWAYS
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("PLease enter a valid Answer [Y OR N]");
                answer = Console.ReadLine();

                if (answer == "y" || answer == "n")
                { }
                else if (answer != "y" && answer != "n")
                {
                    continue;
                }
            }
            //
            if (answer == "y")
            {
                Console.WriteLine($"Welcome Human, {userName}");
               
                
                return;

            }
            if (answer == "n")
            {
                Console.WriteLine("What Species Are You?");
                string species = Console.ReadLine();
                Console.WriteLine($"Welcome {species}, {userName}");
                
                
                return;
            }   
        }
       
    }
}




