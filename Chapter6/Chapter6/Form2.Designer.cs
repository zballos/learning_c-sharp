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
            this.SuspendLayout();
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(81, 50);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 0;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(81, 88);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(81, 127);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(81, 183);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(100, 20);
            this.textValue.TabIndex = 3;
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(187, 181);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(75, 23);
            this.btnDep.TabIndex = 4;
            this.btnDep.Text = "Depositar";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}