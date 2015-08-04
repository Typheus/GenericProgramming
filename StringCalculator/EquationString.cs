using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    class EquationString
    {
        List<string> parsedEquation;


        public EquationString()
        {
            parsedEquation = new List<string>();
        }

        public void ParseAndStoreEquation(string unparsedEquationString)
        {

            parsedEquation.AddRange(Regex.Split(RemoveSpaces(unparsedEquationString), BuildRegexString()));
        }

        private string RemoveSpaces(string stringWithSpaces)
        {
            return stringWithSpaces.Replace(" ", "");
        }

        private string BuildRegexString()
        {
            string regexLookBehind = "(?<=[";
            string regexLookAhead = "(?=[";
            foreach (string operation in Operations.AvailableOperations())
            {
                regexLookBehind +=operation;
                regexLookAhead += operation;
            }
            regexLookBehind +="])";
            regexLookAhead +="])";

            return regexLookBehind + "|" + regexLookAhead;
        }

        public string RetrieveCurrentEquationString()
        {
            return parsedEquation.ToString();
        }

        public bool SolveString()
        {
            bool anythingLeftToSolve = true;

            return anythingLeftToSolve;
        }
    }
}
