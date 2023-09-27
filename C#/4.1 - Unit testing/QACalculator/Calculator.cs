using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {
        public int Divide(string n1)
        {
            int result = -9999;
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
            string[] numbers = n1.Split(separator);
            foreach (string number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) / Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Multiply(string n1)
        {
            int result = -9999;
            string[] numbers = n1.Split(',');
            foreach (string number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) * Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Subtract(string n1)
        {
            int result = -9999;

            string[] numbers = n1.Split(',');
            foreach (string number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) - Utils.ToNumber(numbers[1]);
            return result;
        }
    }
}
