namespace Chapter6
{
    partial class Form3
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
            this.comboAccounts = new System.Windows.Forms.ComboBox();
            this.Contas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboAccounts
            // 
            this.comboAccounts.FormattingEnabled = true;
            this.comboAccounts.Location = new System.Drawing.Point(138, 86);
            this.comboAccounts.Name = "comboAccounts";
            this.comboAccounts.Size = new System.Drawing.Size(169, 21);
            this.comboAccounts.TabIndex = 0;
            this.comboAccounts.SelectedIndexChanged += new System.EventHandler(this.comboAccounts_SelectedIndexChanged);
            // 
            // Contas
            // 
            this.Contas.AutoSize = true;
            this.Contas.Location = new System.Drawing.Point(75, 89);
            this.Contas.Name = "Contas";
            this.Contas.Size = new System.Drawing.Size(40, 13);
            this.Contas.TabIndex = 1;
            this.Contas.Text = "Contas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titular";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(138, 127);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(127, 20);
            this.txtTitular.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(138, 163);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(127, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(138, 202);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(127, 20);
            this.txtBalance.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 409);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contas);
            this.Controls.Add(this.comboAccounts);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAccounts;
        private System.Windows.Forms.Label Contas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
    }
}