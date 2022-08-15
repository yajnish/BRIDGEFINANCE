using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace BRIDGEFINANCE
{
    public partial class depo : Form
    {
        public depo()
        {
            InitializeComponent();
        }
        string account;
        private void depo_Load(object sender, EventArgs e)
        {
            fromD.Text = $"{DateTime.Now.ToString("dd")}";
            fromM.Text = $"{DateTime.Now.ToString("MM")}";
            fromY.Text = $"{DateTime.Now.ToString("yyyy")}";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal d;
            DialogResult choice;

            if (decimal.TryParse(amt.Text, out d))
            {
                choice = MessageBox.Show($"Approve Deposit?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                    {
                        connection.Query($"INSERT INTO statement VALUES('{fromY.Text}/{fromM.Text}/{fromD.Text}', '{account}', 'DEPOSIT', '{refNo.Text}', '{description.Text}', '{amt.Text}')");
                        
                        if (connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'") == null)
                        {
                            balance.Text = "0.00";
                        }
                        else
                        {
                            string balStr = connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'").ToString();
                            decimal bal = decimal.Parse(balStr);
                            double newBal = double.Parse(amt.Text) + (double)bal;

                            connection.Query($"UPDATE Balance SET balance = {newBal} WHERE acc = '{account}'");

                            string stock2 = connection.ExecuteScalar($"SELECT balance FROM Balance WHERE acc= '{account}'").ToString();
                            decimal de = decimal.Parse(stock2);
                            balance.Text = decimal.Round(de, 2).ToString();


                        }
                    }
                    MessageBox.Show("Amount successfully deposited!");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Amount not in valid format!");
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
            }
        }
    }
}
