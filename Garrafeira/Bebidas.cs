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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object snender, EventArgs e)
        {
            string ConnectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";
            string sql = "SELECT * FROM bebidas_alcoolicas";

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

        private void button6_Click(object sender, EventArgs e)
        {
            string BebidaBrand = textBox2.Text;
            string BebidaName = textBox3.Text;
            object BebidaType = comboBox1.SelectedItem;
            string BebidaCountry = textBox1.Text;
            string BebidaLitragem = textBox4.Text + comboBox4.SelectedItem;
            string BebidaStock = textBox5.Text;
            string BebidaPrice = textBox6.Text;
            string BebidaAlcool = textBox7.Text;


            if (VerifyBebida(BebidaName))
            {
                if (InsertBebida(BebidaBrand, BebidaName, BebidaType, BebidaCountry, BebidaLitragem, BebidaStock, BebidaPrice, BebidaAlcool))
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
        private bool InsertBebida(string BebidaBrand,string BebidaName,object BebidaType,string BebidaCountry, string BebidaLitragem, string BebidaStock, string BebidaPrice, string BebidaAlcool)
        {
            string ConnectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO bebidas_alcoolicas(marca,nome,tipo,naturalidade,litragem,stock,price,teor) VALUES (@BebidaBrand, @BebidaName, @BebidaType, @BebidaCountry, @BebidaLitragem, @BebidaStock, @BebidaPrice, @BebidaAlcool)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@BebidaBrand", BebidaBrand);
                command.Parameters.AddWithValue("@BebidaName", BebidaName);
                command.Parameters.AddWithValue("@BebidaType", BebidaType);
                command.Parameters.AddWithValue("@BebidaCountry", BebidaCountry);
                command.Parameters.AddWithValue("@BebidaLitragem", BebidaLitragem);
                command.Parameters.AddWithValue("@BebidaStock", BebidaStock);
                command.Parameters.AddWithValue("@BebidaPrice", BebidaPrice);
                command.Parameters.AddWithValue("@BebidaAlcool", BebidaAlcool);

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

        public bool VerifyBebida(string BebidaName)
        {
            string connectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT nome FROM bebidas_alcoolicas WHERE nome = @BebidaName";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@BebidaName", BebidaName);

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

        private void Bebidas_Load(object sender, EventArgs e)
        {
            string sqlEmpregados = "SELECT * FROM bebidas_alcoolicas";
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

