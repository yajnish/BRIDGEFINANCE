
namespace BRIDGEFINANCE
{
    partial class depo
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
            this.refNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.qit2 = new System.Windows.Forms.CheckBox();
            this.qit1 = new System.Windows.Forms.CheckBox();
            this.qip2 = new System.Windows.Forms.CheckBox();
            this.qip1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // refNo
            // 
            this.refNo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refNo.Location = new System.Drawing.Point(538, 210);
            this.refNo.Name = "refNo";
            this.refNo.Size = new System.Drawing.Size(548, 76);
            this.refNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "REFERENCE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 69);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Balance: Rs.";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(745, 13);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(392, 76);
            this.balance.TabIndex = 9;
            this.balance.Text = "BALANCE";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 85);
            this.label2.TabIndex = 12;
            this.label2.Text = "DESCRIPTION:";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(538, 360);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(548, 158);
            this.description.TabIndex = 13;
            this.description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 85);
            this.label3.TabIndex = 14;
            this.label3.Text = "AMOUNT(Rs) :";
            // 
            // amt
            // 
            this.amt.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(538, 590);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(548, 99);
            this.amt.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 769);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1149, 88);
            this.button1.TabIndex = 16;
            this.button1.Text = "DEPOSIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qit2
            // 
            this.qit2.AutoSize = true;
            this.qit2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit2.Location = new System.Drawing.Point(536, 114);
            this.qit2.Name = "qit2";
            this.qit2.Size = new System.Drawing.Size(167, 59);
            this.qit2.TabIndex = 50;
            this.qit2.Text = "QIT2";
            this.qit2.UseVisualStyleBackColor = true;
            this.qit2.CheckedChanged += new System.EventHandler(this.qit2_CheckedChanged);
            // 
            // qit1
            // 
            this.qit1.AutoSize = true;
            this.qit1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit1.Location = new System.Drawing.Point(363, 114);
            this.qit1.Name = "qit1";
            this.qit1.Size = new System.Drawing.Size(167, 59);
            this.qit1.TabIndex = 49;
            this.qit1.Text = "QIT1";
            this.qit1.UseVisualStyleBackColor = true;
            this.qit1.CheckedChanged += new System.EventHandler(this.qit1_CheckedChanged);
            // 
            // qip2
            // 
            this.qip2.AutoSize = true;
            this.qip2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip2.Location = new System.Drawing.Point(191, 114);
            this.qip2.Name = "qip2";
            this.qip2.Size = new System.Drawing.Size(166, 59);
            this.qip2.TabIndex = 48;
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
            this.qip1.Location = new System.Drawing.Point(19, 115);
            this.qip1.Name = "qip1";
            this.qip1.Size = new System.Drawing.Size(166, 59);
            this.qip1.TabIndex = 47;
            this.qip1.Text = "QIP1";
            this.qip1.UseVisualStyleBackColor = true;
            this.qip1.CheckedChanged += new System.EventHandler(this.qip1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(824, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 24);
            this.label6.TabIndex = 54;
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
            this.fromY.Location = new System.Drawing.Point(951, 122);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(135, 52);
            this.fromY.TabIndex = 53;
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
            this.fromM.Location = new System.Drawing.Point(864, 122);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(81, 52);
            this.fromM.TabIndex = 52;
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
            this.fromD.Location = new System.Drawing.Point(783, 122);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(75, 52);
            this.fromD.TabIndex = 51;
            this.fromD.Text = "01";
            // 
            // depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1149, 857);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.qit2);
            this.Controls.Add(this.qit1);
            this.Controls.Add(this.qip2);
            this.Controls.Add(this.qip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "depo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPOSIT";
            this.Load += new System.EventHandler(this.depo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox refNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox qit2;
        private System.Windows.Forms.CheckBox qit1;
        private System.Windows.Forms.CheckBox qip2;
        private System.Windows.Forms.CheckBox qip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
    }
}