
namespace BRIDGEFINANCE
{
    partial class recordCheque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.qit2 = new System.Windows.Forms.CheckBox();
            this.qit1 = new System.Windows.Forms.CheckBox();
            this.qip2 = new System.Windows.Forms.CheckBox();
            this.qip1 = new System.Windows.Forms.CheckBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chequeNoText = new System.Windows.Forms.Label();
            this.refNo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chequeTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(758, 69);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cheques Yet To Be Withdrawn:";
            // 
            // qit2
            // 
            this.qit2.AutoSize = true;
            this.qit2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit2.Location = new System.Drawing.Point(570, 12);
            this.qit2.Name = "qit2";
            this.qit2.Size = new System.Drawing.Size(167, 59);
            this.qit2.TabIndex = 54;
            this.qit2.Text = "QIT2";
            this.qit2.UseVisualStyleBackColor = true;
            this.qit2.CheckedChanged += new System.EventHandler(this.qit2_CheckedChanged);
            // 
            // qit1
            // 
            this.qit1.AutoSize = true;
            this.qit1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit1.Location = new System.Drawing.Point(397, 12);
            this.qit1.Name = "qit1";
            this.qit1.Size = new System.Drawing.Size(167, 59);
            this.qit1.TabIndex = 53;
            this.qit1.Text = "QIT1";
            this.qit1.UseVisualStyleBackColor = true;
            this.qit1.CheckedChanged += new System.EventHandler(this.qit1_CheckedChanged);
            // 
            // qip2
            // 
            this.qip2.AutoSize = true;
            this.qip2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip2.Location = new System.Drawing.Point(225, 12);
            this.qip2.Name = "qip2";
            this.qip2.Size = new System.Drawing.Size(166, 59);
            this.qip2.TabIndex = 52;
            this.qip2.Text = "QIP2";
            this.qip2.UseVisualStyleBackColor = true;
            this.qip2.CheckedChanged += new System.EventHandler(this.qip2_CheckedChanged);
            // 
            // qip1
            // 
            this.qip1.AutoSize = true;
            this.qip1.Checked = true;
            this.qip1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qip1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip1.Location = new System.Drawing.Point(53, 13);
            this.qip1.Name = "qip1";
            this.qip1.Size = new System.Drawing.Size(166, 59);
            this.qip1.TabIndex = 51;
            this.qip1.Text = "QIP1";
            this.qip1.UseVisualStyleBackColor = true;
            this.qip1.CheckedChanged += new System.EventHandler(this.qip1_CheckedChanged);
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(774, 13);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(311, 61);
            this.balance.TabIndex = 55;
            this.balance.Text = "BALANCE";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(783, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "DD            MM              YYYY";
            // 
            // fromY
            // 
            this.fromY.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromY.FormattingEnabled = true;
            this.fromY.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.fromY.Location = new System.Drawing.Point(955, 593);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(135, 52);
            this.fromY.TabIndex = 58;
            this.fromY.Text = "2022";
            // 
            // fromM
            // 
            this.fromM.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromM.FormattingEnabled = true;
            this.fromM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.fromM.Location = new System.Drawing.Point(868, 593);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(81, 52);
            this.fromM.TabIndex = 57;
            this.fromM.Text = "01";
            // 
            // fromD
            // 
            this.fromD.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromD.FormattingEnabled = true;
            this.fromD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.fromD.Location = new System.Drawing.Point(787, 593);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(75, 52);
            this.fromD.TabIndex = 56;
            this.fromD.Text = "01";
            // 
            // amt
            // 
            this.amt.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(315, 845);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(453, 62);
            this.amt.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(40, 862);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 52);
            this.label3.TabIndex = 64;
            this.label3.Text = "AMOUNT(Rs) :";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(315, 665);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(453, 158);
            this.description.TabIndex = 63;
            this.description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 52);
            this.label2.TabIndex = 62;
            this.label2.Text = "DESCRIPTION:";
            // 
            // chequeNoText
            // 
            this.chequeNoText.AutoSize = true;
            this.chequeNoText.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeNoText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chequeNoText.Location = new System.Drawing.Point(47, 576);
            this.chequeNoText.Name = "chequeNoText";
            this.chequeNoText.Size = new System.Drawing.Size(253, 52);
            this.chequeNoText.TabIndex = 61;
            this.chequeNoText.Text = "CHEQUE NO:";
            // 
            // refNo
            // 
            this.refNo.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refNo.Location = new System.Drawing.Point(315, 566);
            this.refNo.Name = "refNo";
            this.refNo.Size = new System.Drawing.Size(453, 62);
            this.refNo.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(787, 766);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 137);
            this.button2.TabIndex = 66;
            this.button2.Text = "MARK AS\r\nWITHDRAWN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chequeTime
            // 
            this.chequeTime.Enabled = true;
            this.chequeTime.Interval = 1000;
            this.chequeTime.Tick += new System.EventHandler(this.chequeTime_Tick);
            // 
            // recordCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1128, 915);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chequeNoText);
            this.Controls.Add(this.refNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.qit2);
            this.Controls.Add(this.qit1);
            this.Controls.Add(this.qip2);
            this.Controls.Add(this.qip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "recordCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recordCheque";
            this.Load += new System.EventHandler(this.recordCheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox qit2;
        private System.Windows.Forms.CheckBox qit1;
        private System.Windows.Forms.CheckBox qip2;
        private System.Windows.Forms.CheckBox qip1;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chequeNoText;
        private System.Windows.Forms.TextBox refNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer chequeTime;
    }
}