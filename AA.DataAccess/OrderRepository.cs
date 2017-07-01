using System;
using System.Collections.Generic;
using AA.Services;

namespace AA.DataAccess
{
    internal class OrderRepository
    {
        internal List<Order> Retrieve(int strategyId)
        {
            List<Order> orders = new List<Order>();

            switch (strategyId)
            {
                case 1:

                    Order order = new Order();
                    order.Id = 1;
                    order.OrderType = "MKT";
                    order.Quantity = 100;
                    order.SecurityName = "BOB";
                    order.SecurityType = "STK";
                    order.StrategyId = strategyId;
                    orders.Add(order);

                    Order order1 = new Order();
                    order1.Id = 2;
                    order1.OrderType = "MKT";
                    order1.Quantity = 200;
                    order1.SecurityName = "BOB2";
                    order1.SecurityType = "STK";
                    order1.StrategyId = strategyId;
                    orders.Add(order1);

                    Order order2 = new Order();
                    order2.Id = 3;
                    order2.OrderType = "MKT";
                    order2.Quantity = 300;
                    order2.SecurityName = "BOB3";
                    order2.SecurityType = "STK";
                    order2.StrategyId = strategyId;
                    orders.Add(order2);
                    break;

                case 2:

                    Order order3 = new Order();
                    order3.Id = 4;
                    order3.OrderType = "MKT";
                    order3.Quantity = 400;
                    order3.SecurityName = "JIM";
                    order3.SecurityType = "STK";
                    order3.StrategyId = strategyId;
                    orders.Add(order3);

                    Order order4 = new Order();
                    order4.Id = 5;
                    order4.OrderType = "MKT";
                    order4.Quantity = 500;
                    order4.SecurityName = "JIM2";
                    order4.SecurityType = "STK";
                    order4.StrategyId = strategyId;
                    orders.Add(order4);

                    Order order5 = new Order();
                    order5.Id = 4;
                    order5.OrderType = "MKT";
                    order5.Quantity = 600;
                    order5.SecurityName = "JIM3";
                    order5.SecurityType = "STK";
                    order5.StrategyId = strategyId;
                    orders.Add(order5);
                    break;

                case 3:

                    Order order6 = new Order();
                    order6.Id = 5;
                    order6.OrderType = "MKT";
                    order6.Quantity = 700;
                    order6.SecurityName = "JOE";
                    order6.SecurityType = "STK";
                    order6.StrategyId = strategyId;
                    orders.Add(order6);

                    Order order7 = new Order();
                    order7.Id = 6;
                    order7.OrderType = "MKT";
                    order7.Quantity = 800;
                    order7.SecurityName = "JOE2";
                    order7.SecurityType = "STK";
                    order7.StrategyId = strategyId;
                    orders.Add(order7);

                    Order order8 = new Order();
                    order8.Id = 7;
                    order8.OrderType = "MKT";
                    order8.Quantity = 900;
                    order8.SecurityName = "JOE3";
                    order8.SecurityType = "STK";
                    order8.StrategyId = strategyId;
                    orders.Add(order8);
                    break;

                default:
                    break;
            }

            return orders;
        }
    }
}