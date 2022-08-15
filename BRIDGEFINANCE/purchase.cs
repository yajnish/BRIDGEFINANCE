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
using Dapper;

namespace BRIDGEFINANCE
{
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void invoiceamt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tax.Text = $"{Math.Round(((double.Parse(invoiceamt.Text)) / 1.15) * 0.15, 2)}";
            }
            catch (Exception)
            {

            }
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            fromD.Text = $"{DateTime.Now.ToString("dd")}";
            fromM.Text = $"{DateTime.Now.ToString("MM")}";
            fromY.Text = $"{DateTime.Now.ToString("yyyy")}";

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"SELECT supplier FROM purchase GROUP BY supplier";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();
            SqlDataReader adapt;
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                connection.Open();
                adapt = cmd.ExecuteReader();

                if (adapt.HasRows)
                {
                    while (adapt.Read())
                    {
                        string add = adapt.GetString(0);
                        // TODO: Change label to accept string input
                        collection.Add(add);
                    }

                }


                //SuggestStrings will have the logic to return array of strings either from cache/db

                this.supplier.AutoCompleteCustomSource = collection;
                connection.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    connection.Query($"INSERT INTO purchase VALUES('{fromY.Text}/{fromM.Text}/{fromD.Text}', '{supplier.Text}', '{invoiceno.Text}', '{invoiceamt.Text}', '{tax.Text}', '{comboBox1.Text}')");

                }
                MessageBox.Show("Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! NOT RECORDED IN DATABASE.");
            }
        }

        private void supplier_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
