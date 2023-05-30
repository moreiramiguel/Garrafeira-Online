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
    public partial class Opçoes : Form
    {
<<<<<<< Updated upstream:Garrafeira/Opçoes.cs
        public Opçoes()
=======
        SqlConnection connect = new SqlConnection("Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        public Empregados()
>>>>>>> Stashed changes:Garrafeira/Empregados.cs
        {
            InitializeComponent();
        }

        private void Empregados_Load(object sender, EventArgs e)
        {
            string sqlEmpregados = "SELECT * FROM Empregados";
            cmd = new SqlCommand(sqlEmpregados, connect);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlEmpregados, connect);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);

            DataGrid dataGrid = new DataGrid();
            dataGrid.DataSource = dataTable;

            tabPage1.Controls.Add(dataGrid);
            dataGrid.Width = 994;
            dataGrid.Height = 543;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Viaturas viaturas = new Viaturas();
            viaturas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opçoes opcoes = new Opçoes();
            opcoes.Show();
        }
<<<<<<< Updated upstream:Garrafeira/Opçoes.cs
=======

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encomendas encomendas = new Encomendas();
            encomendas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string EmpregadoNome = textBox2.Text;
            string EmpregadoNIF = textBox3.Text;
            string EmpregadoPhone = textBox4.Text;
            string EmpregadoSalario = textBox1.Text;
            object EmpregadoCargo = comboBox1.SelectedItem;

            if (VerifyEmpregado(EmpregadoNIF))
            {
                if (InsertEmpregado(EmpregadoNome, EmpregadoNIF, EmpregadoPhone, EmpregadoCargo, EmpregadoSalario))
                {
                    Console.WriteLine("Cliente adicionado com sucesso.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Erro ao adicionar cliente.");
                }
            }
            Console.ReadLine();
        }

        private bool InsertEmpregado(string EmpregadoNome, string EmpregadoNIF, string EmpregadoPhone, object EmpregadoCargo, string EmpregadoSalario)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Empregados (nome,NIF,telefone,salario,cargo) VALUES (@EmpregadoNome, @EmpregadoNIF, @EmpregadoPhone, @EmpregadoSalario, @EmpregadoCargo)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@EmpregadoNome", EmpregadoNome);
                command.Parameters.AddWithValue("@EmpregadoNIF", EmpregadoNIF);
                command.Parameters.AddWithValue("@EmpregadoPhone", EmpregadoPhone);
                command.Parameters.AddWithValue("@EmpregadoSalario", EmpregadoSalario);
                command.Parameters.AddWithValue("@EmpregadoCargo", EmpregadoCargo);

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

        private bool VerifyEmpregado(string EmpregadoNIF)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT NIF FROM Empregados WHERE NIF = @EmpregadoNIF";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@EmpregadoNIF", EmpregadoNIF);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Console.WriteLine("O Empregado já se encontra na Base de Dados");
                    return false;
                }
                else
                {
                    Console.WriteLine("Empregado adicionado");
                    return true;
                }
            }
        }
>>>>>>> Stashed changes:Garrafeira/Empregados.cs
    }
}
