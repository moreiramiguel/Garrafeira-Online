using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garrafeira
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            Clientes clientes = new Clientes();
            clientes.Show();
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
            Viaturas viaturas = new Viaturas();
            viaturas.Show();
        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
        }

        private void buttonEncomendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encomendas Encomendas = new Encomendas();
            Encomendas.Show();
        }
    }
}
