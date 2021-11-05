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

namespace Acervo_de_Jogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "acervo jogos";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        
            {
            tbNome.Clear();
            tbCategoria.Clear();
            tbPlataforma.Clear();
            tbMidia.Clear();
            tbCondic.Clear();
            tbValor.Clear();
            tbData.Clear();
            tbCod.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaocomBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaocomBD.Open();

                MySqlCommand comandoMySql = realizaConexaocomBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM jogos";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgAcervo.Rows.Clear();

                while (reader.Read()) 
                {
                    DataGridViewRow row = (DataGridViewRow)dgAcervo.Rows[0].Clone();//REPLICA AS LINHAS DA TABELA PRA BAIXO
                    row.Cells[0].Value = reader.GetInt32(0);//CODIGO
                    row.Cells[1].Value = reader.GetString(1);//NOME DO JOGO
                    row.Cells[2].Value = reader.GetString(2);//CATEGORIA
                    row.Cells[3].Value = reader.GetString(3);//PLATAFORMA
                    row.Cells[4].Value = reader.GetString(4);//TIPO DA MIDIA
                    row.Cells[5].Value = reader.GetString(5);//VALOR
                    row.Cells[6].Value = reader.GetString(6);//CONDIÇÃO
                    row.Cells[7].Value = reader.GetDateTime(7).ToString("dd/MM/yyyy"); //DATA DA COMPRA FORMATADA PT-BR
                    
                    dgAcervo.Rows.Add(row);
                }
                realizaConexaocomBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: "+ex.Message);
                Console.WriteLine(ex.Message);
            }
       }

        private void btInserir_Click(object sender, EventArgs e) //Insere os dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacomBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacomBD.Open();

                MySqlCommand comandoMySql = realizaConexacomBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO jogos (NomeJogo,CategoriaJogo,PlataformaJogo,Midia,ValorJogo,CondicaoJogo,DataCompra)" +
                    "VALUES('" + tbNome.Text + "', '" + tbCategoria.Text + "', '" + tbPlataforma.Text + "', '" + tbMidia.Text + "', '" + tbValor.Text + "', '" + tbCondic.Text + "', '" + DateTime.Parse(tbData.Text).ToString("yyyy-MM-dd") + "');";//DateTime.Parse converte a data para o formato americano para inserir no banco de dados sem dar problema

                comandoMySql.ExecuteNonQuery();
                realizaConexacomBD.Close();
                MessageBox.Show("Jogo adicionado com sucesso ! ");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

       
       
        private void dgAcervo_CellContentClick(object sender, DataGridViewCellEventArgs e) //Preencher as caixas de texto com as infos da linha selecionada
        {
            
            if (dgAcervo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
            {
                dgAcervo.CurrentRow.Selected = true;
                tbNome.Text = dgAcervo.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbCategoria.Text = dgAcervo.Rows[e.RowIndex].Cells["colCategoria"].FormattedValue.ToString();
                tbPlataforma.Text = dgAcervo.Rows[e.RowIndex].Cells["colPlataforma"].FormattedValue.ToString();
                tbMidia.Text = dgAcervo.Rows[e.RowIndex].Cells["colMidia"].FormattedValue.ToString();
                tbValor.Text = dgAcervo.Rows[e.RowIndex].Cells["colValor"].FormattedValue.ToString();
                tbCondic.Text = dgAcervo.Rows[e.RowIndex].Cells["colCondicao"].FormattedValue.ToString();
                tbData.Text = dgAcervo.Rows[e.RowIndex].Cells["colData"].FormattedValue.ToString();
                tbCod.Text = dgAcervo.Rows[e.RowIndex].Cells["colCod"].FormattedValue.ToString();
            }
                
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexacomBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacomBD.Open();

                    MySqlCommand comandoMySql = realizaConexacomBD.CreateCommand();

                    comandoMySql.CommandText = "UPDATE jogos SET NomeJogo= '" + tbNome.Text + "', " +
                                                 "CategoriaJogo= '" + tbCategoria.Text + "', " +
                                                 "PlataformaJogo= '" + tbPlataforma.Text + "', " +
                                                 "Midia= '" + tbMidia.Text + "', " +
                                                 "ValorJogo= '" + tbValor.Text + "', " +
                                                 "CondicaoJogo= '" + tbCondic.Text + "', " +
                                                 "DataCompra= '" + DateTime.Parse(tbData.Text).ToString("yyyy-MM-dd") + "'" + //DateTime.Parse converte a data para o formato americano para inserir no banco de dados sem dar problema
                                                 "WHERE Cod = " + tbCod.Text + "";
                    comandoMySql.ExecuteNonQuery();
                    realizaConexacomBD.Close();
                    MessageBox.Show("Atualizado com sucesso ! ");
                    atualizarGrid();
                    limparCampos();

                }
                catch (Exception ex)
                {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);//exibe uma mensagem informando caso ocorra algum erro
                Console.WriteLine(ex.Message);
                }
            }

        private void btDelete_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacomBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacomBD.Open();

                MySqlCommand comandoMySql = realizaConexacomBD.CreateCommand();

                comandoMySql.CommandText = "DELETE FROM jogos WHERE Cod = " + tbCod.Text + "";
                comandoMySql.ExecuteNonQuery();
                realizaConexacomBD.Close();
                MessageBox.Show("Registro excluído ! ");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
