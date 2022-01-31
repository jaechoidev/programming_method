/*
 * COMP 2211 Assignment 6 
 * Customer Search and Preferred Customer price estimation program
 * Author : Jae Choi
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailStoreApp
{
    public partial class RetailStore : Form
    {

        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataReader reader = null;

        // Dictionary for containing PreferredCustomer Objects which are generated while reading database.
        Dictionary<string, PreferredCustomer> CustomerDict = new Dictionary<string, PreferredCustomer>();

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jae\source\repos\RetailStoreApp\customer.mdf;Integrated Security = True";

        public RetailStore()
        {
            InitializeComponent();
            LoadCustomer();
            DisplayAllCustomer();
        }

        private void LoadCustomer()
        {
            // Load Customer List from Database and write them in the Dictionary.
            CustomerDict.Clear();
            ConnectionOpen();
            string sql = "SELECT * FROM CustomerTable";
            comm = new SqlCommand(sql, conn);
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                PreferredCustomer pc = new PreferredCustomer(Convert.ToString(reader["ID"]),
                                                              Convert.ToString(reader["Name"]),
                                                              Convert.ToString(reader["Address"]),
                                                              Convert.ToString(reader["Phone"]),
                                                              Convert.ToBoolean(reader["Mailing"]),
                                                              Convert.ToDouble(reader["AmountOfPurchase"]),
                                                              Convert.ToInt32(reader["Level"]));
                CustomerDict.Add(Convert.ToString(reader["ID"]), pc);   
            }
            ConnectionClose();
        }

        private void DisplayAllCustomer()
        {
            // Show all Customers in the Listbox.
            customerListbox.Items.Clear();
            CustomerDict.Keys.ToList().ForEach(k => customerListbox.Items.Add(CustomerDict[k].ID+"\t"+ CustomerDict[k].Name));
        }

        private void DisplayFilteredCustomer()
        {
            // filter customer list by search texts and category (ID, Name)
            customerListbox.Items.Clear();
            foreach(string k in CustomerDict.Keys.ToList())
            {
                if (searchbyCbox.Text == "ID" && CustomerDict[k].ID.Contains(searchText.Text))
                    customerListbox.Items.Add(CustomerDict[k].ID + "\t" + CustomerDict[k].Name);
                else if (searchbyCbox.Text == "Name" && CustomerDict[k].Name.Contains(searchText.Text))
                    customerListbox.Items.Add(CustomerDict[k].ID + "\t" + CustomerDict[k].Name);
            }
        }

        private void ConnectionOpen()
        {
            // Connect to sql
            if (conn == null)
            {
                conn = new SqlConnection(connString);
                conn.Open();
            }
        }
        
        private void ConnectionClose()
        {
            // disconnect sql
            reader.Close();
            conn.Close();
            conn = null;
        }

        private void CreateNewCustomer()
        {
            // add New Customer to the Database and load them to update the dictionary.
            ConnectionOpen();
            int mailValue = (mailingCheckbox.Checked) ? 1 : 0;
            string sql = string.Format("INSERT INTO CustomerTable(ID, Name, Address, Phone, Mailing, AmountOfPurchase, Level) VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6})", 
                                    idText.Text, nameText.Text, addressText.Text, phonenumText.Text, mailValue, Convert.ToDouble(amountText.Text), Convert.ToInt32(levelText.Text));

            comm = new SqlCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1) MessageBox.Show("New Customer is added successfully.");
            ConnectionClose();
            
            customerListbox.Items.Clear();
            LoadCustomer();
            DisplayAllCustomer();
        }

        private void DeleteSelectedCustomer()
        {
            // delete selected customer from the database and load them again to update dictionary.
            ConnectionOpen();
            string sql = string.Format("DELETE FROM CustomerTable WHERE ID={0}", customerListbox.SelectedItem.ToString().Split('\t')[0]);
            comm = new SqlCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1) MessageBox.Show("Selected Customer is deleted successfully.");
            ConnectionClose();

            LoadCustomer();
            DisplayAllCustomer();
        }

        private void UpdateSelectedCustomer()
        {
            // update selected customer by updated field's data. 
            ConnectionOpen();
            string sql = string.Format("UPDATE CustomerTable SET " +
                "Name='{0}',Address='{1}',Phone='{2}',Mailing={3},AmountOfPurchase={4},Level={5} WHERE ID={6}",
                (nameText.Text=="")?" ": nameText.Text, 
                (addressText.Text == "") ? " " : addressText.Text, 
                (phonenumText.Text == "") ? " " : phonenumText.Text,
                (mailingCheckbox.Checked == true) ? 1 : 0 ,
                Double.Parse(amountText.Text), 
                Int32.Parse(levelText.Text), 
                idText.Text);
            comm = new SqlCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1) 
                MessageBox.Show("Selected Customer is updated successfully.");
            ConnectionClose();

            LoadCustomer();
            DisplayAllCustomer();
        }
        private void searchbyCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFilteredCustomer();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            cleanInputAreas();
            DisplayFilteredCustomer();
        }

        private void customerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            string[] s = lb.SelectedItem.ToString().Split('\t');

            if (lb.SelectedItem == null)
            {
                cleanInputAreas();
                return;
            }
            idText.Text = CustomerDict[s[0]].ID;
            nameText.Text = CustomerDict[s[0]].Name;
            addressText.Text = CustomerDict[s[0]].Address;
            phonenumText.Text = CustomerDict[s[0]].Phone;
            mailingCheckbox.Checked = CustomerDict[s[0]].Mailing;
            amountText.Text = CustomerDict[s[0]].AmountOfPurchase.ToString();
            levelText.Text = CustomerDict[s[0]].Level.ToString();
            discText.Text = "";
        }

        private void cleanInputAreas()
        {
            idText.Text = "";
            nameText.Text = "";
            addressText.Text = "";
            phonenumText.Text = "";
            mailingCheckbox.Checked = false;
            amountText.Text = "";
            levelText.Text = "";
            discText.Text = "";
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            if (newBtn.Text.Equals("New"))
            {
                cleanInputAreas();
                customerListbox.Items.Clear();
                customerListbox.Enabled = false;
                searchbyCbox.Enabled = false;
                searchText.Enabled = false;
                newBtn.Text = "Register";
                modeLabel.Text = "mode : Registration";
                modeLabel.ForeColor = Color.Red;
                idText.Enabled = false;
                int newId = Int32.Parse(CustomerDict.Keys.ToList().Max()) + 1;
                idText.Text = newId.ToString("D8");
                amountText.Text = "0";
                levelText.Text = "0";
                amountText.Enabled = false;
                levelText.Enabled = false;
            }

            else if (newBtn.Text.Equals("Register") == true)
            {
                CreateNewCustomer();
                customerListbox.Enabled = true;
                searchbyCbox.Enabled = true;
                searchText.Enabled = true;
                newBtn.Text = "New";
                modeLabel.Text = "mode : Search";
                modeLabel.ForeColor = Color.Green;
                idText.Text = "";
                amountText.Text = "";
                levelText.Text = "";
                amountText.Enabled = true;
                levelText.Enabled = true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedCustomer();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedCustomer();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            searchText.Text = "";
            LoadCustomer();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RetailStore_Load(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (levelText.Text.Equals("0"))
            {
                discText.Text = purchaseText.Text;
            }
            else if (levelText.Text.Equals("1"))
            {
                discText.Text = (Double.Parse(purchaseText.Text) * 0.95).ToString();
            }
            else if (levelText.Text.Equals("2"))
            {
                discText.Text = (Double.Parse(purchaseText.Text) * 0.94).ToString();
            }
            else if (levelText.Text.Equals("3"))
            {
                discText.Text = (Double.Parse(purchaseText.Text) * 0.93).ToString();
            }
            else if (levelText.Text.Equals("4"))
            {
                discText.Text = (Double.Parse(purchaseText.Text) * 0.90).ToString();
            }
        }
    }
}
