using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class AdditionOperation : ICalcOperations
    {

        private double a;
        private double b;

        Random random = new Random();
        Utils Utilities = new Utils();

        public double mathOperation()
        {
            return a + b;
        }

        public void showTaskToUser()
        {
            a = random.Next(0, 100);
            b = random.Next(0, 100);
            Console.WriteLine($"\nHow much is: {a} + {b}?");
        }

        public void userAnswerValidation()
        {
            double correctAnswer = mathOperation();
            Console.WriteLine("Please provide an answer:\n");
            double userInput = double.Parse(Console.ReadLine());

            if (userInput == correctAnswer)
            {
                Console.WriteLine($"\nCongratulations {userInput} is the correct answer!\n");
                Utilities.messageLines();
            }
            else
            {
                Console.WriteLine($"\nUnfortunately {userInput} is not the correct answer :(");
                Console.WriteLine($"The correct answer is {correctAnswer}");
                Utilities.messageLines();
            }
            
        }
    }
}
