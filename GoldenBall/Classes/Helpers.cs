﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBall.Classes
{
    static class Helpers
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list, int size)
        {
            var r = new Random();
            var shuffledList =
                list.
                    Select(x => new { Number = r.Next(), Item = x }).
                    OrderBy(x => x.Number).
                    Select(x => x.Item).
                    Take(size);

            return shuffledList.ToList();
        }
    }
}
