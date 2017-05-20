using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldenBall.Classes
{

    public class Player
    {
        List<int> route;

        public int Capacity { get; set; }

        private int unsuccessfulCount;

        private int prevFirst;

        private int prevSecond;

        public Player(int capacity, int first)
        {
            route = new List<int>(capacity);

            route.Add(first);

            var rand_collection = Enumerable.Range(1, capacity);

            rand_collection.Shuffle(rand_collection.Count());

            foreach (var itm in route)
            {
                if (itm != first)
                    route.Add(itm);
            }
        }

        private double mark;

        public double Mark
        {
            set
            {
                mark = value;
            }
            get
            {
                return mark;
            }
        }

        public int PrevSecond
        {
            get
            {
                return prevSecond;
            }

            set
            {
                prevSecond = value;
            }
        }

        public int PrevFirst
        {
            get
            {
                return prevFirst;
            }

            set
            {
                prevFirst = value;
            }
        }

        public void NotSuccess()
        {
            unsuccessfulCount++;
        }

        public void Success()
        {
            unsuccessfulCount = 0;
        }

        public void SwapRoute(int index1, int index2)
        {
            if (index1 == 0 || index2 == 0)
                return;

            var tmp = route[index1];
            route[index1] = route[index2];
            route[index2] = tmp;
        }

        public void DetermineMark()
        {
            mark = 0;
        }


        public void Practise(Random rand)
        {

        }
    }
}
