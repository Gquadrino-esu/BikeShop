using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShop
{
    public partial class AddBike : Form
    {
        readonly string connectionString, bikeBrand, bikeCat;
        string sqlQuery;
        SqlConnection con;
        SqlCommand sc;
        SqlDataReader dr;

        public AddBike()
        {
            InitializeComponent();

            // Gets data from database to BikeBrand drop down
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringBikeShop"].ConnectionString;
            sqlQuery = "select * from BikeBrand";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            bikeBrand = "";
            if (dr != null)
            {
                while (dr.Read())
                {
                    bikeBrand = dr["BikeBrandName"].ToString() ?? string.Empty;
                    AddBikeBrandComboBox.Items.Add(bikeBrand);
                }
            }
            con.Close();

            // Gets data from database to BikeCat drop down
            sqlQuery = "select * from BikeCategory";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    bikeCat = dr["BikeCatName"].ToString();
                    AddBikeCatComboBox.Items.Add(bikeCat);
                }
            }
            con.Close();
        }

        private void AddBikeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckForContent())
            {
                AddBikeButton.Enabled = true;
            }
            else
            {
                AddBikeButton.Enabled = false;
            }
        }

        private void AddBikeYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckForContent())
            {
                AddBikeButton.Enabled = true;
            }
            else
            {
                AddBikeButton.Enabled = false;
            }
        }

        private void AddBikePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckForContent())
            {
                AddBikeButton.Enabled = true;
            }
            else
            {
                AddBikeButton.Enabled = false;
            }
        }

        private void AddBikeBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckForContent())
            {
                AddBikeButton.Enabled = true;
            }
        }

        private void AddBikeCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckForContent())
            {
                AddBikeButton.Enabled = true;
            }
        }

        private void AddBikeButton_Click(object sender, EventArgs e)
        {
            // Enter info into BikeName database
            if (!AddBikeTextBox.Text.Equals("") && !AddBikeTextBox.Text.Equals("")
                && !AddBikeTextBox.Text.Equals("") && !AddBikeBrandComboBox.Text.Equals("") && !AddBikeCatComboBox.Text.Equals(""))
            {
                // Get BikeBrandID from BikeBrand database
                string bikeBrand = AddBikeBrandComboBox.Text;
                sqlQuery = "SELECT BikeBrandID FROM BikeBrand WHERE BikeBrandName='" + bikeBrand
                    + "'";
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                int bikeBrandID = 0;
                if (dr != null)
                {
                    dr.Read();
                    bikeBrandID = int.Parse(dr["BikeBrandID"].ToString());
                }
                con.Close();

                // Get BikeCatID from BikeCat database
                string bikeCat = AddBikeCatComboBox.Text;
                sqlQuery = "SELECT BikeCatID FROM BikeCategory WHERE BikeCatName='" + bikeCat
                    + "'";
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                int bikeCatID = 0;
                if (dr != null)
                {
                    dr.Read();
                    bikeCatID = int.Parse(dr["BikeCatID"].ToString());
                }
                con.Close();

                // Insert BikeName, BikeYear, BikePrice, BikeBrandID, BikeCatID
                string bikeName = AddBikeTextBox.Text, bikeYear = AddBikeYearTextBox.Text;
                float bikePrice = float.Parse(AddBikePriceTextBox.Text);
                sqlQuery = "INSERT INTO BikeName (BikeName, BikeYear, BikePrice, BikeBrandID, BikeCatID) VALUES ('"
                    + bikeName + "','" + bikeYear + "',"
                    + bikePrice + "," + bikeBrandID + "," 
                    + bikeCatID + ")";
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                sc.ExecuteNonQuery();
                con.Close();

                AddBikeTextBox.Clear();
                AddBikeYearTextBox.Clear();
                AddBikePriceTextBox.Clear();
                AddBikeBrandComboBox.SelectedIndex = -1;
                AddBikeCatComboBox.SelectedIndex = -1;
            }
        }

        private void AddBikeGoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new();
            inventory.ShowDialog();
            this.Close();
        }

        public bool CheckForContent()
        {
            if (AddBikeBrandComboBox.SelectedIndex != -1
                && AddBikeCatComboBox.SelectedIndex != -1
                && !AddBikeTextBox.Text.Trim().Equals("")
                && !AddBikeYearTextBox.Text.Trim().Equals("")
                && !AddBikePriceTextBox.Text.Trim().Equals(""))
            {
                return true;
            }

            return false;
        }
    }
}
