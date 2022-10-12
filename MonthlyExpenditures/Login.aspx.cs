using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
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
    public partial class Login : System.Web.UI.Page
    {
        // Declarations Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = DataUse; Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(DataFile);
         

            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM RegisterDetails WHERE Username='" + this.txtUsername + "' and Confirm='" + this.txtPassword + "' ");
                cmd.Parameters.AddWithValue("Confirm", HashPassword.Hash(txtPassword.Text));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Response.Write("<script> alert('Successful in login'); </script>");
                    Response.Redirect("Monthly.aspx");
                }
                else 
                {
                    Response.Write("<script> alert('Error in login '); </script>");
                } 

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
              
            }
            
                sqlCon.Close();

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}