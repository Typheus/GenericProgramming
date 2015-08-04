using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class Operations
    {
        public static Dictionary<string, Func<double, double, double>> operationDictionary = new Dictionary<string,Func<double,double,double>>
            {
                {"+", Add},
                {"-", Subtract},
                {"*", Multiply},
                {"/", Divide},

            };

        public static string[] AvailableOperations()
        {
            return operationDictionary.Keys.ToArray();
        }
        private static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static double Subtract(double firstNumber, double secondNumber)
        {

            return firstNumber - secondNumber;
        }

        private static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private static double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
