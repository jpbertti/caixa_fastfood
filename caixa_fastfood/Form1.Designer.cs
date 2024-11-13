namespace caixa_fastfood
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 110);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(27, 174);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(328, 174);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(100, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "CAIXA FAST FOOD SENAC";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(337, 110);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(66, 20);
            this.txtQuantidade.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(219, 108);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(112, 20);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo: ";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTabela.Location = new System.Drawing.Point(122, 241);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(205, 20);
            this.lblTabela.TabIndex = 7;
            this.lblTabela.Text = "CÓDIGOS / PRODUTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 112);
            this.label1.TabIndex = 8;
            this.label1.Text = "1 - SANDUÍCHE DE PRESUNTO\r\n\r\n2 - SUCO DE TAMARINDO\r\n\r\n3 - PASTEL DE VENTO\r\n\r\n4 - " +
    "PÃO COM MARGARINA\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label label1;
    }
}

