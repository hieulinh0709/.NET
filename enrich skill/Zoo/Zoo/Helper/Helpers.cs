using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Helper
{
    public static class Helpers
    {
        public static int RandomNum(int lowerBound = 0, int upperBound = 2)
        {
            var random = new Random();
            var rNum = random.Next(lowerBound, upperBound);
            return rNum;
        }
    }
}
