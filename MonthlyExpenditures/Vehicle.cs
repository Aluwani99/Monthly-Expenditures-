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
    class Vehicle : Costs
    {
        // Declaration Varibles
        public double price;
        public double deposit;
        public double rate;
        public double insure;

        // This are constructor varibles
        public Vehicle(double a, double b, double d, double e)
        {
            this.price = a;
            this.deposit = b;
            this.rate = d;
            this.insure = e;
        }

        // This method will override the amountCalculate to get the monthly cost of the vehicle
        public override double AmountCalculate()
        {
            // Declaration Varibles
            double sum = 0;
            double sumCost = 0;

            // The code will calculating the sum of the months cost of the vehicle
            double sumTotal = (price * (1 + (rate * (5 / 12))));
            sumCost = sumTotal / 5;
            sum = insure + sumCost;

            return sum;
        }
    }
}