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

        public Train TrainingMethod
        {
            get
            {
                return trainingMethod;
            }

            set
            {
                trainingMethod = value;
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




    }
}
