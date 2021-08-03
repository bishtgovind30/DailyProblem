using System;

namespace DailyProblem.Problems
{
    public class BaseConversion
    {
        public void GetBinaryValue(int number){
            GetBinary(number);
        }
    
        public void GetBinary(int number){
            if(number == 0)
                return;
            GetBinary(number/2);
            Console.Write(number%2 +" ");

        }
    }
}