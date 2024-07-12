using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal interface ICalcOperations
    {
        public double mathOperation();
        public void showTaskToUser();
        public void userAnswerValidation(double correctAnswer, double userInput);
        public int getPoints();
    }
}
