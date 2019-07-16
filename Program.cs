using System;

namespace DarkSouls_Generator
{
    class Program
    {

        //Name method here, with class selection random generator
        static void Playername(string playerNam = "Idiot")
        {

            Console.WriteLine("\nWelcome to the Dark Souls Adventure Generator, {0}", playerNam);
                Console.ReadLine();
            Console.WriteLine($"\n{playerNam}, you're brutal journey is about to begin, prepare yourself.... ");
                Console.ReadLine();
            string[] startAdv = new string[4];
            startAdv[0] = "\nYou emerge from the ash with a Dagger and Buckler in hand, ready to begin your life as a Thief!";
            startAdv[1] = "\nAs you breath the flame of life once again, magic flows through you as you wield your Staff, welcome to the world of Embers Sorcerer!";
            startAdv[2] = "\nYou awaken with a Greatsword next to you, left by some warrior who body lies with his wolf next to the grave. The Abyss awaits you Artorius";
            startAdv[3] = "\nYou are a naked man with nothing at your disposal, you fashion a loin cloth out of some scraps and step off you Deprived!";
            Random step1 = new Random();
            Console.WriteLine($"\n{startAdv[step1.Next(0, 3)]}");
                Console.ReadLine();
            var noLuck = step1.Next(0, 3);

            if (noLuck == 4)
            {
                Console.WriteLine("Press Enter");
                Console.ReadLine();
                Console.WriteLine("\nYour luck in this life is as bad as your last, someone scavenged all the weapons and you have nothing to defend yourself....");
                Console.WriteLine("\nYOU DIED try again next life");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nSome things are entirely decided by luck.....");
            }

        }
        //Continue Method, first real decision made by user
        static void Continue(string askCont = "YOU DIED because you hesitated to make a decision")
        {

            Console.WriteLine("\nWith the memories of your past death fresh in your mind you shiver at the thought of going through it again");
            Console.ReadLine();
            Console.WriteLine("\nWould you like to take the weapon and try to live once again? Enter 'Y' or 'N'");

            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("\nYou have chosen to continue, and immediatlly see approching ghouls");
            }
            else
            {
                Console.WriteLine("YOU DIED, while putting your weapon down you were attacked by ghouls and they sucked the life out of you");
                Console.WriteLine("You were so afraid to die again, Death saw fit to rid you of this exsistance");
                Environment.Exit(0);
            }
        }
        //Second Choice by user, one side is certain death---maybe expand on this later to another set of adventures
        static void Choicetwo(string leftArch = "Left", string rightLight = "Right")

        {

            if (Console.ReadLine() == "L")
            {
                Console.WriteLine("\nYou have chosen to go left under the arch");
            }
            else
            {
                Console.WriteLine("\nYOU DIED, a Black Knight got smart and ambushed you while you were blinded by the light, smashing you into the ground and exploding open your chest cavity.");
                Environment.Exit(0);
            }

        }
        //Third Choice, rewrite this is just a placeholder for the third part of the adventure. 
        static void Choicethree(string thirdAdv = "YOU DIED to some bees.........Loser")
        {
            string[] advChoice3 = new string[5];
            advChoice3[0] = "\nThe bees are protecting their Queen whom you kicked on your way under the arch";
            advChoice3[1] = "\nYou go jump into a pond and the bees fly over you into a nest behind the pond, ignoreing you all together";
            advChoice3[2] = "\nYou destroy the bees with your weapons that were left to you near your grave";
            advChoice3[3] = "\nThe Bees are friendly and ask to travel with you";
            advChoice3[4] = "\nYou take major damage from the bees but luckly destroy them, you wonder if you will make it out of this place alive";
            Random advStep = new Random();
            Console.WriteLine($"\n{advChoice3[advStep.Next(0, 5)]}");

            var beeLuck = advStep.Next(0, 5);
            if (beeLuck == (1))
            {
                Console.WriteLine("\nYou realize you were ignored because the Bees were running from a Bear Giant.");
                Console.ReadLine();
                Console.WriteLine("\nYOU DIED");
                Console.ReadLine();
                Console.WriteLine("\nThe Bear Giant took one swing of his claws and turned you into pink mist");
            }
            else
            {
                Console.WriteLine("YOU DIED!, because you got Dysentery or something. And i havent finished this yet, and ");
            }

        }
        //MAIN method here// Work to clean up and not have as much raw code here
        static void Main(string[] args)
        {
            Console.WriteLine("This is a guided game, keep CAPS lock on and follow the prompts, AND press ENTER to get the next text prompt");
            Console.WriteLine("GOOD LUCK");
            Console.WriteLine("PRESS ENTER");
                Console.ReadLine();
            
            //Adventure starts with a name
            Console.WriteLine("What is your name?");
            Playername(Console.ReadLine());
            Continue();
            

            Console.WriteLine("\nYou have picked up your weapon and fought off the scavengers.");
                Console.ReadLine();
            Console.WriteLine("\nYou now have a choice, go Left through a beautifully adorned arch, or Right through an opening in the mountain, with light shining through.");
                Console.ReadLine();
            Console.WriteLine("Choose 'L' or 'R'");
            Choicetwo();


            Console.WriteLine("\nAs you walk down the path behind the arch, YOU ARE AMBUSHED BY GIANT BEES ");
                Console.ReadLine();
            Choicethree();



        }
    }
}
