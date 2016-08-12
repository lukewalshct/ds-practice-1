using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    public static class Problem3
    {
        public static int maxStep(int totMoves, int badStep)
        {
            if(!(totMoves >=1 && totMoves <= 2000))
            {
                throw new ArgumentOutOfRangeException("Total moves must be between 1 and 2,000.");
            }
            if(!(badStep >= 1 && badStep <= 4000000))
            {
                throw new ArgumentOutOfRangeException("Bad step number must be between 1 and 4,000,000");
            }           

            return addNextAction(totMoves, badStep, 0, 1);    
        }

        private static int addNextAction(int totMoves, int badStep, int curStep, int moveCount)
        {
            if (moveCount > totMoves) return curStep;

            if (curStep + moveCount == badStep)
            {
                curStep += moveCount;
                return addNextAction(totMoves, badStep, curStep, moveCount + 1)-1;                
            }
            else
            {
                curStep += moveCount;
                return addNextAction(totMoves, badStep, curStep, moveCount + 1);                
            }
        }
    }
}
