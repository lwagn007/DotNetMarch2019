using System;

namespace _04_Calculator_Repository_Pattern
{
    internal class ProgramUI
    {
        CalculatorRepository _calcRepo = new CalculatorRepository();
        internal void Run()
        {
            Console.WriteLine("Hello and welcome to the most comprehensive calculator in the world. Two numbers no more. ");
            Console.ReadKey();
            Console.ReadLine();
            Console.Clear();

            bool isRunning = false;
            while (!isRunning)
            {

                Console.WriteLine("What would you like to do? Please enter a number.");
                Console.WriteLine("1. Add\n" +
                    "2. Subtract\n" +
                    "3. Multiply\n" +
                    "4. Divide\n" +
                    "5. Remainder\n" +
                    "6. Exit");

                string answer = Console.ReadLine();
                int answerAsInt = int.Parse(answer);

                switch (answerAsInt)
                {
                    case 1:
                        AddTwoNumbers();
                        break;
                    case 2:
                        SubtractTwoNumbers();
                        break;
                    case 3:
                        MultiplyTwoNumbers();
                        break;
                    case 4:
                        DivideTwoNumbers();
                        break;
                    case 5:
                        Console.WriteLine("case 5");
                        break;
                    case 6:
                        isRunning = false;
                        break;
                }
            }
        }

        public void DivideTwoNumbers()
        {
            Console.WriteLine("Please enter the first number you would like to divide...");
            string numberOne = Console.ReadLine();
            int numberOneAsInt = int.Parse(numberOne);

            Console.WriteLine("Please enter the second number you would like to divide...");
            string numberTwo = Console.ReadLine();
            int numberTwoAsInt = int.Parse(numberTwo);

            int result = _calcRepo.DivideTwoNumbers(numberOneAsInt, numberTwoAsInt);
            Console.WriteLine($"Here is your answer your Highness: {result}");
        }

        public void MultiplyTwoNumbers()
        {
            Console.WriteLine("Please enter the first number you would like to multiply...");
            string numberOne = Console.ReadLine();
            int numberOneAsInt = int.Parse(numberOne);

            Console.WriteLine("Please enter the second number you would like to multiply...");
            string numberTwo = Console.ReadLine();
            int numberTwoAsInt = int.Parse(numberTwo);

            int result = _calcRepo.MultiplyTwoNumbers(numberOneAsInt, numberTwoAsInt);
            Console.WriteLine($"Here is your answer your Highness: {result}");
        }

        public void SubtractTwoNumbers()
        {
            string numberOne;
            Console.WriteLine("Please enter the first number you would like to subtract...");
            numberOne = Console.ReadLine();
            int numberOneAsInt = int.Parse(numberOne);

            Console.WriteLine("Please enter the second number you would like to subtract...");
            string numberTwo = Console.ReadLine();
            int numberTwoAsInt = int.Parse(numberTwo);

            int result = _calcRepo.SubtractTwoNumbers(numberOneAsInt, numberTwoAsInt);
            Console.WriteLine($"Here is your answer your Highness: {result}");
        }

        public void AddTwoNumbers()
        {
            Console.WriteLine("Please enter the first number you would like to add...");
            string numberOne = Console.ReadLine();
            int numberOneAsInt = int.Parse(numberOne);

            Console.WriteLine("Please enter the second number you would like to add...");
            string numberTwo = Console.ReadLine();
            int numberTwoAsInt = int.Parse(numberTwo);

            int result = _calcRepo.AddTwoNumbers(numberOneAsInt, numberTwoAsInt);
            Console.WriteLine($"Here is your answer your Highness: {result}");
        }

    }
}

//if(answerAsInt == 1)
//{
//    Console.WriteLine("input 1");
//}
//else if(answerAsInt == 2)
//{
//    Console.WriteLine("input 2");
//}
//else if(answerAsInt == 3)
//{
//    Console.WriteLine("input 3");
//}
//else if(answerAsInt == 4)
//{
//    Console.WriteLine("input 4");
//}
//else if(answerAsInt == 5)
//{
//    Console.WriteLine("input 5");
//}