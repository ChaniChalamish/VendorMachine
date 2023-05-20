﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class VendorSelectionMethod : State
    {

        public override Product SelectProduct(string pro, Stock stock, bool bag, bool gift)
        {

            ProductType productType;
            Enum.TryParse(pro, out productType);

            return stock.GetProduct(productType);

        }
        public override decimal ProcessPayment(Product product, decimal paymentAmount, Stock stock)
        {
            Console.WriteLine("Payment is not allowed without selecting a product.");
            return 0;
        }

        public override Product ProcessProduct(Product product)
        {
           return null;
        }
    }
}