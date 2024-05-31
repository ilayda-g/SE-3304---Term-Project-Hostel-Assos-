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
using System.Data.Sql;

namespace Hostel_Assos_Application_V._2
{
    public partial class FormIncomeAndExpenses : Form
    {
        public FormIncomeAndExpenses()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");

        private void FormIncomeAndExpenses_Load(object sender, EventArgs e)
        {
            // Total Money Amount in The Safe
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select sum(Fee) as Sum1 from AddCustomer ", connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                LblMoneyInSafe.Text = reader1["Sum1"].ToString();
            }
            connection.Close();

            // Expenses of Food
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select sum(Food) as Sum2 from Stock ", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                LblPurchasedFood.Text = reader2["Sum2"].ToString();
            }
            connection.Close();

            // Expenses of Drink
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select sum(Drink) as Sum3 from Stock ", connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                LblPurchasedDrink.Text = reader3["Sum3"].ToString();
            }
            connection.Close();

            // Expenses of Snacks
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select sum(Snacks) as Sum4 from Stock ", connection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                LblPurchasedSnack.Text = reader4["Sum4"].ToString();
            }
            connection.Close();

            // Electric Bill
            connection.Open();
            SqlCommand command5 = new SqlCommand("Select sum(Electric) as Sum5 from Bills ", connection);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                LblElectricBills.Text = reader5["Sum5"].ToString();
            }
            connection.Close();

            // Water Bill
            connection.Open();
            SqlCommand command6 = new SqlCommand("Select sum(Water) as Sum6 from Bills ", connection);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                LblWaterBills.Text = reader6["Sum6"].ToString();
            }
            connection.Close();

            // Internet Bill
            connection.Open();
            SqlCommand command7 = new SqlCommand("Select sum(Internet) as Sum7 from Bills ", connection);
            SqlDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                LblInternetBills.Text = reader7["Sum7"].ToString();
            }
            connection.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int staff = Convert.ToInt16(TxtStaffAmount.Text);
            LblStaffSalaries.Text = (20000 * staff).ToString();

            int result = Convert.ToInt32(LblMoneyInSafe.Text) - (Convert.ToInt32(LblStaffSalaries.Text) + Convert.ToInt32(LblPurchasedFood.Text) + Convert.ToInt32(LblPurchasedDrink.Text) + Convert.ToInt32(LblPurchasedSnack.Text) + Convert.ToInt32(LblElectricBills.Text) + Convert.ToInt32(LblWaterBills.Text) + Convert.ToInt32(LblInternetBills.Text));
            LblResult.Text = result.ToString();
        }

        private void LblStaffSalaries_Click(object sender, EventArgs e)
        {

        }
    }
}
