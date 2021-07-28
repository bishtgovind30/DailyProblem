using System;

namespace DailyProblem.Problems
{
    public class Factorial
    {
        public int GetFatorialValue(int number){
            if(number ==0)
                return 1;
            return GetFatorialValue(number-1) * number;

        }
    }
}