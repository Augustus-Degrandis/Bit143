using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsLander
{
    class MarsLander
    {
        public int speed { get; private set; }
        public int fuelPoints { get; private set; }
        public int height { get; private set; }
        public MarsLanderHistory mlh = new MarsLanderHistory();

        // you'll need to add data fields & methods so that the rest of the program
        // can use the various properties of the lander (such as height, speed, etc)

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
            height = h;
        }
        public void CalculateNewSpeed(int ftb)
        {
            fuelPoints = fuelPoints - ftb;
            speed = speed + 50 - ftb;
            height = height - speed;
            mlh.AddRound(height,speed);
        }
        public MarsLanderHistory getHistory()
        {
            return mlh;
        }
    }
}
