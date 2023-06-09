﻿using System;
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
    public partial class Viaturas : Form
    {
        public Viaturas()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

        private void Viaturas_Load(object sender, EventArgs e)
        {
            FormListaLoad();
        }

        private bool InsertViatura(string ViaturaMatricula, object ViaturaType, string ViaturaDescription)
        {
            string ConnectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Viaturas_Garrafeira(matricula, tipo, descricao) VALUES (@ViaturaMatricula,@ViaturaType, @ViaturaDescription)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ViaturaMatricula", ViaturaMatricula);
                command.Parameters.AddWithValue("@ViaturaType", ViaturaType);
                command.Parameters.AddWithValue("@ViaturaDescription", ViaturaDescription);

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
            string ConnectionString = "Data Source=MOREIRA;Initial Catalog=Projeto;Integrated Security=True";

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
        
        private void FormListaLoad()
        {
            string sqlViaturas = "SELECT * FROM Viaturas_Garrafeira";
            cmd = new SqlCommand(sqlViaturas, connect);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlViaturas, connect);
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            string ViaturaMatricula = textBox2.Text;
            object ViaturaType = comboBox1.SelectedItem;
            string ViaturaDescription = richTextBox1.Text;

            if (VerifyViatura(ViaturaMatricula))
            {
                if (InsertViatura(ViaturaMatricula, ViaturaType, ViaturaDescription))
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
    }
}
