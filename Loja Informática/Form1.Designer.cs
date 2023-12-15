namespace Loja_Informática
{
    partial class Form1
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldesignacao = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbdesignacao = new System.Windows.Forms.TextBox();
            this.tbpreco = new System.Windows.Forms.TextBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.lbprodutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(52, 96);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(82, 25);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            // 
            // lbldesignacao
            // 
            this.lbldesignacao.AutoSize = true;
            this.lbldesignacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesignacao.Location = new System.Drawing.Point(15, 138);
            this.lbldesignacao.Name = "lbldesignacao";
            this.lbldesignacao.Size = new System.Drawing.Size(119, 25);
            this.lbldesignacao.TabIndex = 1;
            this.lbldesignacao.Text = "Designação:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(31, 180);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(103, 25);
            this.lblcategoria.TabIndex = 2;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.Location = new System.Drawing.Point(66, 222);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(68, 25);
            this.lblpreco.TabIndex = 3;
            this.lblpreco.Text = "Preço:";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigo.Location = new System.Drawing.Point(140, 93);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(115, 33);
            this.tbcodigo.TabIndex = 4;
            // 
            // tbdesignacao
            // 
            this.tbdesignacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdesignacao.Location = new System.Drawing.Point(140, 138);
            this.tbdesignacao.Name = "tbdesignacao";
            this.tbdesignacao.Size = new System.Drawing.Size(270, 33);
            this.tbdesignacao.TabIndex = 5;
            // 
            // tbpreco
            // 
            this.tbpreco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpreco.Location = new System.Drawing.Point(140, 219);
            this.tbpreco.Name = "tbpreco";
            this.tbpreco.Size = new System.Drawing.Size(115, 33);
            this.tbpreco.TabIndex = 6;
            // 
            // cbcategoria
            // 
            this.cbcategoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(140, 177);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(172, 33);
            this.cbcategoria.TabIndex = 7;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // lbprodutos
            // 
            this.lbprodutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprodutos.FormattingEnabled = true;
            this.lbprodutos.ItemHeight = 25;
            this.lbprodutos.Location = new System.Drawing.Point(425, 58);
            this.lbprodutos.Name = "lbprodutos";
            this.lbprodutos.Size = new System.Drawing.Size(290, 254);
            this.lbprodutos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 382);
            this.Controls.Add(this.lbprodutos);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.tbpreco);
            this.Controls.Add(this.tbdesignacao);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lbldesignacao);
            this.Controls.Add(this.lblcodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldesignacao;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbdesignacao;
        private System.Windows.Forms.TextBox tbpreco;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.ListBox lbprodutos;
    }
}

