﻿
namespace Garrafeira
{
    partial class Clientes
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEncomendas = new System.Windows.Forms.Button();
            this.buttonFornecedores = new System.Windows.Forms.Button();
            this.buttonViaturas = new System.Windows.Forms.Button();
            this.buttonEmpregados = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonBebidas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paypal",
            "Credito"});
            this.comboBox1.Location = new System.Drawing.Point(235, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.Location = new System.Drawing.Point(852, 350);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(116, 60);
            this.buttonAddCliente.TabIndex = 11;
            this.buttonAddCliente.Text = "Adicionar Cliente";
            this.buttonAddCliente.UseVisualStyleBackColor = true;
            this.buttonAddCliente.Click += new System.EventHandler(this.buttonAddCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Morada";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(360, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Metodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "NIF";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 20);
            this.textBox2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.buttonAddCliente);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adicionar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nome";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(200, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 444);
            this.tabControl1.TabIndex = 13;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 12;
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
            this.panelSideBar.Size = new System.Drawing.Size(200, 543);
            this.panelSideBar.TabIndex = 11;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideBar);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEncomendas;
        private System.Windows.Forms.Button buttonFornecedores;
        private System.Windows.Forms.Button buttonViaturas;
        private System.Windows.Forms.Button buttonEmpregados;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonBebidas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSideBar;
    }
}