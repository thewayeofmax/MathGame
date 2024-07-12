using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class SubstracionOperation : ICalcOperations
    {
        private double a;
        private double b;
        public int points;

        public SubstracionOperation()
        {
            points = 0;
        }

        Random random = new Random();
        Utils Utilities = new Utils();

        public double mathOperation()
        {
            return a - b;
        }

        public void showTaskToUser()
        {
            a = random.Next(0, 100);
            b = random.Next(0, 100);
            Console.WriteLine($"\nHow much is: {a} - {b}?");
        }

        public void userAnswerValidation(double correctAnswer, double userInput)
        {

            if (userInput == correctAnswer)
            {
                Utilities.correctAnswerMsg(userInput);
                points++;
            }
            else
            {
                Utilities.incorrectAnswerMsg(userInput, correctAnswer);
            }

        }
        public int getPoints()
        {
            return points;
        }
    }
}
