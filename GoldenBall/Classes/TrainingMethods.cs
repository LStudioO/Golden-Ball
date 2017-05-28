using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldenBall.Classes
{
    class TrainingMethods
    {
        private static Random rand = new Random();

        public static Train GetRandomTrainingMethod()
        {
            var n = new Random().Next(2);

            switch (n)
            {
                case 0:
                    {
                        return Random;
                    }
                case 1:
                    {
                        return Chain;
                    }
                default:
                    return Random;
            }
        }

        public static void Random(Player p)
        {
            for (int i = 0; i < 4; i++)
            {
                var n1 = rand.Next(1, p.Capacity);
                var n2 = rand.Next(1, p.Capacity);

                while (n2 == n1)
                    n2 = rand.Next(1, p.Capacity);

                var prevMark = p.Mark;

                p.SwapRoute(n1, n2);

                if (p.Mark < prevMark)
                {
                    if (!Manager.Instance.PlayerExists(p))
                    {
                        p.Success();
                        return;
                    } else
                    {
                        p.NotSuccess();
                        p.SwapRoute(n1, n2);
                        i--;
                    }
                }
                else
                {
                    p.NotSuccess();
                    p.SwapRoute(n1, n2);
                }
            }
        }

        public static void Chain(Player p)
        {
            for (int i = 0; i < 4; i++)
            {
                var n1 = rand.Next(1, p.Capacity);
                var n2 = rand.Next(1, p.Capacity);

                while (n2 == n1)
                    n2 = rand.Next(1, p.Capacity);

                var newPlayer = new Player(p.Route);
                newPlayer.SwapRoute(n1, n2);
                

                if (newPlayer.Mark <= p.Mark)
                {
                    if (!Manager.Instance.PlayerExists(newPlayer))
                    {
                        p.SwapRoute(n1, n2);
                        p.Success();
                        return;
                    }
                    else
                    {
                        p.NotSuccess();
                       // i--;
                    }
                }
                else
                {
                    p.NotSuccess();
                }
            }
        }

        public static void Personal(Player captain, Player player)
        {
            double mark = player.Mark;

            int halfSize = (captain.Route.Count - 1) / 2 + 1;

            var halfRoute = captain.Route.GetRange(1, halfSize);

            for (int i = 1; i < captain.Route.Count - halfSize; i++)
            {
                var newRoute = new List<int>();

                newRoute.Add(player.Route[0]);

                var aPath = Enumerable.Range(1, player.Capacity).Except(newRoute).Except(halfRoute).ToList();

                // pre
                for (int k = 1; k < i; k++)
                {
                    var itm = aPath.First();
                    aPath.RemoveAt(0);
                    newRoute.Add(itm);
                }

                newRoute.AddRange(halfRoute);

                // after
                for (int l = i + halfSize; l < captain.Route.Count; l++)
                {
                    var itm = aPath.First();
                    aPath.RemoveAt(0);
                    newRoute.Add(itm);
                }

                if (!Manager.Instance.PlayerExists(newRoute))
                {
                    var oldRoute = player.Route;
                    player.Route = newRoute;
                    if (player.Mark <= mark)
                    {
                        player.Success();
                        return;
                    }
                    else
                    {
                        player.NotSuccess();
                        player.Route = oldRoute;
                    }
                }

            }
        }

    }
}
