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
    public partial class Register : System.Web.UI.Page
    {
        // Declarations Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = DataUse; Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                lblErrorMessage.Text = "Please fill mandatory fiels ";
            else if (txtPassword.Text != txtRePassword.Text)
                lblErrorMessage.Text = "Please do not match";
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(DataFile))
                {
                    sqlCon.Open();
                    String query = "insert into RegisterDetails (Username,Password,Confirm) values('" + this.txtUsername.Text + "' , '" + this.txtPassword.Text + "' , '" + this.txtRePassword.Text + "' )";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    lblSuccesMessage.Text = "Submitted Successful";

                    Response.Write("<script> alert(You have register account now can login,WELCOME'); </script>");
                    Response.Redirect("Login.aspx");

                    sqlCon.Close();

                }

                
            }
        }
    }
}


    