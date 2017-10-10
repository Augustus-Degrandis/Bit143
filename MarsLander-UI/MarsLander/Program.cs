using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLander
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            MarsLander lander = new MarsLander();
            const int MAX_SPEED = 10; // 10 m/s
            ui.buildGame();

            while (lander.height > 0)
            {
                ui.printLanderInfo(lander);
                ui.printLocation(lander);
                int fuelToBurn = ui.GetFuelToBurn(lander);
                lander.CalculateNewSpeed(fuelToBurn);
            }
            ui.printLocation(lander);
            ui.printLanderInfo(lander);
            ui.printEndOfGameResult(lander, MAX_SPEED);
            
        }
    }
    
}
