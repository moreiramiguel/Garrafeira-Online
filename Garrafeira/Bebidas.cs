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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object snender, EventArgs e)
        {
            string ConnectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=bebidas_alcoolicas;Persist Security Info=True;User Id=p7g9";
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
            float BebidaLitragem = numericUpDown1.DecimalPlaces;
            int BebidaStock = numericUpDown3.DecimalPlaces;
            float BebidaPrice = numericUpDown4.DecimalPlaces;
            float BebidaAlcool = numericUpDown2.DecimalPlaces;


            if (VerifyBebida(BebidaName))
            {
                if (InsertBebida(BebidaBrand, BebidaName, BebidaType, BebidaCountry, BebidaLitragem, BebidaStock, BebidaPrice, BebidaAlcool))
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
        private bool InsertBebida(string BebidaBrand,string BebidaName,object BebidaType,string BebidaCountry,float BebidaLitragem,int BebidaStock, float BebidaPrice, float BebidaAlcool)
        {
            string ConnectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;User ID=p7g9;Password=Ovosmoles123.;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Viaturas_Garrafeira";

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
    }
  }

