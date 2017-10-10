using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLander
{
    class MarsLanderHistory
    {
        RoundInfo[] rounds = new RoundInfo[10];
        public int numRounds { get; private set; }

        
        public void AddRound(int height, int speed)
        {
            if (numRounds == rounds.Length)
            {
                RoundInfo[] copy = new RoundInfo[numRounds + 5];
                for (int i = 0; i < numRounds; i++)
                    copy[i] = this.rounds[i];
                rounds = copy;
            }
            rounds[numRounds] = new RoundInfo(height, speed);
            numRounds++;
        }
        public int GetSpeed(int i)
        {
            return rounds[i].GetSpeed();
        }
        public int GetHeight(int i)
        {
            return rounds[i].GetHeight();
        }

    }

    // This is provided to you; you shouldn't need to add anything to it, but
    // if you want to you are welcome to do so
    class RoundInfo
    {
        private int height;
        private int speed;

        #region Accessors
        public int GetHeight()
        {
            return height;
        }
        public void SetHeight(int newValue)
        {
            height = newValue;
        }

        public int GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(int newValue)
        {
            speed = newValue;
        }
        #endregion Accessors

        public RoundInfo(int h, int s)
        {
            height = h;
            speed = s;
        }
    }
}
