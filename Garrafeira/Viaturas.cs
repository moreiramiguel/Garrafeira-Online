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

namespace Garrafeira
{
    public partial class Viaturas : Form
    {
        public Viaturas()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Viaturas_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=Viaturas_Garrafeira;Persist Security Info=True;User Id=p7g9";
            string sql = "SELECT * FROM Viaturas_Garrafeira";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                DataGrid dataGrid = new DataGrid();
                dataGrid.DataSource = dataTable;

                tabPage1.Controls.Add(dataGrid);
                dataGrid.Width = 500;
                dataGrid.Height = 300;


            }
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            string ViaturaMatricula = textBox2.Text;
            string ViaturaType = comboBox1.SelectedText;
            string ViaturaDescription = richTextBox1.Text;

            if (VerifyViatura(ViaturaMatricula))
            {
                if (InsertViatura(ViaturaDescription, ViaturaType, ViaturaDescription))
                {
                    Console.WriteLine("Viatura adicionada com sucesso.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Erro ao adicionar a viatura.");
                }
            }
            Console.ReadLine();
        }

        private bool InsertViatura(string ViaturaMatricula, string ViaturaType, string ViaturaDescription)
        {
            string ConnectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;User ID=p7g9;Password=Ovosmoles123.;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Viaturas_Garrafeira";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Viaturas_Garrafeira(matricula, descricao, viatura_tipo) VALUES (@ViaturaMatricula,@ViaturaDescription, @ViaturaType)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ViaturaMatricula", ViaturaMatricula);
                command.Parameters.AddWithValue("@ViaturaDescription", ViaturaDescription);
                command.Parameters.AddWithValue("@ViaturaType", ViaturaType);

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

        private bool VerifyViatura(string ViaturaMatricula)
        {
            string ConnectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;User ID=p7g9;Password=Ovosmoles123.;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Viaturas_Garrafeira";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT matricula FROM Viaturas_Garrafeira WHERE matricula = @ViaturaMatricula";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ViaturaMatricula", ViaturaMatricula);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Console.WriteLine("A viatura já se encontra registada na base de dados.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Viatura adicionada com sucesso.");
                    return true;
                }
            }
        }
    }
}
