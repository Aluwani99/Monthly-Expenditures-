using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonthlyExpenditures
{
    public class Savings
    {
            // Declarations Varibles
            public double price;
            public double rate;
            public double numYears;

            // This are constructor varibles
            public Savings(double a, double z, double c)
            {
                this.price = a;
                this.rate = z;
                this.numYears = c;
            }

        // The method will calcuate the sum of Savings 
        public double Amount()
        {
            // Declarations Varibles
            double totalsum = 0;

            //calculation of the Savings payment
            totalsum = price * (1 + (rate / 100)) * numYears;
           

            return totalsum;
        }

    }
}