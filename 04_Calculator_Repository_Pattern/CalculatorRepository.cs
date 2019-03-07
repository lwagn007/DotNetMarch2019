using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator_Repository_Pattern
{
    public class CalculatorRepository
    {
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }

        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberTwo - numberOne;
            return result;
        }

        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int sphapgettiSauce = numberOne * numberTwo;
            return sphapgettiSauce;
        }

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberTwo / numberOne;
            return result;
        }

        public int RemainderOfTwoNumbers(int numberOne, int numberTwo)
        {
            int remainder = numberOne % numberTwo;
            return remainder;
        }
    }
}
