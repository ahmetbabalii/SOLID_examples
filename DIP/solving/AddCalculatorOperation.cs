namespace DIP.solving
{
    public class AddCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
