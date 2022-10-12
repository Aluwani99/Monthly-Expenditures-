using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonthlyExpenditures
{
    public partial class FutureValue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtAmountPerPeriod.Text);
            decimal yearsInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtNumberOfYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearsInterestRate / 12 / 100;

            decimal futureValue = this.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);

            txtFutureValue.Text = futureValue.ToString();
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)*(1 + monthlyInterestRate) ;
            }
            return futureValue;
        }

    }
}