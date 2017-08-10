using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLiteConnection con;
            con = new SQLiteConnection("Data Source=" + Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\" + "teste.sqlite;Version=3");
            con.Open();
            banco(con);
            bancoTeste(con);
        }

        public void banco(SQLiteConnection con)
        {
            String sql = "CREATE TABLE IF NOT EXISTS Clientes (iD int NOT NULL PRIMARY KEY, nome varchar(50), endereço varchar(50), telefone int(11), confiabilidade varchar(20), metPag varchar(30), ultimosPed varchar(20), itensFiado varchar(20));";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void bancoTeste(SQLiteConnection con)
        {
            String sql = "insert into Clientes values (1, 'teste', 'aaaa', 123456, 'alto', 'bacb', 'adf', 'asdf');";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        private void btAdmClientes_Click(object sender, EventArgs e)
        {
            Clientes panel = new Clientes();
            panel1.BackColor = panel.panel2.BackColor;
            btAdmClientes.Text = panel.teste;
        }

        private void btAdmVendas_Click(object sender, EventArgs e)
        {
            Vendas panel = new Vendas();
            panel1.BackColor = panel.panel2.BackColor;
        }

        private void btAdmProdutos_Click(object sender, EventArgs e)
        {
            Produtos panel = new Produtos();
            panel1.BackColor = panel.panel2.BackColor;
        }
    }
}
