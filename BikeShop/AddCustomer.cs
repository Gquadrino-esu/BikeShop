using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShop
{
    public partial class AddCustomer : Form
    {
        string connectionString, sqlQuery;
        SqlConnection con;
        SqlCommand sc;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringBikeShop"].ConnectionString;

            sqlQuery = "INSERT INTO Customer (CustFName, CustLName, CustCCNum, CustCCPin) Values ('" 
                + AddCustFNameTextBox.Text + "','" + AddCustLNameTextBox.Text + "','" 
                + AddCustCCNumberTextBox.Text + "','" + AddCustCCPinTextBox.Text + "')";

            con = new SqlConnection(connectionString);

            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void AddCustomerGoBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            OrderForm orderForm = new();
            orderForm.ShowDialog();
            Close();
        }
    }
}
