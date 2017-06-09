using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoldenBall.Classes
{

    public class Player
    {
        List<int> route;

        public int Capacity { get; set; }

        private int unsuccessfulCount;

        private int prevFirst;

        private int prevSecond;

        private int hash = -1;

        public int GetHash()
        {
            if (hash == -1)
                hash = route.GetSequenceHashCode();

            return hash;
        }

        public Player(int capacity, int first)
        {
            Capacity = capacity;

            Route = new List<int>(capacity);

            Route.Add(first);

            System.Random rnd = new System.Random();

            var numbers = Enumerable.Range(1, capacity).OrderBy(r => rnd.Next()).ToArray();

            foreach (var itm in numbers)
            {
                if (itm != first)
                    Route.Add(itm);
            }

            DetermineMark();

            hash = route.GetSequenceHashCode();
        }

        public Player(List<int> route)
        {
            var list = new List<int>();
            list.AddRange(route);
            Route = list;
            hash = route.GetSequenceHashCode();
        }

        private double mark;

        public bool NeedPersonalTraining
        {
            get
            {
                return (unsuccessfulCount > 3);
            }
        }

        public bool NeedIndividualTransfer
        {
            get
            {
                return (unsuccessfulCount > 10);
            }
        }

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

        public List<int> Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
                DetermineMark();
                hash = route.GetSequenceHashCode();
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

            var tmp = Route[index1];
            Route[index1] = Route[index2];
            Route[index2] = tmp;
            DetermineMark();
            hash = route.GetSequenceHashCode();
        }

        public void DetermineMark()
        {
            mark = 0;

            if (route.Count < 2)
                return;

            for (int i = 0; i < Route.Count - 1; i++)
            {
                mark += Manager.Instance.GetDistanceBetween(Route[i], Route[i + 1]);
            }

            mark += Manager.Instance.GetDistanceBetween(Route.Last(), Route.First());
        }
    }
}
