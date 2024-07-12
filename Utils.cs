using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Utils
    {
        public int randomNumberGenerator(int minVaulue, int maxValue)
        {
            Random random = new Random();
            int randomNumber = random.Next(minVaulue, maxValue);
            return randomNumber;
        }

        public void messageLines()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        public ICalcOperations getClassInterface(int i) 
        {
            List<ICalcOperations> calcOperationsInterface = new List<ICalcOperations>();
            calcOperationsInterface.Add(new AdditionOperation());
            calcOperationsInterface.Add(new SubstracionOperation());
            calcOperationsInterface.Add(new MultiplicationOperation());
            calcOperationsInterface.Add(new DivisionOperation());

            return calcOperationsInterface[i];
        }

        public double askUserInput()
        {
            Console.WriteLine("Please provide an answer:\n");
            double userInput = double.Parse(Console.ReadLine()); //fix this
            return userInput;
        }

        public void correctAnswerMsg(double userInput)
        {
            Console.WriteLine($"\nCongratulations {userInput} is the correct answer!\n");
            messageLines();
        }

        public void incorrectAnswerMsg(double userInput, double correctAnswer)
        {
            Console.WriteLine($"\nUnfortunately {userInput} is not the correct answer :(");
            Console.WriteLine($"The correct answer is {correctAnswer}");
            messageLines();
        }
    }
}
