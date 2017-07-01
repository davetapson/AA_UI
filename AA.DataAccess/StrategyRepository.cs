using System;
using System.Collections.Generic;
using AA.Services;

namespace AA.DataAccess
{
    internal class StrategyRepository
    {
        internal List<Strategy> Retrieve(int accountId)
        {
            List<Strategy> strategies = new List<Strategy>();
            OrderRepository orderRepository = new OrderRepository();

            Strategy strategy = new Strategy();
            strategy.Id = 1;
            strategy.AccountId = accountId;
            strategy.Name = "Weekly Momentum";
            strategy.Enabled = true;
            strategy.Orders = orderRepository.Retrieve(strategy.Id);
            strategies.Add(strategy);

            Strategy strategy1 = new Strategy();
            strategy.Id = 2;
            strategy.AccountId = accountId;
            strategy.Name = "Mean Reversion";
            strategy.Enabled = true;
            strategy.Orders = orderRepository.Retrieve(strategy.Id);
            strategies.Add(strategy1);

            Strategy strategy2 = new Strategy();
            strategy.Id = 3;
            strategy.AccountId = accountId;
            strategy.Name = "Rotational";
            strategy.Enabled = true;
            strategy.Orders = orderRepository.Retrieve(strategy.Id);
            strategies.Add(strategy2);

            return strategies;
        }
    }
}