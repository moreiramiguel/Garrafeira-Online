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
    public partial class Clientes : Form
    {
        private object dataGridView1;

        public Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ClientName = textBox2.Text;
            string ClientEmail = textBox1.Text;
            string ClientPhone = textBox4.Text;
            string ClientNIF = textBox3.Text;
            string ClientAddress = textBox5.Text;

            if (VerifyClient(ClientNIF))
            {
                if (InsertClient(ClientName, ClientEmail, ClientPhone, ClientNIF, ClientAddress))
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

        private bool InsertClient(string clientName, string clientEmail, string clientPhone, string clientNIF, string clientAddress)
        {
            string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Clients;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Clients (Name, Email, Phone, NIF, Adress) VALUES (@clientName, @clientEmail, @clientPhone, @clientNIF, @clientAddress)";
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
            string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Clients;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT NIF FROM Clients WHERE NIF = @clientNIF";
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Clients;Integrated Security=True";
            string sql = "SELECT * FROM Clients";

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