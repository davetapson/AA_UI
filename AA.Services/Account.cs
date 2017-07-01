using AA.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AA.Services
{
    public class Account
    {
        public Account(string accountNumber)
        {
            Guard.AgainstNullEmptyWhiteSpace("Account", accountNumber);

            AccountNumber = accountNumber;
        }
        public int Id { get; set; }
        [Required (ErrorMessage ="An Account Number is required")]
        public string AccountNumber { get; set; }
        public decimal AvailableEquity { get; set; }
        public decimal NetLiquidation { get; set; }
        public decimal TotalCashValue { get; set; }
        decimal SettledCash { get; set; }
        public decimal AccruedCash { get; set; }
        public decimal BuyingPower { get; set; }
        public decimal EquityWithLoanValue { get; set; }
        public decimal PreviousEquityWithLoanValue { get; set; }
        public decimal GrossPositonValue { get; set; }
        public List<Strategy> Strategies { get; set; }
    }
}
