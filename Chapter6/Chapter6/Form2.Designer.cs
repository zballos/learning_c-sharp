namespace Chapter6
{
    partial class Form2
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
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.textValue = new System.Windows.Forms.TextBox();
            this.btnDep = new System.Windows.Forms.Button();
            this.btnSaq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(176, 39);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(114, 20);
            this.txtTitular.TabIndex = 0;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(176, 77);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(114, 20);
            this.txtBalance.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(176, 116);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(114, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(176, 173);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(114, 20);
            this.textValue.TabIndex = 3;
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(176, 212);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(75, 23);
            this.btnDep.TabIndex = 4;
            this.btnDep.Text = "Depositar";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnSaq
            // 
            this.btnSaq.Location = new System.Drawing.Point(275, 212);
            this.btnSaq.Name = "btnSaq";
            this.btnSaq.Size = new System.Drawing.Size(75, 23);
            this.btnSaq.TabIndex = 5;
            this.btnSaq.Text = "Sacar";
            this.btnSaq.UseVisualStyleBackColor = true;
            this.btnSaq.Click += new System.EventHandler(this.btnSaq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaq);
            this.Controls.Add(this.btnDep);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtTitular);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btnSaq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}