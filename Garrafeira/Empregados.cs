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
    public partial class Empregados : Form
    { 

        public Empregados()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

        private void Empregados_Load(object sender, EventArgs e)
        {
            FormListLoad();
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
            Empregados empregados = new Empregados();
            empregados.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encomendas encomendas = new Encomendas();
            encomendas.Show();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string EmpregadoNome = textBox2.Text;
            string EmpregadoPhone = textBox5.Text;
            string EmpregadoNIF = textBox3.Text;
            string EmpregadoSalario = textBox4.Text;
            object EmpregadoCargo = comboBox1.Text;

            if (VerifyEmpregado(EmpregadoNIF))
            {
                if (InsertEmpregado(EmpregadoNome, EmpregadoNIF, EmpregadoPhone, EmpregadoSalario, EmpregadoCargo))
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
        private bool InsertEmpregado(string EmpregadoNome, string EmpregadoNIF, string EmpregadoPhone, string EmpregadoSalario, object EmpregadoCargo)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Empregados (nome, NIF, telefone, salario, cargo) VALUES (@EmpregadoNome, @EmpregadoNIF, @EmpregadoPhone, @EmpregadoSalario, @EmpregadoCargo)";
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


    }
}
