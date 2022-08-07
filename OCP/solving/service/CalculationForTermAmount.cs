using OCP.solving.ex;

namespace OCP.solving.service
{
    public class CalculationForTermAmount
    {
        public double Calculate(TermAction term, double amount)
        {
            if (amount <= 0) throw new InvalidAmountException("Geçersiz Tutar Girişi");

            amount = term.act(amount);
            return amount;
        }
    }
}
