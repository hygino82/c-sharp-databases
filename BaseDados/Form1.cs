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
            /*string baseDados = Application.StartupPath + "\\db\\DBSQLServer.sdf";
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


            #endregion
        }
    }
}
