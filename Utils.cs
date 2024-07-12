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

            return calcOperationsInterface[i];
        }

        
    }
}
