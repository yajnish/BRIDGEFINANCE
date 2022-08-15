
namespace BRIDGEFINANCE
{
    partial class forecasting
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chequewithddrawal = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.balAfter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chequewithddrawal)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "qip1",
            "qip2",
            "qit1",
            "qit2"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 63);
            this.comboBox1.TabIndex = 109;
            this.comboBox1.Text = "qip1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chequewithddrawal
            // 
            this.chequewithddrawal.AllowUserToAddRows = false;
            this.chequewithddrawal.AllowUserToDeleteRows = false;
            this.chequewithddrawal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chequewithddrawal.Location = new System.Drawing.Point(12, 150);
            this.chequewithddrawal.Name = "chequewithddrawal";
            this.chequewithddrawal.RowHeadersWidth = 51;
            this.chequewithddrawal.RowTemplate.Height = 30;
            this.chequewithddrawal.Size = new System.Drawing.Size(697, 297);
            this.chequewithddrawal.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 94);
            this.label4.TabIndex = 112;
            this.label4.Text = "Rs.";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(297, 12);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(412, 99);
            this.balance.TabIndex = 111;
            this.balance.Text = "BALANCE";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 69);
            this.label5.TabIndex = 115;
            this.label5.Text = "Rs.";
            // 
            // balAfter
            // 
            this.balAfter.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balAfter.Location = new System.Drawing.Point(113, 525);
            this.balAfter.Name = "balAfter";
            this.balAfter.Size = new System.Drawing.Size(299, 99);
            this.balAfter.TabIndex = 114;
            this.balAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 28);
            this.label3.TabIndex = 113;
            this.label3.Text = "Balance After Cheque Withdrawals:";
            // 
            // forecasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1775, 780);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.balAfter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.chequewithddrawal);
            this.Controls.Add(this.comboBox1);
            this.Name = "forecasting";
            this.Text = "forecasting";
            this.Load += new System.EventHandler(this.forecasting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chequewithddrawal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView chequewithddrawal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox balAfter;
        private System.Windows.Forms.Label label3;
    }
}