namespace Sitema2
{
    partial class Gerenciamento_Cliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.buttonRemoverClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFecharClientes = new System.Windows.Forms.Button();
            this.buttonPesquisarCarros = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonRemoverCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 71);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1101, 367);
            this.dgvClientes.TabIndex = 0;
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(238, 13);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(107, 23);
            this.buttonPesquisarClientes.TabIndex = 1;
            this.buttonPesquisarClientes.Text = "Pesquisar Clientes";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click);
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.Location = new System.Drawing.Point(238, 41);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(107, 23);
            this.buttonRemoverClientes.TabIndex = 2;
            this.buttonRemoverClientes.Text = "Remover Cliente";
            this.buttonRemoverClientes.UseVisualStyleBackColor = true;
            this.buttonRemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciamento\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFecharClientes
            // 
            this.buttonFecharClientes.Location = new System.Drawing.Point(455, 13);
            this.buttonFecharClientes.Name = "buttonFecharClientes";
            this.buttonFecharClientes.Size = new System.Drawing.Size(75, 23);
            this.buttonFecharClientes.TabIndex = 4;
            this.buttonFecharClientes.Text = "Fechar";
            this.buttonFecharClientes.UseVisualStyleBackColor = true;
            this.buttonFecharClientes.Click += new System.EventHandler(this.buttonFecharClientes_Click);
            // 
            // buttonPesquisarCarros
            // 
            this.buttonPesquisarCarros.Location = new System.Drawing.Point(352, 13);
            this.buttonPesquisarCarros.Name = "buttonPesquisarCarros";
            this.buttonPesquisarCarros.Size = new System.Drawing.Size(97, 23);
            this.buttonPesquisarCarros.TabIndex = 5;
            this.buttonPesquisarCarros.Text = "Pesquisar Carros";
            this.buttonPesquisarCarros.UseVisualStyleBackColor = true;
            this.buttonPesquisarCarros.Click += new System.EventHandler(this.buttonPesquisarCarros_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(569, 22);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(0, 35);
            this.labelText.TabIndex = 6;
            // 
            // buttonRemoverCarro
            // 
            this.buttonRemoverCarro.Location = new System.Drawing.Point(352, 41);
            this.buttonRemoverCarro.Name = "buttonRemoverCarro";
            this.buttonRemoverCarro.Size = new System.Drawing.Size(97, 23);
            this.buttonRemoverCarro.TabIndex = 7;
            this.buttonRemoverCarro.Text = "Remover Carro";
            this.buttonRemoverCarro.UseVisualStyleBackColor = true;
            this.buttonRemoverCarro.Click += new System.EventHandler(this.buttonRemoverCarro_Click);
            // 
            // Gerenciamento_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.buttonRemoverCarro);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonPesquisarCarros);
            this.Controls.Add(this.buttonFecharClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoverClientes);
            this.Controls.Add(this.buttonPesquisarClientes);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Gerenciamento_Cliente";
            this.Text = "Gerenciamento_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFecharClientes;
        private System.Windows.Forms.Button buttonPesquisarCarros;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonRemoverCarro;
    }
}