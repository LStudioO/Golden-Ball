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
            var n = new Random().Next(3);

            switch (n)
            {
                case 0:
                    {
                        return Random;
                    }
                case 1:
                    {
                        return TwoOpt;
                    }
                case 2:
                    {
                        return ThreeOpt;
                    }
                default:
                    return Random;
            }
        }

        public static void Random(Player p)
        {
            try
            {
                for (int i = 0; i < 20; i++)
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
                        } else
                        {

                        }
                    } else
                    {

                    }
                }
                p.NotSuccess();
            } catch (Exception ex)
            {
                string s = ex.ToString();
            }
        }

        public static void TwoOpt(Player p)
        {
            for (int i = 1; i < p.Capacity - 2; i++)
            {
                for (int j = i + 1; j < p.Capacity - 1; j++)
                {
                    var newPlayer = new Player(p.Route);
                    newPlayer.SwapRoute(i, j);
                    if (newPlayer.Mark <= p.Mark)
                    {
                        if (!Manager.Instance.PlayerExists(newPlayer))
                        {
                            p.SwapRoute(i, j);
                            p.Success();
                            return;
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++) 
                p.NotSuccess();
        }   





        public static void ThreeOpt(Player p)
        {
            for (int i = 1; i < p.Capacity - 3; i++)
            {
                for (int j = i + 1; j < p.Capacity - 2; j++)
                {
                    for (int k = j + 1; k < p.Capacity - 1; k++)
                    {
                        var newPlayer = new Player(p.Route);
                        newPlayer.SwapRoute(i, j);
                        newPlayer.SwapRoute(j, k);

                        if (newPlayer.Mark <= p.Mark)
                        {
                            if (!Manager.Instance.PlayerExists(newPlayer))
                            {
                                p.SwapRoute(i, j);
                                p.Success();
                                return;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
                p.NotSuccess();
        }

        public static void Personal(Player captain, Player player)
        {
            double mark = player.Mark;

            int halfSize = (captain.Route.Count - 1) / 2 + 1;
            
            for (int m = 0; m < 2; m++)
            {

                List<int> halfRoute;

                if (m == 0)
                {
                   halfRoute = captain.Route.GetRange(1, halfSize);
                }
                else
                {
                    halfRoute = captain.Route.GetRange(halfSize - 1, halfSize);
                }
                    
                    
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
}
