using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustScored
{
    public class PlayerInfo
    {
        private float maxScore;
        private int gamesPlayed;
        private int gamesWon;

        public PlayerInfo(string name)
        {
            Name = name;
            maxScore = 0;
            gamesPlayed = 0;
            gamesWon = 0;
        }

        public float MaxScore
        {
            get
            {
                return maxScore;
            }
            set
            {
                if (value > maxScore)
                {
                    maxScore = value;
                }
            }
        }

        public string Name {get;}

        public float RateOfSuccess
        {
            get
            {
                return gamesPlayed == 0 ? 0:(float)gamesWon/gamesPlayed;
            }
        }
        public void AddGame(bool win)
        {
            gamesPlayed++;
            if (win)
            {
                gamesWon++;
            }
        }
    }
}