namespace Projeto_CCV
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
            this.btAdmClientes = new System.Windows.Forms.Button();
            this.btAdmVendas = new System.Windows.Forms.Button();
            this.btAdmProdutos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btAdmClientes
            // 
            this.btAdmClientes.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmClientes.Location = new System.Drawing.Point(13, 50);
            this.btAdmClientes.Name = "btAdmClientes";
            this.btAdmClientes.Size = new System.Drawing.Size(200, 50);
            this.btAdmClientes.TabIndex = 0;
            this.btAdmClientes.Text = "Administrar Clientes";
            this.btAdmClientes.UseVisualStyleBackColor = true;
            this.btAdmClientes.Click += new System.EventHandler(this.btAdmClientes_Click);
            // 
            // btAdmVendas
            // 
            this.btAdmVendas.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmVendas.Location = new System.Drawing.Point(305, 50);
            this.btAdmVendas.Name = "btAdmVendas";
            this.btAdmVendas.Size = new System.Drawing.Size(200, 50);
            this.btAdmVendas.TabIndex = 1;
            this.btAdmVendas.Text = "Administrar Vendas";
            this.btAdmVendas.UseVisualStyleBackColor = true;
            this.btAdmVendas.Click += new System.EventHandler(this.btAdmVendas_Click);
            // 
            // btAdmProdutos
            // 
            this.btAdmProdutos.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmProdutos.Location = new System.Drawing.Point(597, 50);
            this.btAdmProdutos.Name = "btAdmProdutos";
            this.btAdmProdutos.Size = new System.Drawing.Size(200, 50);
            this.btAdmProdutos.TabIndex = 2;
            this.btAdmProdutos.Text = "Administrar Produtos";
            this.btAdmProdutos.UseVisualStyleBackColor = true;
            this.btAdmProdutos.Click += new System.EventHandler(this.btAdmProdutos_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 441);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAdmProdutos);
            this.Controls.Add(this.btAdmVendas);
            this.Controls.Add(this.btAdmClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Controle de Clientes e Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdmClientes;
        private System.Windows.Forms.Button btAdmVendas;
        private System.Windows.Forms.Button btAdmProdutos;
        private System.Windows.Forms.Panel panel1;
    }
}

