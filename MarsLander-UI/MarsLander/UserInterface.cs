using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLander
{
    class UserInterface
    {
        public void buildGame()
        {
            buildBorder();
            Console.SetCursorPosition(45, 2);
            Console.Write("MARS LANDER GAME!!!!");

            for (int i = 0; i <= 10; i++)   //This prints out the height in meters or the graph
            {
                if (i == 0)
                    Console.SetCursorPosition(12, 5 + i);
                else if (i != 10)
                    Console.SetCursorPosition(13, 5 + i);
                else
                    Console.SetCursorPosition(15, 5 + i);
                Console.Write("{0}M: ", (1000 - (i * 100)));
            }
            Console.SetCursorPosition(29, 5);
            Console.Write("Exact height: ");
            Console.SetCursorPosition(28, 6);
            Console.Write("Current speed: ");
            Console.SetCursorPosition(30, 7);
            Console.Write("Fuel points: ");
        }
        public void buildBorder()
        {
            int height = 25;
            int width = 110;
            Console.ForegroundColor = ConsoleColor.White;
            for (int h = 1; h < height; h++)  // this prints out the Border of #
            {
                for (int w = 10; w < width; w++)
                {
                    if ((h == 1 || h == height - 1) || (w == 10 || w == width - 1))
                    {
                        Console.SetCursorPosition(w, h);
                        Console.Write("#");
                    }
                }
            }
        }
        public void printLocation(MarsLander ml)
        {
            int w = 18;
            resetLocation(w);
            Console.ForegroundColor = ConsoleColor.Red;
            if (ml.height > 1000)
                Console.SetCursorPosition(w, 5);
            else
                Console.SetCursorPosition(w, 15 - (ml.height / 100));
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void resetLocation(int w)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(w, 5 + i);
                Console.Write("  ");
            }
        }
        public void printLanderInfo(MarsLander ml)
        {
            Console.SetCursorPosition(43, 5);
            Console.Write("{0} meters       ", ml.height);
            Console.SetCursorPosition(43, 6);
            Console.Write("{0} m/s      ", ml.speed);
            Console.SetCursorPosition(43, 7);
            Console.Write("{0}      ", ml.fuelPoints);
        }
        public int GetFuelToBurn(MarsLander ml)
        {
            int input = -1;
            while (input < 0 || input > ml.fuelPoints)
            {
                Console.SetCursorPosition(60, 5);
                Console.Write("How many fuelpoints to burn?");
                resetInput();
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    resetOutput();
                    Console.Write("you need to type a valid intiger");
                    resetInput();
                }
                if (input < 0)
                {
                    resetOutput();
                    Console.Write("you cannot burn negative fuel");
                    continue;
                }
                if (input > ml.fuelPoints)
                {
                    resetOutput();
                    Console.Write("you dont have that much fuel!");
                    Console.SetCursorPosition(60, 7);
                    Console.Write("you have {0} fuel points", ml.fuelPoints);
                    continue;
                }
            }
            resetOutput();
            return input;
        }
        public void resetInput()
        {
            Console.SetCursorPosition(89, 5);
            Console.WriteLine("\t\t");
            Console.SetCursorPosition(89, 5);
        }
        public void resetOutput()
        {
            Console.SetCursorPosition(60, 6);
            Console.Write("\t\t\t\t\t");
            Console.SetCursorPosition(60, 7);
            Console.Write("\t\t\t\t\t");
            Console.SetCursorPosition(60, 6);
        }
        public void printEndOfGameResult(MarsLander ml, int maxspeed)
        {
            if (ml.speed > maxspeed)
            {
                Console.SetCursorPosition(40, 10);
                Console.Write("the maximum speed for a safe landing is {0}", maxspeed);
                Console.SetCursorPosition(40, 11);
                Console.Write("your lander's current speed is {0}", ml.speed);
                Console.SetCursorPosition(40, 12);
                Console.Write("you have crashed the lander into the surface of mars,");
                Console.SetCursorPosition(40, 13);
                Console.Write("killing everyone on board, costing nasa millions of dollars,");
                Console.SetCursorPosition(40, 14);
                Console.Write("and setting the space program back by decades!");
            }
            else
            {
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("congratulations!! you've successfully landed your mars lander,");
                Console.SetCursorPosition(40, 11);
                Console.Write("without crashing!!!");
            }
            Console.ReadLine();
            resetEverything();
            printHistory(ml.gethistory());
            Console.SetCursorPosition(0, 26);
        }
        public void printHistory(MarsLanderHistory mlh)
        {
            Console.WriteLine("\n\n\n\t\tHere's the height/speed info for you:");
            Console.WriteLine("\t\tRound #\t\tHeight (in m)\tSpeed (downwards, in m/s)");
            for (int i = 0; i < mlh.numRounds; i++)
            {
                Console.WriteLine("\t\t{0}\t\t{1}\t\t{2}", i, mlh.GetHeight(i), mlh.GetSpeed(i));
            }
            buildBorder();
        }
        public void resetEverything()
        {
            Console.SetCursorPosition(0, 0);
            for(int i = 0; i < 25; i++)
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.SetCursorPosition(0, 0);
        }
    }
}
