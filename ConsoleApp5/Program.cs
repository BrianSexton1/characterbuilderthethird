using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new List<string>();
            classes.Add("Hunter");
            classes.Add("Fighter");
            classes.Add("Rogue");

        top:

            Console.WriteLine("Welcome to the character creator");
            Console.WriteLine("what is your characters name?");



            string charName = Console.ReadLine();
            Console.WriteLine("characters name is " + charName);

        reclass:

            Console.WriteLine("Choose your class");
            classes.ForEach(Console.WriteLine);
            string charClass = Console.ReadLine().ToUpper();



            // insert cheesy line 

            if (charClass == "ROGUE")
            {
                Console.WriteLine("Welcome Rogue, may the shadows hide you!");
            }

            else if (charClass == "FIGHTER")
            {

                Console.WriteLine("Welcome Fighter, may the gods bathe in your enemies blood... ");
            }
            else if (charClass == "HUNTER")
            {
                Console.WriteLine("Welcome Hunter, may the wilderness guide your hunt!");

            }

            else
            {
                Console.WriteLine("Entry not valid, please check the list and try again");
                goto reclass;
            }

            Console.WriteLine("Would you like to role for your attribute numbers? enter \"Yes\" to roll or \"Reclass\" to pick a different class.");
            string charRoll = Console.ReadLine().ToUpper();


            if (charRoll == "RECLASS")
            {
                goto reclass;
            }


            if (charRoll == "YES")
            {
                Console.WriteLine("Rolling attributes");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");

                // rolls are random with min/max depending on attribute and class.


                // Fighter Class

                if (charClass == "FIGHTER")
                {
                    Random num1 = new Random();
                    int fstr = num1.Next(13, 19);
                    Console.WriteLine(charName + " Strength is " + fstr);

                    Random num2 = new Random();
                    int fagi = num2.Next(8, 16);
                    Console.WriteLine(charName + " Agility is " + fagi);


                    Random num3 = new Random();
                    int flif = num3.Next(13, 21);
                    Console.WriteLine(charName + " Hitpoints are " + flif);
                }


                // Rogue Class

                if (charClass == "ROGUE")
                {
                    Random num1 = new Random();
                    int rstr = num1.Next(8, 16);
                    Console.WriteLine(charName + " Strength is " + rstr);

                    Random num2 = new Random();
                    int ragi = num2.Next(13, 19);
                    Console.WriteLine(charName + " Agility is " + ragi);

                    Random num3 = new Random();
                    int rlif = num3.Next(10, 18);
                    Console.WriteLine(charName + " Hitpoints are " + rlif);
                }

                // Hunter Class 

                if (charClass == "HUNTER")
                {
                    Random num1 = new Random();
                    int hstr = num1.Next(11, 17);
                    Console.WriteLine(charName + " Strength is " + hstr);

                    Random num2 = new Random();
                    int hagi = num2.Next(10, 19);
                    Console.WriteLine(charName + " Agility is " + hagi);


                    Random num3 = new Random();
                    int hlif = num3.Next(11, 19);
                    Console.WriteLine(charName + " Hitpoints are " + hlif);
                }


                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Would you like to build another character? \"Yes\" or \"No\"");
                string anotherChar = Console.ReadLine().ToUpper();

                if (anotherChar == "YES")
                {

                    goto top;
                }

                else
                {
                    Console.WriteLine("Character creation complete!");
                    System.Threading.Thread.Sleep(2000);
                   

                    /*
                     * 
                     * further idea if needed. 
                    Console.WriteLine("Do you want to do a practice battle? Type \"Yes\" or \"No\"");
                    string practice = Console.ReadLine().ToUpper();
                     
                    */
                }

            }
        }

        public class Hunter
        {
            public int hstr { get; set; }
            public int hagi { get; set; }
            public int hlif { get; set; }

        }
        public class Fighter
        {
            public int fstr { get; set; }
            public int fagi { get; set; }
            public int flif { get; set; }


        }

        public class Rogue
        {
            public int rstr { get; set; }
            public int ragi { get; set; }
            public int rlif { get; set; }


        }
    }


}