
namespace Garrafeira
{
    partial class Exemplo
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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEncomendas = new System.Windows.Forms.Button();
            this.buttonFornecedores = new System.Windows.Forms.Button();
            this.buttonViaturas = new System.Windows.Forms.Button();
            this.buttonEmpregados = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonBebidas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.panelSideBar.Controls.Add(this.buttonEncomendas);
            this.panelSideBar.Controls.Add(this.buttonFornecedores);
            this.panelSideBar.Controls.Add(this.buttonViaturas);
            this.panelSideBar.Controls.Add(this.buttonEmpregados);
            this.panelSideBar.Controls.Add(this.buttonClientes);
            this.panelSideBar.Controls.Add(this.buttonBebidas);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 509);
            this.panelSideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(412, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Home";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(481, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 76);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bem-vindo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonEncomendas
            // 
            this.buttonEncomendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEncomendas.FlatAppearance.BorderSize = 0;
            this.buttonEncomendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncomendas.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncomendas.Image = global::Garrafeira.Properties.Resources.encomendas1;
            this.buttonEncomendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEncomendas.Location = new System.Drawing.Point(0, 434);
            this.buttonEncomendas.Name = "buttonEncomendas";
            this.buttonEncomendas.Size = new System.Drawing.Size(200, 67);
            this.buttonEncomendas.TabIndex = 7;
            this.buttonEncomendas.Text = " Encomendas";
            this.buttonEncomendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEncomendas.UseVisualStyleBackColor = true;
            this.buttonEncomendas.Click += new System.EventHandler(this.buttonEncomendas_Click);
            // 
            // buttonFornecedores
            // 
            this.buttonFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFornecedores.FlatAppearance.BorderSize = 0;
            this.buttonFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFornecedores.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFornecedores.Image = global::Garrafeira.Properties.Resources.fornecedores;
            this.buttonFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFornecedores.Location = new System.Drawing.Point(0, 367);
            this.buttonFornecedores.Name = "buttonFornecedores";
            this.buttonFornecedores.Size = new System.Drawing.Size(200, 67);
            this.buttonFornecedores.TabIndex = 6;
            this.buttonFornecedores.Text = " Fornecedores";
            this.buttonFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFornecedores.UseVisualStyleBackColor = true;
            this.buttonFornecedores.Click += new System.EventHandler(this.buttonFornecedores_Click);
            // 
            // buttonViaturas
            // 
            this.buttonViaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonViaturas.FlatAppearance.BorderSize = 0;
            this.buttonViaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViaturas.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViaturas.Image = global::Garrafeira.Properties.Resources.viaturas;
            this.buttonViaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViaturas.Location = new System.Drawing.Point(0, 300);
            this.buttonViaturas.Name = "buttonViaturas";
            this.buttonViaturas.Size = new System.Drawing.Size(200, 67);
            this.buttonViaturas.TabIndex = 5;
            this.buttonViaturas.Text = " Viaturas";
            this.buttonViaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViaturas.UseVisualStyleBackColor = true;
            this.buttonViaturas.Click += new System.EventHandler(this.buttonViaturas_Click);
            // 
            // buttonEmpregados
            // 
            this.buttonEmpregados.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpregados.FlatAppearance.BorderSize = 0;
            this.buttonEmpregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpregados.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpregados.Image = global::Garrafeira.Properties.Resources.empregados;
            this.buttonEmpregados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpregados.Location = new System.Drawing.Point(0, 233);
            this.buttonEmpregados.Name = "buttonEmpregados";
            this.buttonEmpregados.Size = new System.Drawing.Size(200, 67);
            this.buttonEmpregados.TabIndex = 4;
            this.buttonEmpregados.Text = " Empregados";
            this.buttonEmpregados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmpregados.UseVisualStyleBackColor = true;
            this.buttonEmpregados.Click += new System.EventHandler(this.buttonEmpregados_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.Image = global::Garrafeira.Properties.Resources.clientes;
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 166);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(200, 67);
            this.buttonClientes.TabIndex = 3;
            this.buttonClientes.Text = " Clientes";
            this.buttonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonBebidas
            // 
            this.buttonBebidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBebidas.FlatAppearance.BorderSize = 0;
            this.buttonBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBebidas.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBebidas.Image = global::Garrafeira.Properties.Resources.bebidas;
            this.buttonBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBebidas.Location = new System.Drawing.Point(0, 99);
            this.buttonBebidas.Name = "buttonBebidas";
            this.buttonBebidas.Size = new System.Drawing.Size(200, 67);
            this.buttonBebidas.TabIndex = 2;
            this.buttonBebidas.Text = " Bebidas";
            this.buttonBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBebidas.UseVisualStyleBackColor = true;
            this.buttonBebidas.Click += new System.EventHandler(this.buttonBebidas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garrafeira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Online";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.panelLogo.BackgroundImage = global::Garrafeira.Properties.Resources.logo;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 99);
            this.panelLogo.TabIndex = 1;
            // 
            // Exemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(112)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1147, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideBar);
            this.Name = "Exemplo";
            this.Text = "Exemplo";
            this.panelSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonBebidas;
        private System.Windows.Forms.Button buttonEncomendas;
        private System.Windows.Forms.Button buttonFornecedores;
        private System.Windows.Forms.Button buttonViaturas;
        private System.Windows.Forms.Button buttonEmpregados;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}