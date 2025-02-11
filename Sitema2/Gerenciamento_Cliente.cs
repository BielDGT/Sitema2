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

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                //Pega ID do cliente da linha selecionada.
                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_Cliente"].Value);

                DialogResult result = MessageBox.Show("Are you sure?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {

                        //Cria uma conexão com  banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {

                            //Abre a conexão 
                            consulta.Open();
                            //Consulta os dados SQL definidos para selecionar o cliente
                            string listagem = "DELETE FROM tb_clientes WHERE Id_Cliente = @Id_Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Cliente", clienteID);

                                int rowAffected = cmd.ExecuteNonQuery();

                                if (rowAffected > 0)
                                {
                                    MessageBox.Show("Cliente Excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir!!!");
                                }
                            }
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " +  ex.Message);
                    }
                    
                }

            }
            else 
            {
                MessageBox.Show("Please, select some thing!!!");
            }

        }

        private void buttonRemoverCarro_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                //Pega ID do cliente da linha selecionada.
                int carroID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {

                        //Cria uma conexão com  banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {

                            //Abre a conexão 
                            consulta.Open();
                            //Consulta os dados SQL definidos para selecionar o cliente
                            string listagem = "DELETE FROM tb_carros WHERE Id = @Id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id", carroID);

                                int rowAffected = cmd.ExecuteNonQuery();

                                if (rowAffected > 0)
                                {
                                    MessageBox.Show("Cliente Excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir!!!");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                }

            }
            else
            {
                MessageBox.Show("Please, select some thing!!!");
            }
        }
    }
}
