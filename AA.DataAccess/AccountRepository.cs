using AA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.DataAccess
{
    public class AccountRepository
    {
        public Account Get(string accountNumber)
        {
            if (accountNumber == "1")
            {
                Account account = new Account(accountNumber);
                StrategyRepository strategyRepository = new StrategyRepository();

                account.AccruedCash = 1.0m;
                account.AvailableEquity = 2.0m;
                account.BuyingPower = 3.0m;
                account.EquityWithLoanValue = 4.0m;
                account.GrossPositonValue = 5.0m;
                account.NetLiquidation = 6.0m;
                account.PreviousEquityWithLoanValue = 7.0m;
                account.TotalCashValue = 8.0m;

                account.Strategies = strategyRepository.Retrieve(account.Id);

                return account;
            }

            return null;
        }

        public List<Account> Retrieve()
        {
            throw new NotImplementedException();
        }

        public Account Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
