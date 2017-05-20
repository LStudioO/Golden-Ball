using System;

namespace GoldenBall.Classes
{
    class TrainingMethods
    {

        public static void Random(Player p)
        {
            var rand = new Random();
            var n1 = rand.Next(1, p.Capacity);
            var n2 = rand.Next(1, p.Capacity);
    
            while (n2 == n1)
                n2 = rand.Next(1, p.Capacity);

            var prevMark = p.Mark;

            p.SwapRoute(n1, n2);
            p.DetermineMark();

            if (p.Mark < prevMark)
            {
                p.Success();
            }
            else
            {
                p.NotSuccess();
                p.SwapRoute(n1, n2);
            }
        }

        public static void Chain(Player p)
        {

        }

    }
}
