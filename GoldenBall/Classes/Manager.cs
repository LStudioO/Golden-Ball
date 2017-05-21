using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBall.Classes
{
    public sealed class Manager
    {
        private static readonly Manager instance = new Manager();

        private double[,] dist;

        private int citiesCount;

        public void Load(string path = "test_example.txt")
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("File loading error");

            var file = File.ReadAllLines(path);

            citiesCount = file.Length;

            dist = new double[citiesCount, citiesCount];

            for (int i = 0; i < citiesCount; i++)
            {
                dist[i, i] = -1D;

                var split = file[i].Split(' ');

                for (int j = 0; j < split.Length; j++)
                {
                    if (i != j)
                        dist[i, j] = Convert.ToDouble(split[j]);
                }
            }
        }

        public bool isLoad()
        {
            return (dist != null);
        }

        public double getDistanceBetween(int first, int second)
        {
            if (!isLoad())
                throw new Exception("You should load distances first");

            if (first == second)
                throw new Exception("You should type different cities");

            if (first < 1 || second < 1 || first > dist.Length || second > dist.Length)
                throw new Exception("Invalid paramethers");

            return dist[first - 1, second - 1];
        }

        static Manager()
        {
        }

        private Manager()
        {
        }

        public static Manager Instance
        {
            get
            {
                return instance;
            }
        }

        public int CitiesCount
        {
            get
            {
                return citiesCount;
            }

            set
            {
                citiesCount = value;
            }
        }
    }
}
