using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Sql Server CE
using System.Data.SqlServerCe;

//SQLite
using System.Data.SQLite;
//using System.Data.SqlClient;

//MySQL
using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            /*
            string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234567'";
            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }

            db.Dispose();//fecha o banco de dados

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();
                labelResultado.Text = "Conectado SQL Server CE\n";


            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar o SQL Server CE\n" + ex;
            }
            finally
            {
                conexao.Close();//fecha a conexão com o bd
            }*/
            #endregion

            #region SQLite
            /*
            string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
            }

            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try
            {
                conexao.Open();
                labelResultado.Text = "Conectado SQLite\n";


            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar o SQLite\n" + ex;
            }
            finally
            {
                conexao.Close();//fecha a conexão com o bd
            }

            */
            #endregion

            #region MySQL
            //string conexao1 = "server=127.0.0.1;User Id=developer;password=1234567";
            /*string conexao2 = "server=localhost; User Id=developer; database=curso_db; password=1234567";
            MySqlConnection conexao = new MySqlConnection(conexao2);


            try
            {
                conexao.Open();
                labelResultado.Text = "Conectado com o MySQL\n";

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_teste";

                comando.ExecuteNonQuery();
                labelResultado.Text = "Comando SQL executado com sucesso!\n";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar com o MySQL\n" + ex;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {

            #region SQLServer CE
            /*
            string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234567'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Tabela pessoas criada SQL Server CE";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar o SQL Server CE\n" + ex.Message;

            }
            finally
            {
                conexao.Close();
            }*/
            #endregion
            #region SQLite
            /*
            string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Tabela pessoas criada SQLite";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar o SQLite\n" + ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            */
            #endregion
            #region MySql  
            string strConnection = "server=localhost; User Id=developer; database=curso_teste; password=1234567";

            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY (id))";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Tabela pessoas criada MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SqlServer CE

            //string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
            //string strConnection = @"DataSource = " + baseDados + "; Password = '1234567'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;
            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";
            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Inserido dados na tabela pessoas SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //    txtEmail.Text = "";
            //    txtNome.Text = "";
            //}
            #endregion
            #region SQLite

            //string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            //string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";
            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Inserido dados na tabela pessoas SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //    txtEmail.Text = "";
            //    txtNome.Text = "";
            //}
            #endregion
            #region MySQL

            //string strConnection = "server=localhost; User Id=developer; database=curso_teste; password=1234567";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";
            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Inserido dados na tabela pessoas MySql";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            lista.Rows.Clear();

            #region SQLServer CE
            //string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
            //string strConnection = @"DataSource = " + baseDados + "; Password = '1234567'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";


            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
            //    }

            //    DataTable dados = new DataTable();

            //    SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConnection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }


            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //    lista.Rows.Clear();

            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            //string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";


            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
            //    }

            //    DataTable dados = new DataTable();

            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConnection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }


            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //    lista.Rows.Clear();

            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql
            string strConnection = "server=localhost; User Id=developer; database=curso_teste; password=1234567";

            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                string query = "SELECT * FROM pessoas";


                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }


            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
                lista.Rows.Clear();

            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SqlServer CE

            //string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
            //string strConnection = @"DataSource = " + baseDados + "; Password = '1234567'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Deletado o registro na tabela pessoas SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //    txtEmail.Text = "";
            //    txtNome.Text = "";
            //}
            #endregion
            #region SQLite

            //string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            //string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";

            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Removendo dados na tabela pessoas SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //    txtEmail.Text = "";
            //    txtNome.Text = "";
            //}
            #endregion
            #region MySQL

            //string strConnection = "server=localhost; User Id=developer; database=curso_teste; password=1234567";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";

            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Removendo dados na tabela pessoas MySql";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region SqlServer CE

            //string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
            //string strConnection = @"DataSource = " + baseDados + "; Password = '1234567'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

            //    comando.CommandText = query;
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Atualizado o registro na tabela pessoas SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //    txtEmail.Text = "";
            //    txtNome.Text = "";
            //}
            #endregion
            #region SQLite

            //string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            //string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

            //    comando.CommandText = query;

            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Atualizando dados na tabela pessoas SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //    txtEmail.Text = "";
            //    txtNome.Text = "";
            //}
            #endregion
            #region MySQL

            string strConnection = "server=localhost; User Id=developer; database=curso_teste; password=1234567";

            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                string nome = txtNome.Text;
                string email = txtEmail.Text;

                string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

                comando.CommandText = query;

                comando.ExecuteNonQuery();
                labelResultado.Text = "Atualizando dados na tabela pessoas MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
