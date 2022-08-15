
namespace BRIDGEFINANCE
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cashDep = new System.Windows.Forms.Button();
            this.chequeIssue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balance = new System.Windows.Forms.TextBox();
            this.forecast = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequewithddrawal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balAfter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qip1 = new System.Windows.Forms.CheckBox();
            this.qip2 = new System.Windows.Forms.CheckBox();
            this.qit1 = new System.Windows.Forms.CheckBox();
            this.qit2 = new System.Windows.Forms.CheckBox();
            this.balTimer = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequewithddrawal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cashDep);
            this.panel1.Controls.Add(this.chequeIssue);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 735);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 72);
            this.button3.TabIndex = 6;
            this.button3.Text = "Purchases";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "Daily Sales Log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 171);
            this.button1.TabIndex = 4;
            this.button1.Text = "REPORTS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashDep
            // 
            this.cashDep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashDep.FlatAppearance.BorderSize = 0;
            this.cashDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashDep.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashDep.Location = new System.Drawing.Point(0, 246);
            this.cashDep.Name = "cashDep";
            this.cashDep.Size = new System.Drawing.Size(236, 75);
            this.cashDep.TabIndex = 3;
            this.cashDep.Text = "Deposit";
            this.cashDep.UseVisualStyleBackColor = false;
            this.cashDep.Click += new System.EventHandler(this.cashDep_Click);
            // 
            // chequeIssue
            // 
            this.chequeIssue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chequeIssue.FlatAppearance.BorderSize = 0;
            this.chequeIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chequeIssue.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chequeIssue.Location = new System.Drawing.Point(0, 158);
            this.chequeIssue.Name = "chequeIssue";
            this.chequeIssue.Size = new System.Drawing.Size(236, 82);
            this.chequeIssue.TabIndex = 2;
            this.chequeIssue.Text = "Withdrawal";
            this.chequeIssue.UseVisualStyleBackColor = false;
            this.chequeIssue.Click += new System.EventHandler(this.chequeIssue_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 142);
            this.panel2.TabIndex = 1;
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Arial Narrow", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(928, 77);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(568, 122);
            this.balance.TabIndex = 1;
            this.balance.Text = "BALANCE";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // forecast
            // 
            this.forecast.AllowUserToAddRows = false;
            this.forecast.AllowUserToDeleteRows = false;
            this.forecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forecast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.bal});
            this.forecast.Location = new System.Drawing.Point(1180, 267);
            this.forecast.Name = "forecast";
            this.forecast.RowHeadersWidth = 51;
            this.forecast.RowTemplate.Height = 24;
            this.forecast.Size = new System.Drawing.Size(316, 461);
            this.forecast.TabIndex = 2;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // bal
            // 
            this.bal.HeaderText = "Balance";
            this.bal.MinimumWidth = 6;
            this.bal.Name = "bal";
            this.bal.Width = 150;
            // 
            // chequewithddrawal
            // 
            this.chequewithddrawal.AllowUserToAddRows = false;
            this.chequewithddrawal.AllowUserToDeleteRows = false;
            this.chequewithddrawal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chequewithddrawal.Location = new System.Drawing.Point(265, 267);
            this.chequewithddrawal.Name = "chequewithddrawal";
            this.chequewithddrawal.RowHeadersWidth = 51;
            this.chequewithddrawal.RowTemplate.Height = 30;
            this.chequewithddrawal.Size = new System.Drawing.Size(896, 328);
            this.chequewithddrawal.TabIndex = 3;
            this.chequewithddrawal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chequewithddrawal_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upcoming Cheque Withdrawals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1175, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Balance Forecast:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Balance After Cheque Withdrawals:";
            // 
            // balAfter
            // 
            this.balAfter.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balAfter.Location = new System.Drawing.Point(845, 624);
            this.balAfter.Name = "balAfter";
            this.balAfter.Size = new System.Drawing.Size(316, 99);
            this.balAfter.TabIndex = 7;
            this.balAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.balAfter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(711, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 137);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rs.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 69);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rs.";
            // 
            // qip1
            // 
            this.qip1.AutoSize = true;
            this.qip1.Checked = true;
            this.qip1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qip1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip1.Location = new System.Drawing.Point(511, 13);
            this.qip1.Name = "qip1";
            this.qip1.Size = new System.Drawing.Size(166, 59);
            this.qip1.TabIndex = 10;
            this.qip1.Text = "QIP1";
            this.qip1.UseVisualStyleBackColor = true;
            this.qip1.CheckedChanged += new System.EventHandler(this.qip1_CheckedChanged);
            // 
            // qip2
            // 
            this.qip2.AutoSize = true;
            this.qip2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip2.Location = new System.Drawing.Point(683, 12);
            this.qip2.Name = "qip2";
            this.qip2.Size = new System.Drawing.Size(166, 59);
            this.qip2.TabIndex = 11;
            this.qip2.Text = "QIP2";
            this.qip2.UseVisualStyleBackColor = true;
            this.qip2.CheckedChanged += new System.EventHandler(this.qip2_CheckedChanged);
            // 
            // qit1
            // 
            this.qit1.AutoSize = true;
            this.qit1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit1.Location = new System.Drawing.Point(855, 12);
            this.qit1.Name = "qit1";
            this.qit1.Size = new System.Drawing.Size(167, 59);
            this.qit1.TabIndex = 12;
            this.qit1.Text = "QIT1";
            this.qit1.UseVisualStyleBackColor = true;
            this.qit1.CheckedChanged += new System.EventHandler(this.qit1_CheckedChanged);
            // 
            // qit2
            // 
            this.qit2.AutoSize = true;
            this.qit2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit2.Location = new System.Drawing.Point(1028, 12);
            this.qit2.Name = "qit2";
            this.qit2.Size = new System.Drawing.Size(167, 59);
            this.qit2.TabIndex = 13;
            this.qit2.Text = "QIT2";
            this.qit2.UseVisualStyleBackColor = true;
            this.qit2.CheckedChanged += new System.EventHandler(this.qit2_CheckedChanged);
            // 
            // balTimer
            // 
            this.balTimer.Enabled = true;
            this.balTimer.Interval = 3000;
            this.balTimer.Tick += new System.EventHandler(this.balTimer_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(-1, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 72);
            this.button4.TabIndex = 7;
            this.button4.Text = "Expenses";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1508, 735);
            this.Controls.Add(this.qit2);
            this.Controls.Add(this.qit1);
            this.Controls.Add(this.qip2);
            this.Controls.Add(this.qip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balAfter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chequewithddrawal);
            this.Controls.Add(this.forecast);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequewithddrawal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cashDep;
        private System.Windows.Forms.Button chequeIssue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.DataGridView forecast;
        private System.Windows.Forms.DataGridView chequewithddrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balAfter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox qip1;
        private System.Windows.Forms.CheckBox qip2;
        private System.Windows.Forms.CheckBox qit1;
        private System.Windows.Forms.CheckBox qit2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer balTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn bal;
        private System.Windows.Forms.Button button4;
    }
}

