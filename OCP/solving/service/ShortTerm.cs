namespace OCP.solving.service
{
    public class ShortTerm : TermAction
    {
        public double act(double amount)
        {
            return amount * 1.1;
        }
    }
}
