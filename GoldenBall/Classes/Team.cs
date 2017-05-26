using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldenBall.Classes
{
    public delegate void Train(Player p);

    class Team
    {
        private int id;
        private static int counter = 1;
        

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

        public List<Player> Players
        {
            get
            {
                return playersList;
            }

            set
            {
                playersList = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Player Captain
        {
            get
            {
                double min = playersList.Min(i => i.Mark);
                return playersList.First(x => x.Mark == min);
            }
        }

        public Team(List<Player> p)
        {
            id = counter++;

            playersList = p;

            var n = new Random().Next(2);

            if (n == 0)
                trainingMethod = TrainingMethods.Random;
            else
                trainingMethod = TrainingMethods.Chain;
        }

        public void DetermineMark()
        {
            double sum = playersList.Sum(p => p.Mark);
            mark = sum / playersList.Count;
        }

        public static void Transfer(Player p1, Player p2)
        {
            Player temp = p1;
            p1 = p2;
            p2 = temp;
        }

        public void Train()
        {
            playersList.ForEach(p => trainingMethod(p));
        }

        public void PersonalTrain()
        {
            playersList.ForEach(p =>
            {
                if (p.NeedPersonalTraining)
                {
                    TrainingMethods.Personal(Captain, p);
                }
            });
        }

        public void IndividualTransfer()
        {
            playersList.ForEach(p =>
            {
                if (p.NeedIndividualTransfer)
                {
                   // TODO
                }
            });
        }


    }
}
