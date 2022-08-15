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
    public partial class expense : Form
    {
        public expense()
        {
            InitializeComponent();
        }

        private void expense_Load(object sender, EventArgs e)
        {
            fromD.Text = $"{DateTime.Now.ToString("dd")}";
            fromM.Text = $"{DateTime.Now.ToString("MM")}";
            fromY.Text = $"{DateTime.Now.ToString("yyyy")}";

            

        }

        private void button2_Click(object sender, EventArgs e)
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
                        connection.Query($"INSERT INTO expenses VALUES('{fromY.Text}/{fromM.Text}/{fromD.Text}', '{description.Text}', '{amt.Text}', '{comboBox1.Text}')");
                    }
                    MessageBox.Show("Expense Recorded!");
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
    }
}
