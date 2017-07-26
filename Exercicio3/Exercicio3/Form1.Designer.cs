namespace Exercicio3
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
			this.btnVoto = new System.Windows.Forms.Button();
			this.btnNfe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVoto
			// 
			this.btnVoto.Location = new System.Drawing.Point(61, 64);
			this.btnVoto.Name = "btnVoto";
			this.btnVoto.Size = new System.Drawing.Size(152, 23);
			this.btnVoto.TabIndex = 0;
			this.btnVoto.Text = "Quem pode votar?";
			this.btnVoto.UseVisualStyleBackColor = true;
			this.btnVoto.Click += new System.EventHandler(this.btnVoto_Click);
			// 
			// btnNfe
			// 
			this.btnNfe.Location = new System.Drawing.Point(61, 94);
			this.btnNfe.Name = "btnNfe";
			this.btnNfe.Size = new System.Drawing.Size(152, 23);
			this.btnNfe.TabIndex = 1;
			this.btnNfe.Text = "Valor NFE";
			this.btnNfe.UseVisualStyleBackColor = true;
			this.btnNfe.Click += new System.EventHandler(this.btnNfe_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnNfe);
			this.Controls.Add(this.btnVoto);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnVoto;
		private System.Windows.Forms.Button btnNfe;
	}
}

