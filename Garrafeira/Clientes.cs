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
            SqlConnection con = new SqlConnection("Data Source=MOREIRA;Initial Catalog=GarrafeiraOnline;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("exibirClientes", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
            int NIF = int.Parse(textBox3.Text);
            string Nome = textBox2.Text;
            string Mail = textBox3.Text; 
            object Metodo = comboBox1.SelectedItem;
            string Morada = textBox5.Text;
            /*
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
            */
            if(InserirCliente(NIF, Nome, Mail, Metodo, Morada) >= 0)
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

        private int InserirCliente(int NIF, string Nome, string Mail, object Metodo, string Morada)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=GarrafeiraOnline;Integrated Security=True";
            int id = 0;
            try
            {
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "go_InserirCliente";
                    command.Parameters.AddWithValue("@NIF", NIF);
                    command.Parameters.AddWithValue("@Nome", Nome);
                    command.Parameters.AddWithValue("@Mail", Mail);
                    command.Parameters.AddWithValue("@Metodo", Metodo);
                    command.Parameters.AddWithValue("@Morada", Morada);

                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao inserir\n\n" + ex.Message);
            }
            return id;
        }
        
    }
}