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
    }
}
