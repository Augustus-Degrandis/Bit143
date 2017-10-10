using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLander
{
    class MarsLander
    {
        public int speed { get; private set; }
        public int fuelPoints { get; private set; }
        public int height { get; private set; }
        public MarsLanderHistory mlh = new MarsLanderHistory();



        public MarsLander()
        {
            speed = 100;
            fuelPoints = 500;
            height = 1000;
        }
        public void setSpeed(int s)
        {
            speed = s;
        }
        public void setFuelPoints(int f)
        {
            fuelPoints = f;
        }
        public void setHeight(int h)
        {
            if (h < 0)
                height = 0;
            else 
                height = h;
        }
        public void CalculateNewSpeed(int ftb)
        {
            fuelPoints = fuelPoints - ftb;
            setSpeed(speed + 50 - ftb);
            setHeight(height - speed);
            mlh.AddRound(height, speed);
        }
        public MarsLanderHistory gethistory()
        {
            return mlh;
        }
    }
}