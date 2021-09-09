using System;
namespace DailyProblem.Problems
{
    public class TowerOfHanoi
    {
        public void Hanoi(int numberOfDisks, char source, char temp, char dest){
            if(numberOfDisks ==1)
                {
                    Console.WriteLine($"Moving Disk {numberOfDisks} From {source} --> {dest}");
                    return;
                }
            
            Hanoi(numberOfDisks-1, source, dest, temp);
            Console.WriteLine($"Moving Disk {numberOfDisks} From {source} --> {dest}");
            Hanoi(numberOfDisks-1, temp, source,dest);
        }
    }
}