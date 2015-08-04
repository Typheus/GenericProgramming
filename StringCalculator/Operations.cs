using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Operations
    {
        Dictionary<string, Func<double, double, double>> operationDictionary;

        public Operations()
        {
            operationDictionary = new Dictionary<string,Func<double,double,double>>
            {
                {"+", Add},
                {"-", Subtract},
                {"*", Multiply},
                {"/", Divide},                
            };
        }

        private double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
