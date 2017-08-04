namespace Chapter6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnAnualBalance = new System.Windows.Forms.Button();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(202, 36);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(182, 23);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Teste Classe";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(202, 87);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(182, 23);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transferencia";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnAnualBalance
            // 
            this.btnAnualBalance.Location = new System.Drawing.Point(202, 139);
            this.btnAnualBalance.Name = "btnAnualBalance";
            this.btnAnualBalance.Size = new System.Drawing.Size(182, 23);
            this.btnAnualBalance.TabIndex = 2;
            this.btnAnualBalance.Text = "Saldo anual";
            this.btnAnualBalance.UseVisualStyleBackColor = true;
            this.btnAnualBalance.Click += new System.EventHandler(this.btnAnualBalance_Click);
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(202, 368);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(182, 20);
            this.tbTitular.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 550);
            this.Controls.Add(this.tbTitular);
            this.Controls.Add(this.btnAnualBalance);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnAnualBalance;
        private System.Windows.Forms.TextBox tbTitular;
    }
}

