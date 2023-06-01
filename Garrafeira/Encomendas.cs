using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//"Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";
//"Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Garrafeira;Integrated Security=True";

namespace Garrafeira
{
    public partial class Encomendas : Form
    {
        public Encomendas()
        {
            InitializeComponent();
        
        }

        private void buttonBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes Clientes = new Clientes();
            Clientes.Show();
        }

        private void buttonEmpregados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empregados Empregados = new Empregados();
            Empregados.Show();
        }

        private void buttonViaturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Viaturas Viaturas = new Viaturas();
            Viaturas.Show();
        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fornecedores Fornecedores = new Fornecedores();
            Fornecedores.Show();
        }

        private void buttonEncomendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encomendas Encomendas = new Encomendas();
            Encomendas.Show();
        }
    }
}