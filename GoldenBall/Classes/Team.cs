using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldenBall.Classes
{
    public delegate void Train(Player p);

    class Team
    {

        Train trainingMethod;

        List<Player> playersList;

        private double mark;

        public double Mark
        {
            get
            {
                return mark;
            }
        }

        public Team()
        {
            playersList = new List<Player>();

            var n = new Random().Next(2);

            if (n == 0)
                trainingMethod = TrainingMethods.Random;
            else
                trainingMethod = TrainingMethods.Chain;
        }

        public void determineMark()
        {
            double sum = playersList.Sum(p => p.Mark);
            mark = sum / playersList.Count;
        }

        public Player getCaptain()
        {
            double min = playersList.Min(i => i.Mark);
            return playersList.First(x => x.Mark == min);
        }

        public static void Transfer(Player p1, Player p2)
        {
            Player temp = p1;
            p1 = p2;
            p2 = temp;
        }

        public void Train()
        {
            foreach (var itm in playersList)
                trainingMethod(itm);
        }
    }
}
