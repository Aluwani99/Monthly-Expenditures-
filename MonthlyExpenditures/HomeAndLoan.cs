using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/**
 * Author : Aluwani Mahlatse Rambau
 * Student Number : 19010010
 * Programming 2B Assessment
 * Contact no : 0676225015
 * Email : 19010010@rcconnect.co.za
 * 
**/

namespace MonthlyExpenditures
{
    class HomeAndLoan
    {
        // Declarations Varibles
        public double price;
        public double deposit;
        public double rate;
        public double rateMonth;

        // This are constructor varibles
        public HomeAndLoan(double a, double b, double z, double c)
        {
            this.price = a;
            this.deposit = b;
            this.rate = z;
            this.rateMonth = c;
        }

        // The method will calcuate the sum of home loan 
        public double AmountCalculate()
        {
            // Declarations Varibles
            double sum = 0;
            double totalsum = 0;

            //calculation of the home loan repayment
            totalsum = price * (1 + ((rate / 100) * (rateMonth)));
            sum = (totalsum / rateMonth);

            return sum;
        }

        

     }
}
