namespace OCP.solving.service
{
    public class LongTerm : TermAction
    {
        public double act(double amount)
        {
            return  amount * 1.5;
        }
    }
}
