namespace DailyProblem.Problems
{
    public class NthPower
    {
        public int GetNthPowerValue(int number, int power){
            if(power ==0)
                return 1;
            
            return GetNthPowerValue(number, power-1) * number;
        }
    }
}