using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    /// <summary>
    /// Problem3 is a static class containing the method that solves Problem3 of the 
    /// coding challenge.
    /// </summary>
    public static class Problem3
    {
        /// <summary>
        /// Calculates maximum number of steps Jack can jump.
        /// </summary>
        /// <param name="totMoves">Total number of moves.</param>
        /// <param name="badStep">Location of bad step.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Recursively calculates the position of the next step after applying the next action.
        /// </summary>
        /// <param name="totMoves">Total number of moves.</param>
        /// <param name="badStep">Location of bad step.</param>
        /// <param name="curStep">Current step position.</param>
        /// <param name="moveCount">Number of moves used so far.</param>
        /// <returns></returns>
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
