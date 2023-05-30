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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=LAPTOP-ICOK0BQ9;Initial Catalog=Garrafeira;Integrated Security=True";
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ManagerID = textBox1.Text;
            string Password = textBox2.Text;

            if (validateUser(ManagerID, Password))
            {



                // Abra o formulário principal ou o próximo formulário
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();

            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
                textBox1.Clear();
                textBox2.Clear();

            }

        }

        private bool validateUser(string ManagerID, string Password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Login WHERE ManagerID = @ManagerID AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ManagerID", ManagerID);
                    command.Parameters.AddWithValue("@Password", Password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message);
                    return false;
                }
            }
        }
    }
    }

