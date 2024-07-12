using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        private List<string> operationsList = new List<string>();
        private int choosenOperation;
        public Menu() 
        {
            operationsList.Add("Addition");
            operationsList.Add("Substraction");
            operationsList.Add("Multiplication");
            operationsList.Add("Division");
            operationsList.Add("View previous games");
            operationsList.Add("Quit the program");
        }

        Utils Utilities = new Utils();
        
        public void showOperations()
        {
            Utilities.messageLines();
            Console.WriteLine("Choose what operation you want to do:\n");
            for (int i = 1;  i <= operationsList.Count; i++)
                Console.WriteLine($"{i} --> {operationsList[i - 1]}\n");
            Utilities.messageLines();
        }

        public int getOperation()
        {
            Console.Write("Your choice: ");
            int userChoosed = Int32.Parse(Console.ReadLine());
            Utilities.messageLines();
            return userChoosed;
        }

        public bool inputValidation(int inputToCheck)
        {
            if (inputToCheck > 0 && inputToCheck < operationsList.Count())
                return true;
            return false;
        }

        public void userChoiceAction()
        {
            
            int userChoice = getOperation();
            if (inputValidation(userChoice) == true)
            {
                ICalcOperations doOperation = Utilities.getClassInterface(userChoice - 1);

                for (int i = 0; i < 9; i++)
                {
                    doOperation.showTaskToUser();
                    doOperation.userAnswerValidation();
                }
            }
        }
    }
}
