﻿using System.ComponentModel.DataAnnotations;

namespace FCLoanCalculator.Models
{
    public class Loan
    {
        public decimal Amount { get; set; }

        public decimal Rate { get; set; }
        public int Term { get; set; }
        public decimal Payment { get; set; }
        public decimal TotalInterst { get; set; }
        public decimal TotalCost { get; set; }

        public List<LoanPayment> Payments { get; set; } = new List<LoanPayment>();
    }
}
