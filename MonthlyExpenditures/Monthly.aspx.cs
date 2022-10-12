using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
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
    public partial class Monthly : System.Web.UI.Page
    {
        // Declarations Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = DataUse; Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         // Declaration Varibles
        int income = 0, tax = 0, renting = 0;
        double total = 0;

        //collection for home loan variables
        List<HomeAndLoan> Home = new List<HomeAndLoan>();


        // creating array that will put expense
        List<int> expenses = new List<int>();

        //collection for vehiicle variables
        List<Savings> Savings = new List<Savings>();

        //collection for vehiicle variables
        List<Vehicle> car = new List<Vehicle>();

        public void store()
        {
            //This getting values from user 
            income = Convert.ToInt32(txtGross.Text);
            tax = Convert.ToInt32(txtMonthly.Text);

            //This array it will be carry expense from the user
            expenses.Add(Convert.ToInt32(txtGroceries.Text));
            expenses.Add(Convert.ToInt32(txtWater.Text));
            expenses.Add(Convert.ToInt32(txtPhone.Text));
            expenses.Add(Convert.ToInt32(txtTravel.Text));
            expenses.Add(Convert.ToInt32(txtExpense.Text));

            //This will help in calculating the total of expenses
            total = expenses.Sum();
            //This will help in calculating the total of expenses
            total = expenses.Sum();
        }

        //Calculating the sum of price of the vehicle
        public void vehicle()
        {
            // Declarations Varibles
            double Accept = 0;

            // Addiing values
            car.Add(new Vehicle(Convert.ToDouble(txtPriceCar.Text), Convert.ToDouble(txtCarDeposit.Text), Convert.ToDouble(txtRateCar.Text), Convert.ToDouble(CarInsure.Text)));

            // A loop for vehicle price
            foreach (Vehicle x in car)
            {
                Accept = x.AmountCalculate();
            }
            // To recevice the sum of amount
            txtCarCalculate.Text = Convert.ToString(Accept);
        }

        public void LoanPrice()
        {
            // Declarations Varibles
            double Accept = 0;

            // Addiing values
            Home.Add(new HomeAndLoan(Convert.ToDouble(txtPriceHome1.Text), Convert.ToDouble(DepositHome.Text), Convert.ToDouble(RateHome.Text), Convert.ToDouble(txtMonthly.Text)));

            // A loop for home loan
            foreach (HomeAndLoan h in Home)
            {
                Accept = h.AmountCalculate();
            }

            //calculation for the third
            //object to call the income captured in the first form

            
            double third_gross = income * (1 / 3);

            if (Accept >= third_gross)
            {
                Response.Write("<script> alert('You application for home loan has not been approved, Thank you have nice day'); </script>");

            }
            txtHomeLoa.Text = Convert.ToString(Accept);

        }
            //  Response.Redirect("Login.aspx");
            protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void BtnHomeLoan_Click(object sender, EventArgs e)
        {
            LoanPrice();

            //This will store data to the database
            SqlConnection sqlCon = new SqlConnection(DataFile);
            try
            {
                sqlCon.Open();
                String query = "insert into Property (Price,InterestRate,Deposit,HomeAmount) values('"
                + this.txtPriceHome1.Text + "' , '" + this.RateHome.Text + "' , '" + this.DepositHome.Text + "', '"
                + this.CarInsure.Text +  "', '" + this.txtHomeLoa.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();

                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        protected void BtnCalucate_Click(object sender, EventArgs e)
        {
            vehicle();
            //This will store data to the database
            SqlConnection sqlCon = new SqlConnection(DataFile);
            try
            {
                sqlCon.Open();
                String query = "insert into Car (Mode,Price,InterestRate,Deposit,Insurance,CarAmount) values('"
                + this.txtModel.Text + "' , '" + this.txtPriceCar.Text + "' , '" + this.txtRateCar.Text + "' , '" + this.txtCarDeposit.Text + "', '"
                + this.CarInsure.Text + "', '" + this.txtCarCalculate.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();

                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        protected void BtnRenting_Click(object sender, EventArgs e)
        {
            renting = Convert.ToInt32(txtRenting.Text);
                
            //This will store data to the database
            SqlConnection sqlCon = new SqlConnection(DataFile);
            try
            {
                sqlCon.Open();
                String query = "insert into Renting (Price) values('" + this.txtRenting.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();

                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            finally
            {
                sqlCon.Close();
            }


        }

        protected void btnExpense_Click(object sender, EventArgs e)
        {
            //This will store data to the database
            SqlConnection sqlCon = new SqlConnection(DataFile);
            try
            {
                sqlCon.Open();
                String query = "insert into GrossMonthly (Gross,Monthly,Groceries,Water,Travel,CellPhone,Expense) values('"
                + this.txtGross.Text + "' , '" + this.txtMonthly.Text + "' , '" + this.txtGroceries.Text + "', '"
                + this.txtWater.Text + "' , '" + this.txtTravel.Text + "', '" + this.txtPhone.Text + "', '"
                + this.txtExpense.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();

                Response.Write("<script> alert('Data Is Stored'); </script>");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Data Is Not Stored'); </script>");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        protected void btnViewGraph_Click(object sender, EventArgs e)
        {

        }

        protected void btnSaving_Click(object sender, EventArgs e)
        {
            Response.Redirect("FutureValue.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            //This will reset
            txtCarCalculate.Text = string.Empty;
            DepositHome.Text = string.Empty;
            txtRateCar.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtPriceCar.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtCarDeposit.Text = string.Empty;
            txtGroceries.Text = string.Empty;
            txtGross.Text = string.Empty;
            CarInsure.Text = string.Empty;
            RateHome.Text = string.Empty;
            txtMonthly.Text = string.Empty;
            txtWater.Text = string.Empty;
            txtTravel.Text = string.Empty;
            txtRenting.Text = string.Empty;
            txtPriceHome1.Text = string.Empty;
            txtExpense.Text = string.Empty;
            txtHomeLoa.Text = string.Empty;

        }
        
        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}