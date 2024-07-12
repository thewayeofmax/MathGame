using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        private List<string> operationsList = new List<string>();
        
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
        GamesHistory History = new GamesHistory();
        GameStatus Status = new GameStatus();
        
        public void showOperations()
        {
            Utilities.messageLines();
            Console.WriteLine("Choose what operation you want to do:\n");
            for (int i = 1;  i <= operationsList.Count; i++)
                Console.WriteLine($"{i} --> {operationsList[i - 1]}\n");
            Utilities.messageLines();
        }
        public string getOperation()
        {
            Console.Write("Your choice: ");
            string userChoosed = Console.ReadLine();
            Utilities.messageLines();
            return userChoosed;
        }
        public (bool, int) inputValidation(string inputToCheck)
        {
            Regex regexIsNumber17 = new Regex("^[1-6]+$");
            if (regexIsNumber17.IsMatch(inputToCheck))
            {
                return (true , Int32.Parse(inputToCheck));
            }
            else
            {
                Console.WriteLine("Wrong input! Please state number between 1-6.");
                return (false, -1);
            }
        }

        public void userChoiceAction((bool isValid, int userChoice) data)
        {
            Console.Clear();
            if (data.isValid == true)
            {
                if (data.userChoice == 5)
                {
                    History.getHistory();
                }
                else if (data.userChoice == 6)
                {
                    Status.stopGame();
                    Environment.Exit(0);
                }
                else if (data.userChoice >= 0 && data.userChoice < 7)
                {
                    Console.Clear();
                    DateTime date = DateTime.UtcNow;
                    ICalcOperations doOperation = Utilities.getClassInterface(data.userChoice - 1);

                    for (int i = 0; i < 2; i++)
                    {
                        doOperation.showTaskToUser();
                        doOperation.userAnswerValidation(doOperation.mathOperation(), Utilities.askUserInput());
                    }
                    History.addGame(doOperation.getPoints(), date);
                    Console.Clear();
                }
            }
            
        }
    }
}
