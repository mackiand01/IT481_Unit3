using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace DatabaseProject
{
    public partial class Form2 : Form
    {

        string connectionString;
        public Form2()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["DatabaseProject.Properties.Settings.northwndConnectionString"].ConnectionString;
        }

        private void PopulateNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT ContactName FROM Customers", connection))
            using (SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT COUNT(*) AS CustomerNumber FROM Customers", connection))
            {
                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                custNames.DisplayMember = "ContactName";
                custNames.DataSource = nameTable;

                DataTable numTable = new DataTable();
                adapter1.Fill(numTable);

                custNums.DisplayMember = "CustomerNumber";
                custNums.DataSource = numTable;
            }
        }

        private void PopulateEmpNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName, LastName FROM Employees", connection))
            using (SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT COUNT(*) AS EmployeeNumber FROM Employees", connection))
            {
                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                empNames.DisplayMember = "FirstName";
                empNames.DataSource = nameTable;

                empLNames.DisplayMember = "LastName";
                empLNames.DataSource = nameTable;

                DataTable numTable = new DataTable();
                adapter1.Fill(numTable);

                empNums.DisplayMember = "EmployeeNumber";
                empNums.DataSource = numTable;
            }
        }

        private void PopulateOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT OrderID FROM Orders", connection))
            using (SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT COUNT(*) AS NumOfOrders FROM Orders", connection))
            {
                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                orders.DisplayMember = "OrderID";
                orders.DataSource = nameTable;

                DataTable numTable = new DataTable();
                adapter1.Fill(numTable);

                orderNums.DisplayMember = "NumOfOrders";
                orderNums.DataSource = numTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateNames();
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateEmpNames();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateOrders();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
