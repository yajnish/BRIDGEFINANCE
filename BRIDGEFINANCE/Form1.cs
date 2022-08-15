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
    public partial class dashboard : Form
    {
        string account;
        public dashboard()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void dashboard_Load(object sender, EventArgs e)
        {
            decimal d = 0;
            account = "qip1";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                if (connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip1'") == null)
                {
                    balance.Text = "0.00";
                }
                else
                {
                    string stock2 = connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip1'").ToString();
                    d = decimal.Parse(stock2);
                    balance.Text = decimal.Round(d, 2).ToString();

                    
                }

            }
            string queryString = $"SELECT withdrawDate, description, amount, chequeNo FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}' ORDER BY withdrawDate ASC";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


            DataTable dt = new System.Data.DataTable();
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                chequewithddrawal.DataSource = dt;
                chequewithddrawal.AutoResizeColumns();
                chequewithddrawal.Columns[0].HeaderText = "WITHDRAW DATE";
                chequewithddrawal.Columns[1].HeaderText = "DESCRIPTION";
                chequewithddrawal.Columns[2].HeaderText = "AMOUNT";
                chequewithddrawal.Columns[3].HeaderText = "CHEQUE #";
                chequewithddrawal.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);

                DataGridViewColumn column = chequewithddrawal.Columns[0];
                column.Width = 200;
                column = chequewithddrawal.Columns[1];
                column.Width = 450;
                column = chequewithddrawal.Columns[2];
                column.Width = 200;
                column = chequewithddrawal.Columns[3];
                column.Width = 200;

            }
            double sumcheque = 0;
            for (int i = 0; i < chequewithddrawal.Rows.Count; ++i)
            {
                sumcheque += (double)Convert.ToInt32(chequewithddrawal.Rows[i].Cells[2].Value);
            }

            balAfter.Text = $"{double.Parse(balance.Text) - sumcheque}";

            DateTime datetimenow = DateTime.Now;
            int year = datetimenow.Year;
            int month = datetimenow.Month;
            int day = datetimenow.Day;

            

            DateTime date = new DateTime(year, month, day);
            double bal = (double)d;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'") == null)
                {

                }
                else
                {
                    string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'").ToString();
                    bal = bal - double.Parse(stock2);
                }
            }
            for (int i=0; i<50; i++)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                    {
                        if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= 'qip1' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'") == null)
                        {

                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= 'qip1' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'").ToString();
                            bal = bal - double.Parse(stock2);
                        }
                    }
                    forecast.Rows.Add(date, bal);
                    date = date.AddDays(1);
            }
                
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chequeIssue_Click(object sender, EventArgs e)
        {
            withdraw withrawal = new withdraw();
            withrawal.Show();
        }

        private void cashDep_Click(object sender, EventArgs e)
        {
            depo deposit = new depo();
            deposit.Show();
        }

        private void qip2_CheckedChanged(object sender, EventArgs e)
        {
            decimal d = 0;
            if (qip2.Checked == true)
            {
                qip1.Checked = false;
                qit1.Checked = false;
                qit2.Checked = false;
                account = "qip2";
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip2'") == null)
                    {
                        balance.Text = "0.00";
                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip2'").ToString();
                        d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();


                    }

                }
                string queryString = $"SELECT withdrawDate, description, amount, chequeNo FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}' ORDER BY withdrawDate ASC";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    chequewithddrawal.DataSource = dt;
                    chequewithddrawal.AutoResizeColumns();
                    chequewithddrawal.Columns[0].HeaderText = "WITHDRAW DATE";
                    chequewithddrawal.Columns[1].HeaderText = "DESCRIPTION";
                    chequewithddrawal.Columns[2].HeaderText = "AMOUNT";
                    chequewithddrawal.Columns[3].HeaderText = "CHEQUE #";
                    chequewithddrawal.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);

                    DataGridViewColumn column = chequewithddrawal.Columns[0];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[1];
                    column.Width = 450;
                    column = chequewithddrawal.Columns[2];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[3];
                    column.Width = 200;

                }
                double sumcheque = 0;
                for (int i = 0; i < chequewithddrawal.Rows.Count; ++i)
                {
                    sumcheque += (double)Convert.ToInt32(chequewithddrawal.Rows[i].Cells[2].Value);
                }

                balAfter.Text = $"{double.Parse(balance.Text) - sumcheque}";
                forecast.Rows.Clear();
                DateTime datetimenow = DateTime.Now;
                int year = datetimenow.Year;
                int month = datetimenow.Month;
                int day = datetimenow.Day;



                DateTime date = new DateTime(year, month, day);
                double bal = (double)d;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'") == null)
                    {

                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'").ToString();
                        bal = bal - double.Parse(stock2);
                    }
                }
                for (int i = 0; i < 50; i++)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                    {
                        if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'") == null)
                        {

                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'").ToString();
                            bal = bal - double.Parse(stock2);
                        }
                    }
                    forecast.Rows.Add(date, bal);
                    date = date.AddDays(1);
                }
            }
        }

        private void qit1_CheckedChanged(object sender, EventArgs e)
        {
            decimal d = 0;
            if (qit1.Checked == true)
            {
                qip2.Checked = false;
                qip1.Checked = false;
                qit2.Checked = false;
                account = "qit1";
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qit1'") == null)
                    {
                        balance.Text = "0.00";
                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qit1'").ToString();
                        d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();


                    }

                }
                string queryString = $"SELECT withdrawDate, description, amount, chequeNo FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}' ORDER BY withdrawDate ASC";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    chequewithddrawal.DataSource = dt;
                    chequewithddrawal.AutoResizeColumns();
                    chequewithddrawal.Columns[0].HeaderText = "WITHDRAW DATE";
                    chequewithddrawal.Columns[1].HeaderText = "DESCRIPTION";
                    chequewithddrawal.Columns[2].HeaderText = "AMOUNT";
                    chequewithddrawal.Columns[3].HeaderText = "CHEQUE #";
                    chequewithddrawal.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);

                    DataGridViewColumn column = chequewithddrawal.Columns[0];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[1];
                    column.Width = 450;
                    column = chequewithddrawal.Columns[2];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[3];
                    column.Width = 200;

                }
                double sumcheque = 0;
                for (int i = 0; i < chequewithddrawal.Rows.Count; ++i)
                {
                    sumcheque += (double)Convert.ToInt32(chequewithddrawal.Rows[i].Cells[2].Value);
                }

                balAfter.Text = $"{double.Parse(balance.Text) - sumcheque}";
                forecast.Rows.Clear();
                DateTime datetimenow = DateTime.Now;
                int year = datetimenow.Year;
                int month = datetimenow.Month;
                int day = datetimenow.Day;



                DateTime date = new DateTime(year, month, day);
                double bal = (double)d;

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'") == null)
                    {

                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'").ToString();
                        bal = bal - double.Parse(stock2);
                    }
                }
                for (int i = 0; i < 50; i++)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                    {
                        if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'") == null)
                        {

                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'").ToString();
                            bal = bal - double.Parse(stock2);
                        }
                    }
                    forecast.Rows.Add(date, bal);
                    date = date.AddDays(1);
                }
            }
        }

        private void qit2_CheckedChanged(object sender, EventArgs e)
        {
            decimal d = 0;
            if (qit2.Checked == true)
            {
                qip2.Checked = false;
                qit1.Checked = false;
                qip1.Checked = false;
                account = "qit2";
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qit2'") == null)
                    {
                        balance.Text = "0.00";
                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qit2'").ToString();
                        d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();


                    }

                }
                string queryString = $"SELECT withdrawDate, description, amount, chequeNo FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}' ORDER BY withdrawDate ASC";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    chequewithddrawal.DataSource = dt;
                    chequewithddrawal.AutoResizeColumns();
                    chequewithddrawal.Columns[0].HeaderText = "WITHDRAW DATE";
                    chequewithddrawal.Columns[1].HeaderText = "DESCRIPTION";
                    chequewithddrawal.Columns[2].HeaderText = "AMOUNT";
                    chequewithddrawal.Columns[3].HeaderText = "CHEQUE #";
                    chequewithddrawal.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);

                    DataGridViewColumn column = chequewithddrawal.Columns[0];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[1];
                    column.Width = 450;
                    column = chequewithddrawal.Columns[2];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[3];
                    column.Width = 200;

                }
                double sumcheque = 0;
                for (int i = 0; i < chequewithddrawal.Rows.Count; ++i)
                {
                    sumcheque += (double)Convert.ToInt32(chequewithddrawal.Rows[i].Cells[2].Value);
                }

                balAfter.Text = $"{double.Parse(balance.Text) - sumcheque}";
                forecast.Rows.Clear();
                DateTime datetimenow = DateTime.Now;
                int year = datetimenow.Year;
                int month = datetimenow.Month;
                int day = datetimenow.Day;



                DateTime date = new DateTime(year, month, day);
                double bal = (double)d;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'") == null)
                    {

                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'").ToString();
                        bal = bal - double.Parse(stock2);
                    }
                }
                for (int i = 0; i < 50; i++)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                    {
                        if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'") == null)
                        {

                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'").ToString();
                            bal = bal - double.Parse(stock2);
                        }
                    }
                    forecast.Rows.Add(date, bal);
                    date = date.AddDays(1);
                }
            }
        }

        private void qip1_CheckedChanged(object sender, EventArgs e)
        {
            decimal d=0;
            if (qip1.Checked == true)
            {
                qip2.Checked = false;
                qit1.Checked = false;
                qit2.Checked = false;
                account = "qip1";
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'") == null)
                    {
                        balance.Text = "0.00";
                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip1'").ToString();
                        d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();


                    }

                }
                string queryString = $"SELECT withdrawDate, description, amount, chequeNo FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}' ORDER BY withdrawDate ASC";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    chequewithddrawal.DataSource = dt;
                    chequewithddrawal.AutoResizeColumns();
                    chequewithddrawal.Columns[0].HeaderText = "WITHDRAW DATE";
                    chequewithddrawal.Columns[1].HeaderText = "DESCRIPTION";
                    chequewithddrawal.Columns[2].HeaderText = "AMOUNT";
                    chequewithddrawal.Columns[3].HeaderText = "CHEQUE #";
                    chequewithddrawal.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);

                    DataGridViewColumn column = chequewithddrawal.Columns[0];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[1];
                    column.Width = 450;
                    column = chequewithddrawal.Columns[2];
                    column.Width = 200;
                    column = chequewithddrawal.Columns[3];
                    column.Width = 200;

                }
                double sumcheque = 0;
                for (int i = 0; i < chequewithddrawal.Rows.Count; ++i)
                {
                    sumcheque += (double)Convert.ToInt32(chequewithddrawal.Rows[i].Cells[2].Value);
                }

                balAfter.Text = $"{double.Parse(balance.Text) - sumcheque}";
                forecast.Rows.Clear();
                DateTime datetimenow = DateTime.Now;
                int year = datetimenow.Year;
                int month = datetimenow.Month;
                int day = datetimenow.Day;



                DateTime date = new DateTime(year, month, day);
                double bal = (double)d;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'") == null)
                    {

                    }
                    else
                    {
                        string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate < '{date.Year}/{date.Month}/{date.Day}'").ToString();
                        bal = bal - double.Parse(stock2);
                    }
                }
                for (int i = 0; i < 50; i++)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                    {
                        if (connection.ExecuteScalar($"SELECT amount FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'") == null)
                        {

                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT SUM(amount) FROM cheque WHERE acc= '{account}' AND withdrawnornot = 0 AND withdrawDate = '{date.Year}/{date.Month}/{date.Day}'").ToString();
                            bal = bal - double.Parse(stock2);
                        }
                    }
                    forecast.Rows.Add(date, bal);
                    date = date.AddDays(1);
                }
            }
        }

        private void balTimer_Tick(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                if (connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'") == null)
                {
                    balance.Text = "0.00";
                }
                else
                {
                    string stock2 = connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'").ToString();
                    decimal d = decimal.Parse(stock2);
                    balance.Text = decimal.Round(d, 2).ToString();
                }

            }
        }

        private void chequewithddrawal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DailySales daily = new DailySales();
            daily.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchase purr = new purchase();
            purr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expense expenses = new expense();
            expenses.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }
    }
}
