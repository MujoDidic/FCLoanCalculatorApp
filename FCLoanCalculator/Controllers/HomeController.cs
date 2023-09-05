using FCLoanCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using FCLoanCalculator.Helpers;

namespace FCLoanCalculator.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult App()
        {
            Loan loan = new()
            {
                Payment = 0.0m,
                TotalInterest = 0.0m,
                TotalCost = 0.0m,
                Rate = 3.5m,
                Amount = 15000m,
                Term = 60
            };

            return View(loan);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult App(Loan loan)
        {
            //Calculate loan
            var loanHelper = new LoanHelper();

            Loan newLoan = loanHelper.GetPayments(loan);
            
            
            return View(newLoan);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}