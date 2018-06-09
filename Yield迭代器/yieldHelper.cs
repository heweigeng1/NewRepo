using System;
using System.Collections.Generic;
using System.Text;

namespace Yield迭代器
{
    public static class YieldHelper
    {
        public static IEnumerable<int> GetVs()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
