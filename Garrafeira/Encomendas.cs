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
    public partial class Encomendas : Form
    {
        public Encomendas()
        {
            InitializeComponent();
        
        }

        SqlConnection connect = new SqlConnection("Data Source=MOREIRA;Initial Catalog=GarrafeiraOnline;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;


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
        private void FormListLoad()
        {

            string connectionString = "Data Source=MOREIRA;Initial Catalog=GarrafeiraOnline;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Encomendas";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Width = 400;
                dataGridView1.Height = 200;
            }
        }

        private void Encomendas_Load(object sender, EventArgs e)
        {
            FormListLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Numero"].Value);

            int Motorista_NIF = Convert.ToInt32(comboBox1.SelectedItem);

            string connectionString = "Data Source=MOREIRA;Initial Catalog=GarrafeiraOnline;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Encomendas SET Motorista_NIF = @Motorista_NIF WHERE Numero = @Numero";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Motorista_NIF", Motorista_NIF);
                command.Parameters.AddWithValue("@Numero", Numero);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Motorista associada à encomenda com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao associar Motorista à encomenda.");
                }
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("SELECT NIF FROM Empregados", connect))
            {
                connect.Open();
                command.Parameters.AddWithValue("@NIF", comboBox1.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["Nome"]);
                    motoristaNIF.Text = dr[0].ToString();
                }
                connect.Close();
            }
        }
    }
}