using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsLander
{
    class UserInterface
    {

        public void PrintGreeting()
        {
            Console.WriteLine("Welcome to the Mars Lander game!");
        }

        public void PrintLocation(MarsLander ml)   //This code feels redundant and i feel it can be optimized
        {
            bool printed = false;
            Console.WriteLine();
            int ix;
            if (ml.height > 1000)
                ix = (int)(Math.Floor((double)ml.height / 100) * 100);
            else
                ix = 1000;
            for (int i = ix; i > 0; i=i-100)
            {
                Console.Write("{0}m: ", i);
                if (i <= ml.height && !printed)
                {
                    Console.Write("*");
                    printed = true;
                }
                Console.WriteLine();
            }
        }

        // This prints out the info about the lander
        // For example:
        //      Exact height: 1350 meters
        //      Current (downward) speed: -350 meters/second
        //      Fuel points left: 0
        public void PrintLanderInfo(MarsLander ml)
        {
            Console.WriteLine();
            Console.WriteLine("Exact height: {0} meters", ml.height);
            Console.WriteLine("Current (downward) speed: {0} meters/second",ml.speed);
            Console.WriteLine("Fuel points left: {0}", ml.fuelPoints);
        }

        // This will ask the user for how much fuel they want to burn,
        // verify that they've type in an acceptable integer,
        //  (repeatedly asking the user for input if needed),
        // and will then return that number back to the main method
        public int GetFuelToBurn(MarsLander ml)
        {
            int input = -1;
            while(input < 0 || input > ml.fuelPoints)
            {
                Console.WriteLine("How many points of fuel would you like to burn?");
				while (Int32.TryParse(Console.ReadLine(), out input) == false)
				{
					Console.WriteLine("you need to type a valid intiger");
				}
				if (input < 0)
				{
					Console.WriteLine("you cannot burn negative fuel");
					continue;
				}
				if (input > ml.fuelPoints)
				{
					Console.WriteLine("you dont have that much fuel! you have {0} fuel points", ml.fuelPoints);
					continue;
				}
            }
            return input; 
        }

        // This will only be called once the lander is on the surface of Mars, 
        //  and will tell the player if they successly landed or if they crashed
        public void PrintEndOfGameResult(MarsLander ml, int maxSpeed)
        {
            if (ml.speed > maxSpeed)
                Console.WriteLine("The maximum speed for a safe landing is {0}; " +
                                  "your lander's current speed is {1}" +
                                  "\nYou have crashed the lander into the surface of Mars, " +
                                  "killing everyone on board,\ncosting NASA millions of dollars, " +
                                  "and setting the space program back by decades!", maxSpeed, ml.speed);
            else
                Console.WriteLine("Congratulations!! You've successfully landed your Mars Lander, without crashing!!!");
            PrintHistory(ml.getHistory());
        }
        
        // This will print out, for example: 
        //      Round # 	Height (in m) 	Speed (downwards, in m/s)
        //      0 		850 		150
        //      1 		650 		200
        //  etc
        //
        // This is provided to you, but you'll need to add stuff elsewhere in order to make it work 
        public void PrintHistory(MarsLanderHistory mlh)
        {
            Console.WriteLine("Here's the height/speed info for you:");
            Console.WriteLine("Round #\t\tHeight (in m)\t\tSpeed (downwards, in m/s)");
            for (int i = 0; i < mlh.numRounds; i++)
            {
               Console.WriteLine("{0}\t\t{1}\t\t{2}", i, mlh.GetHeight(i), mlh.GetSpeed(i));
            }
        }
    }
}
