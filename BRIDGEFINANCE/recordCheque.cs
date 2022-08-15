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
    public partial class recordCheque : Form
    {
        public recordCheque()
        {
            InitializeComponent();
        }
        string account;
        private void recordCheque_Load(object sender, EventArgs e)
        {
            account = "qip1";
            fromD.Text = $"{DateTime.Now.ToString("dd")}";
            fromM.Text = $"{DateTime.Now.ToString("MM")}";
            fromY.Text = $"{DateTime.Now.ToString("yyyy")}";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                if (connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip1'") == null)
                {
                    balance.Text = "0.00";
                }
                else
                {
                    string stock2 = connection.ExecuteScalar("SELECT balance FROM Balance WHERE acc= 'qip1'").ToString();
                    decimal d = decimal.Parse(stock2);
                    balance.Text = decimal.Round(d, 2).ToString();
                    account = "qip1";

                }

            }
            string queryString = $"SELECT chequeNo, description, amount, withdrawDate FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}' ORDER BY withdrawDate ASC";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


            DataTable dt = new System.Data.DataTable();
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Columns[0].HeaderText = "CHEQUE #:";
                dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
                dataGridView1.Columns[2].HeaderText = "AMOUNT";
                dataGridView1.Columns[3].HeaderText = "WITHDRAW DATE";
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 200;
                column = dataGridView1.Columns[1];
                column.Width = 450;
                column = dataGridView1.Columns[2];
                column.Width = 200;
                column = dataGridView1.Columns[3];
                column.Width = 200;

            }
        }

        private void qip1_CheckedChanged(object sender, EventArgs e)
        {
            if (qip1.Checked == true)
            {
                qip2.Checked = false;
                qit1.Checked = false;
                qit2.Checked = false;
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
                        decimal d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();


                    }

                }
                string queryString = $"SELECT chequeNo, description, amount, withdrawDate FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}'";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "CHEQUE #:";
                    dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
                    dataGridView1.Columns[2].HeaderText = "AMOUNT";
                    dataGridView1.Columns[3].HeaderText = "WITHDRAW DATE";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 500;

                }
            }
        }

        private void qip2_CheckedChanged(object sender, EventArgs e)
        {
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
                        decimal d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();
                    }

                }
                string queryString = $"SELECT chequeNo, description, amount, withdrawDate FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}'";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "CHEQUE #:";
                    dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
                    dataGridView1.Columns[2].HeaderText = "AMOUNT";
                    dataGridView1.Columns[3].HeaderText = "WITHDRAW DATE";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 500;

                }
            }
        }

        private void qit1_CheckedChanged(object sender, EventArgs e)
        {
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
                        decimal d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();
                    }

                }
                string queryString = $"SELECT chequeNo, description, amount, withdrawDate FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}'";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "CHEQUE #:";
                    dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
                    dataGridView1.Columns[2].HeaderText = "AMOUNT";
                    dataGridView1.Columns[3].HeaderText = "WITHDRAW DATE";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 500;

                }
            }
        }

        private void qit2_CheckedChanged(object sender, EventArgs e)
        {
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
                        decimal d = decimal.Parse(stock2);
                        balance.Text = decimal.Round(d, 2).ToString();
                    }

                }
                string queryString = $"SELECT chequeNo, description, amount, withdrawDate FROM cheque WHERE withdrawnornot = 0 AND acc = '{account}'";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "CHEQUE #:";
                    dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
                    dataGridView1.Columns[2].HeaderText = "AMOUNT";
                    dataGridView1.Columns[3].HeaderText = "WITHDRAW DATE";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 500;

                }
            }
        }

        private void chequeTime_Tick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string choice = dataGridView1.SelectedCells[0].Value.ToString();

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    refNo.Text = connection.ExecuteScalar($"SELECT chequeNo FROM cheque WHERE chequeNo = '{choice}' AND acc = '{account}'").ToString();
                    description.Text = connection.ExecuteScalar($"SELECT description FROM cheque WHERE chequeNo = '{choice}' AND acc = '{account}'").ToString();
                    amt.Text = connection.ExecuteScalar($"SELECT amount FROM cheque WHERE chequeNo = '{choice}' AND acc = '{account}'").ToString();
                }
            }
            catch (Exception)
            {


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(amt.Text, out d))
            {
                DialogResult choice = MessageBox.Show($"Issue Withrawal?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    if ((double.Parse(balance.Text) > double.Parse(amt.Text)))
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                        {
                            //connection.Query($"INSERT INTO cheque VALUES('{refNo.Text}', '{description.Text}', '{amt.Text}', '{fromY.Text}/{fromM.Text}/{fromD.Text}', 0, '{account}')");
                            connection.Query($"INSERT INTO statement VALUES('{fromY.Text}/{fromM.Text}/{fromD.Text}', '{account}', 'CHEQUE WITHDRAW', 'Cheque {refNo.Text}', '{description.Text}', '-{amt.Text}')");
                            connection.Query($"UPDATE cheque SET withdrawnornot = 1 WHERE chequeNo = '{refNo.Text}' AND acc = '{account}'");
                            if (connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'") == null)
                            {
                                balance.Text = "0.00";
                            }
                            else
                            {
                                string balStr = connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'").ToString();
                                decimal bal = decimal.Parse(balStr);
                                double newBal = (double)bal - double.Parse(amt.Text);

                                connection.Query($"UPDATE Balance SET balance = {newBal} WHERE acc = '{account}'");

                                string stock2 = connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'").ToString();
                                decimal de = decimal.Parse(stock2);
                                balance.Text = decimal.Round(de, 2).ToString();

                            }
                        }
                        MessageBox.Show("Amount Withrawn!");
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Funds!");
                    }

                }
                else
                {
                    return;
                }

            }
            else
            {

            }
        }
    }
}
