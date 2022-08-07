using System;

namespace Tests
{

    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.ReadKey();
        }

        public void AddSample()
        {
            Calculator calculator = new Calculator(new AddCalculatorOperation());
            double result = calculator.Solve(1, 1);            
        }

        public void SubtractSample()
        {
            Calculator calculator = new Calculator(new SubtractCalculatorOperation());
            double result = calculator.Solve(1, 1);            
        }

        public void MultiplySample()
        {
            Calculator calculator = new Calculator(new MultiplyCalculatorOperation());
            double result = calculator.Solve(1, 2);            
        }

        public void DivideSample()
        {
            Calculator calculator = new Calculator(new DivideCalculatorOperation());
            double result = calculator.Solve(10, 5);            
        }
    }
}
