﻿using System;
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
            Route = new List<int>(capacity);

            Route.Add(first);

            System.Random rnd = new System.Random();

            var numbers = Enumerable.Range(1, capacity).OrderBy(r => rnd.Next()).ToArray();

            foreach (var itm in numbers)
            {
                if (itm != first)
                    Route.Add(itm);
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

        public List<int> Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
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
        }

        public void DetermineMark()
        {
            mark = 0;

            for (int i = 0; i < Route.Count - 1; i++)
            {
                mark += Manager.Instance.getDistanceBetween(Route[i], Route[i + 1]);
            }

            mark += Manager.Instance.getDistanceBetween(Route.Last(), Route.First());
        }


        public void Practise(Random rand)
        {

        }
    }
}
