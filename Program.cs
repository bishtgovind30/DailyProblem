using System;
using DailyProblem.Problems;

namespace DailyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                p.ShowOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                p.ExecuteOperations(option);
            }
        }

        private void ShowOptions(){
            Console.WriteLine("=====Choose your problem=====");
            Console.WriteLine("Enter 1: Checking Validtity Of Expression Conatining Nested Parenthesis");
            Console.WriteLine("Enter 2: Get Factorial Of a Number Using Recurrsion");
            Console.WriteLine("Enter 3: Get Nth Power Of a Number Using Recurrsion");

        }

        private void ExecuteOperations(int option){
            switch (option)
            {
                case 1:
                ValidateExpression();
                break;
                case 2:
                GetFactorial();
                break;
                case 3:
                GetNthPowerValue();
                break;
                default:
                break;
            }
        }

        private void ValidateExpression(){
            ExpressionValidator validator = new ExpressionValidator();
            Console.Write("Enter parenthesis expression you want to validate: ");
            string expression = Console.ReadLine();
            bool isValid = validator.IsValidExpression(expression);
            var message = isValid? "Expression is Valid" : "Expression is Invalid";
            Console.WriteLine(message);
            Console.WriteLine("\n");
        }

        private void GetFactorial(){
            Factorial factorial = new Factorial();
            Console.Write("Enter Number To Find Factorial For: ");
            var number= Convert.ToInt32(Console.ReadLine());
            string message = "Factorial Value Is: "+ factorial.GetFatorialValue(number);
            Console.WriteLine(message);
            Console.WriteLine("\n");
        }
        private void GetNthPowerValue(){
            NthPower nthPower = new NthPower();
            Console.Write("Enter Number: ");
            var number= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Power: ");
            var power= Convert.ToInt32(Console.ReadLine());

            string message = "Value Is: "+ nthPower.GetNthPowerValue(number, power);
            Console.WriteLine(message);
            Console.WriteLine("\n");
        }
    }
}
