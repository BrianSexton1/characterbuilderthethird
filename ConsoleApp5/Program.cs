using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var classes = new List<string>();
            classes.Add("Hunter");
            classes.Add("Fighter");
            classes.Add("Rogue");

        
         
        Top:
             
           
             DateTime daysLeft = new DateTime(2048, 04, 05);
             DateTime startDate = DateTime.Now;
             TimeSpan dt = daysLeft - startDate;
            Console.WriteLine(dt + " days, hours ,min , seconds left until Character dies of old age");

            Console.WriteLine("Welcome to the character creator");
            Console.WriteLine("what is your characters name?");
                
                

            string charName = Console.ReadLine();
            Console.WriteLine("characters name is " + charName);

        reclass:

            Console.WriteLine("Choose your class or type \"exit\"");
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
            else if (charClass == "EXIT")
            {
                Console.WriteLine("Exiting");

                Environment.Exit(0);

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
                    var fighter= new Fighter();
                    Random num1 = new Random();
                    fighter.str = num1.Next(13, 19);
                    Console.WriteLine(charName + " Strength is " + fighter.str);
                    

                    Random num2 = new Random();
                    fighter.agi = num2.Next(8, 16);
                
                    Console.WriteLine(charName + " Agility is " + fighter.agi + " Agilty check = " + fighter.GetAgilityPercentage()+ "%");


                    Random num3 = new Random();
                    fighter.lif = num3.Next(13, 21);
                    Console.WriteLine(charName + " Hitpoints are " + fighter.lif);
                }


                // Rogue Class

                if (charClass == "ROGUE")
                {
                    var rogue= new Rogue();
                    Random num1 = new Random();
                    rogue.str = num1.Next(8, 16);
                    Console.WriteLine(charName + " Strength is " + rogue.str);

                    Random num2 = new Random();
                    rogue.agi = num2.Next(13, 19);
                    
                    Console.WriteLine(charName + " Agility is " + rogue.agi + " Agility check = " + rogue.GetAgilityPercentage() + "%");

                    Random num3 = new Random();
                    rogue.lif = num3.Next(10, 18);
                    Console.WriteLine(charName + " Hitpoints are " + rogue.lif);
                }

                // Hunter Class 

                if (charClass == "HUNTER")
                {
                    var hunter= new Hunter();   
                    Random num1 = new Random();
                    hunter.str = num1.Next(11, 17);
                    Console.WriteLine(charName + " Strength is " + hunter.str);

                    Random num2 = new Random();
                    hunter.agi = num2.Next(10, 19);
                    
                    Console.WriteLine(charName + " Agility is " + hunter.agi + " Agility check = " +hunter.GetAgilityPercentage() + "%");


                    Random num3 = new Random();
                    hunter.lif = num3.Next(11, 19);
                    Console.WriteLine(charName + " Hitpoints are " + hunter.lif);
                }


                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Would you like to build another character? \"Yes\" or \"No\"");
                string anotherChar = Console.ReadLine().ToUpper();

                if (anotherChar == "YES")
                {
                       goto Top;
                }

                else
                {
                    Console.WriteLine("Character creation complete!");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);

                }
            }
        } 
       
        public class Character
        {
            public int str { get; set; }    
            public int agi { get; set; }    
            public int lif { get; set; }    
        }
        public class Hunter: Character
        {
            public int GetAgilityPercentage (){return agi*6;}
        }
        public class Fighter: Character
        {
            public int GetAgilityPercentage (){return agi*5;}
        }
        public class Rogue: Character
        {
            public int GetAgilityPercentage (){return agi*7;}
        }
    


}  } 