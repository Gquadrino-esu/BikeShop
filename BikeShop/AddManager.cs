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
using System.Security.Cryptography.X509Certificates;

namespace BikeShop
{
    public partial class AddManager : Form
    {
        readonly string connectionString, staffName;
        string sqlQuery, storeName;
        readonly SqlConnection con;
        SqlCommand sc;
        SqlDataReader dr;
        string[] manName = new string[2];
        int storeID, staffID;

        public AddManager()
        {
            InitializeComponent();

            // Gets data from database to Store drop down
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringBikeShop"].ConnectionString;
            sqlQuery = "select * from Store";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    storeName = dr["StoreName"].ToString();
                    AddManStoreComboBox.Items.Add(storeName);
                }
            }
            con.Close();

            // Gets data from database to Staff drop down
            sqlQuery = "select * from Staff";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    staffName = dr["StaffFName"].ToString();
                    staffName += " ";
                    staffName += dr["StaffLName"].ToString();
                    AddManNameComboBox.Items.Add(staffName);
                }
            }

            con.Close();
        }

        private void AddManGoBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            OrderForm orderForm = new();
            orderForm.ShowDialog();
            Close();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            storeName = AddManStoreComboBox.Text;
            sqlQuery = "SELECT StoreID FROM Store WHERE StoreName='" + storeName + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                storeID = int.Parse(dr["StoreID"].ToString());
            }
            con.Close();

            manName = AddManNameComboBox.Text.Split(' ');
            sqlQuery = "SELECT StaffID FROM Staff WHERE StaffFName='" + manName[0] + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                staffID = int.Parse(dr["StaffID"].ToString());
            }
            con.Close();
            
            sqlQuery = "UPDATE Store SET ManagerID = " + staffID 
                + " WHERE STOREID = " + storeID;
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
