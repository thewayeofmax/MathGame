namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListOfOperations showList = new ListOfOperations();
            //showList.showOperations();

               Menu menu = new Menu();
               User user = new User();

            user.userLogin();
            menu.showOperations();
            menu.userChoiceAction();
        }
    }
}
