using OCP.solving.ex;

namespace OCP.problem
{
    public class CalculationForTermAmount
    {
        public double Calculate(string term, double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Geçersiz Tutar Girişi");

            if (term == "shortTerm")
                amount = amount * 1.1;
            else if (term == "midTerm")
                amount = amount * 1.2;
            else if (term == "longTerm")
                amount = amount * 1.5;

            return amount;
        }
    }
}
