using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sitema2
{
    public partial class Gerenciamento_Cliente : Form
    {
        public Gerenciamento_Cliente()
        {
            InitializeComponent();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
            labelText.Text = "Clientes";


            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            try
            {

                //Cria uma conexão com  banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {

                    //Abre a conexão 
                    consulta.Open();
                    //Cria uam variavel que consulta os dados SQL definidos
                    string listagem = "SELECT * FROM tb_clientes";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao DataGridView
                        dgvClientes.DataSource = dadosClientes;

                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }

        }

        private void buttonFecharClientes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisarCarros_Click(object sender, EventArgs e)
        {
            labelText.Text = "Carros";

            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            try
            {

                //Cria uma conexão com  banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {

                    //Abre a conexão 
                    consulta.Open();
                    //Cria uam variavel que consulta os dados SQL definidos
                    string listagem = "SELECT * FROM tb_carros";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao DataGridView
                        dgvClientes.DataSource = dadosClientes;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }
        }
    }
}
