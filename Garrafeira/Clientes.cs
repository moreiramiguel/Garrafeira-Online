using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//"Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";
//"Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Garrafeira;Integrated Security=True";

namespace Garrafeira
{
    public partial class Clientes : Form
    {
        private object dataGridView1;

        public Clientes()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

        private void Clientes_Load(object sender, EventArgs e)
        {
            FormListLoad();
        }
     

        private bool InsertClient(string clientName, string clientEmail, object clientPhone, string clientNIF, string clientAddress)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Clientes_garrafeira (nome, mail, metodo, NIF, morada) VALUES (@clientName, @clientEmail, @clientPhone, @clientNIF, @clientAddress)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@clientName", clientName);
                command.Parameters.AddWithValue("@clientEmail", clientEmail);
                command.Parameters.AddWithValue("@clientPhone", clientPhone);
                command.Parameters.AddWithValue("@clientNIF", clientNIF);
                command.Parameters.AddWithValue("@clientAddress", clientAddress);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            }

        private bool VerifyClient(string clientNIF)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT NIF FROM Clientes_garrafeira WHERE NIF = @clientNIF";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@clientNIF", clientNIF);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Console.WriteLine("O Client já se encontra na Base de Dados");
                    return false;
                }
                else
                {
                    Console.WriteLine("Cliente adicionado");
                    return true;
                }
            }
        }
        private void FormListLoad()
        {

            string sqlClientes = "SELECT * FROM Clientes_garrafeira";
            cmd = new SqlCommand(sqlClientes, connect);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlClientes, connect);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);

            DataGrid dataGrid = new DataGrid();
            dataGrid.DataSource = dataTable;

            tabPage1.Controls.Add(dataGrid);
            dataGrid.Width = 994;
            dataGrid.Height = 543;
        }

        private void buttonBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas Bebidas = new Bebidas();
            Bebidas.Show();
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

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            string ClientName = textBox2.Text;
            string ClientEmail = textBox1.Text;
            object ClientPhone = comboBox1.SelectedItem;
            string ClientNIF = textBox3.Text;
            string ClientAddress = textBox5.Text;

            if (VerifyClient(ClientNIF))
            {
                if (InsertClient(ClientName, ClientEmail, ClientPhone, ClientNIF, ClientAddress))
                {
                    SucessoForm sf = new SucessoForm();
                    sf.Show();
                }
                else
                {
                    ErrorForm ef = new ErrorForm();
                    ef.Show();
                }
            }
            Console.ReadLine();
        }
    }
}