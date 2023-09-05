using System.ComponentModel.DataAnnotations;

namespace FCLoanCalculator.Models
{
    public class Loan
    {
        //Properties from user input
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public int Term { get; set; }

        //Properties to calculate
        public decimal Payment { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal TotalCost { get; set; }

        public List<LoanPayment> Payments { get; set; } = new List<LoanPayment>();
    }
}
