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
using System.IO;

namespace Garrafeira
{
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
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
            Empregados opcoes = new Empregados();
            opcoes.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string FornecedorName = textBox2.Text;
            string FornecedorPhone = textBox4.Text;
            string FornecedorNIF = textBox3.Text;
            byte[] imageBytes = null;


            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "jpg files";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;
                imageBytes = File.ReadAllBytes(imagePath);
            }


            if (verifyFornecedor(FornecedorNIF))
            {
                if (insertFornecedores(FornecedorNIF, FornecedorPhone, FornecedorName, imageBytes))
                {
                    SucessoForm sf = new SucessoForm();
                    sf.Show();
                }

            }
            else
            {
                ErrorForm ef = new ErrorForm();
                ef.Show();
            }

        }

        public bool verifyFornecedor(String FornecedorNIF)
        {
            string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Garrafeira;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT NIF FROM Fornecedores WHERE NIF = @FornecedorNIF";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@FornecedorNIF", FornecedorNIF);

                object result = command.ExecuteScalar();

                if (result != null)
                {

                    return false;
                }
                else
                {

                    return true;

                }
            }
        }
        public bool insertFornecedores(String FornecedorNIF, String FornecedorName, String FornecedorPhone, byte[] imageBytes)
        {
            string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Garrafeira;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Fornecedores (Nome,Contacto, NIF,Image) VALUES (@FornecedorName, @FornecedorPhone, @FornecedorNIF,@Imagem)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@FornecedorName", FornecedorName);
                command.Parameters.AddWithValue("@Imagem", imageBytes);
                command.Parameters.AddWithValue("@FornecedorPhone", FornecedorPhone);
                command.Parameters.AddWithValue("@FornecedorNIF", FornecedorNIF);


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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Garrafeira;Integrated Security=True";
            string sql = "SELECT * FROM Fornecedores";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
    }
}