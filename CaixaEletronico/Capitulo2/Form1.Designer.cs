namespace CaixaEletronico
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
			this.btnSaldo = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnCast = new System.Windows.Forms.Button();
			this.btnFormula = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSaldo
			// 
			this.btnSaldo.Location = new System.Drawing.Point(72, 44);
			this.btnSaldo.Name = "btnSaldo";
			this.btnSaldo.Size = new System.Drawing.Size(135, 23);
			this.btnSaldo.TabIndex = 0;
			this.btnSaldo.Text = "Saldo de Conta";
			this.btnSaldo.UseVisualStyleBackColor = true;
			this.btnSaldo.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(72, 73);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(135, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Média de Idades";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnCast
			// 
			this.btnCast.Location = new System.Drawing.Point(72, 103);
			this.btnCast.Name = "btnCast";
			this.btnCast.Size = new System.Drawing.Size(135, 23);
			this.btnCast.TabIndex = 3;
			this.btnCast.Text = "Cast Double to Int";
			this.btnCast.UseVisualStyleBackColor = true;
			this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
			// 
			// btnFormula
			// 
			this.btnFormula.Location = new System.Drawing.Point(72, 133);
			this.btnFormula.Name = "btnFormula";
			this.btnFormula.Size = new System.Drawing.Size(135, 23);
			this.btnFormula.TabIndex = 4;
			this.btnFormula.Text = "Fórmula de Báskara";
			this.btnFormula.UseVisualStyleBackColor = true;
			this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnFormula);
			this.Controls.Add(this.btnCast);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnSaldo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSaldo;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnCast;
		private System.Windows.Forms.Button btnFormula;
	}
}

