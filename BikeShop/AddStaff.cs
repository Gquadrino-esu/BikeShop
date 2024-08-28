using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BikeShop
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringBikeShop"].ConnectionString;

            string sqlQuery = "INSERT INTO Staff (StaffFName, StaffLName) Values ('" + AddStaffFNameTextBox.Text + "','" + AddStaffLNameTextBox.Text + "')";

            SqlConnection con = new(connectionString);

            con.Open();
            SqlCommand sc = new(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void AddStaffGoBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            OrderForm orderForm = new();
            orderForm.ShowDialog();
            Close();
        }
    }
}
