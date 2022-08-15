
namespace BRIDGEFINANCE
{
    partial class withdraw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.otherwithdraw = new System.Windows.Forms.Button();
            this.cheque = new System.Windows.Forms.Button();
            this.amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chequeNoText = new System.Windows.Forms.Label();
            this.refNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Reference = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.qit2 = new System.Windows.Forms.CheckBox();
            this.qit1 = new System.Windows.Forms.CheckBox();
            this.qip2 = new System.Windows.Forms.CheckBox();
            this.qip1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.otherwithdraw);
            this.panel1.Controls.Add(this.cheque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 802);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 122);
            this.button1.TabIndex = 3;
            this.button1.Text = "RECORD CHEQUE WITHDRAWAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // otherwithdraw
            // 
            this.otherwithdraw.BackColor = System.Drawing.Color.Navy;
            this.otherwithdraw.FlatAppearance.BorderSize = 0;
            this.otherwithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherwithdraw.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherwithdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.otherwithdraw.Location = new System.Drawing.Point(0, 248);
            this.otherwithdraw.Name = "otherwithdraw";
            this.otherwithdraw.Size = new System.Drawing.Size(241, 122);
            this.otherwithdraw.TabIndex = 2;
            this.otherwithdraw.Text = "OTHER\r\nWITHDRAWAL";
            this.otherwithdraw.UseVisualStyleBackColor = false;
            this.otherwithdraw.Click += new System.EventHandler(this.otherwithdraw_Click);
            // 
            // cheque
            // 
            this.cheque.BackColor = System.Drawing.Color.Navy;
            this.cheque.FlatAppearance.BorderSize = 0;
            this.cheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheque.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cheque.Location = new System.Drawing.Point(0, 61);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(241, 118);
            this.cheque.TabIndex = 1;
            this.cheque.Text = "CHEQUE ISSUING";
            this.cheque.UseVisualStyleBackColor = false;
            this.cheque.Click += new System.EventHandler(this.cheque_Click);
            // 
            // amt
            // 
            this.amt.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(994, 563);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(453, 99);
            this.amt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(475, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 85);
            this.label3.TabIndex = 20;
            this.label3.Text = "AMOUNT(Rs) :";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(994, 383);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(453, 158);
            this.description.TabIndex = 19;
            this.description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(463, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 85);
            this.label2.TabIndex = 18;
            this.label2.Text = "DESCRIPTION:";
            // 
            // chequeNoText
            // 
            this.chequeNoText.AutoSize = true;
            this.chequeNoText.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeNoText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chequeNoText.Location = new System.Drawing.Point(519, 277);
            this.chequeNoText.Name = "chequeNoText";
            this.chequeNoText.Size = new System.Drawing.Size(460, 85);
            this.chequeNoText.TabIndex = 17;
            this.chequeNoText.Text = "CHEQUE NO:";
            // 
            // refNo
            // 
            this.refNo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refNo.Location = new System.Drawing.Point(994, 284);
            this.refNo.Name = "refNo";
            this.refNo.Size = new System.Drawing.Size(453, 76);
            this.refNo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 69);
            this.label4.TabIndex = 23;
            this.label4.Text = "Current Balance: Rs.";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(1085, 29);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(392, 76);
            this.balance.TabIndex = 22;
            this.balance.Text = "BALANCE";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(241, 714);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1286, 88);
            this.button2.TabIndex = 24;
            this.button2.Text = "ISSUE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.BackColor = System.Drawing.Color.Transparent;
            this.Reference.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reference.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reference.Location = new System.Drawing.Point(519, 277);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(460, 85);
            this.Reference.TabIndex = 25;
            this.Reference.Text = "REFERENCE:";
            this.Reference.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1180, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 24);
            this.label6.TabIndex = 42;
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
            this.fromY.Location = new System.Drawing.Point(1307, 181);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(135, 52);
            this.fromY.TabIndex = 41;
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
            this.fromM.Location = new System.Drawing.Point(1220, 181);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(81, 52);
            this.fromM.TabIndex = 40;
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
            this.fromD.Location = new System.Drawing.Point(1139, 181);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(75, 52);
            this.fromD.TabIndex = 39;
            this.fromD.Text = "01";
            this.fromD.SelectedIndexChanged += new System.EventHandler(this.fromD_SelectedIndexChanged);
            // 
            // qit2
            // 
            this.qit2.AutoSize = true;
            this.qit2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit2.Location = new System.Drawing.Point(857, 174);
            this.qit2.Name = "qit2";
            this.qit2.Size = new System.Drawing.Size(167, 59);
            this.qit2.TabIndex = 46;
            this.qit2.Text = "QIT2";
            this.qit2.UseVisualStyleBackColor = true;
            this.qit2.CheckedChanged += new System.EventHandler(this.qit2_CheckedChanged_1);
            // 
            // qit1
            // 
            this.qit1.AutoSize = true;
            this.qit1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qit1.Location = new System.Drawing.Point(684, 174);
            this.qit1.Name = "qit1";
            this.qit1.Size = new System.Drawing.Size(167, 59);
            this.qit1.TabIndex = 45;
            this.qit1.Text = "QIT1";
            this.qit1.UseVisualStyleBackColor = true;
            this.qit1.CheckedChanged += new System.EventHandler(this.qit1_CheckedChanged_1);
            // 
            // qip2
            // 
            this.qip2.AutoSize = true;
            this.qip2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip2.Location = new System.Drawing.Point(512, 174);
            this.qip2.Name = "qip2";
            this.qip2.Size = new System.Drawing.Size(166, 59);
            this.qip2.TabIndex = 44;
            this.qip2.Text = "QIP2";
            this.qip2.UseVisualStyleBackColor = true;
            this.qip2.CheckedChanged += new System.EventHandler(this.qip2_CheckedChanged_1);
            // 
            // qip1
            // 
            this.qip1.AutoSize = true;
            this.qip1.Checked = true;
            this.qip1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qip1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qip1.Location = new System.Drawing.Point(340, 175);
            this.qip1.Name = "qip1";
            this.qip1.Size = new System.Drawing.Size(166, 59);
            this.qip1.TabIndex = 43;
            this.qip1.Text = "QIP1";
            this.qip1.UseVisualStyleBackColor = true;
            this.qip1.CheckedChanged += new System.EventHandler(this.qip1_CheckedChanged_1);
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1527, 802);
            this.Controls.Add(this.qit2);
            this.Controls.Add(this.qit1);
            this.Controls.Add(this.qip2);
            this.Controls.Add(this.qip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chequeNoText);
            this.Controls.Add(this.refNo);
            this.Controls.Add(this.panel1);
            this.Name = "withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button otherwithdraw;
        private System.Windows.Forms.Button cheque;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chequeNoText;
        private System.Windows.Forms.TextBox refNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.CheckBox qit2;
        private System.Windows.Forms.CheckBox qit1;
        private System.Windows.Forms.CheckBox qip2;
        private System.Windows.Forms.CheckBox qip1;
    }
}