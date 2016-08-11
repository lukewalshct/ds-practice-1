using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    public static class Problem3
    {
        public static int maxStep(int N, int K)
        {
            return addNextAction(N, K, 0, 1);    
        }

        private static int addNextAction(int totMoves, int badStep, int curStep, int moveCount)
        {
            if (moveCount == totMoves) return curStep;

            if(curStep + moveCount == badStep)
            {
                return curStep + addNextAction(totMoves, badStep, curStep, moveCount + 1);
            }
            else
            {
                return curStep + moveCount + addNextAction(totMoves, badStep, curStep, moveCount + 1);
            }
        }
    }
}
