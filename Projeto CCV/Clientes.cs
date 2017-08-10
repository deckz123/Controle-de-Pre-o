using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CCV
{
    class Clientes
    {
        public Panel panel2 = new Panel();
        public String teste = "";
        public Clientes()
        {
            teste = Busca();
            panel2.BackColor = System.Drawing.Color.Yellow;
        }

        private SQLiteConnection con = new SQLiteConnection("Data Source=" + Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\" + "teste.sqlite;Version=3");

        public String Busca()
        {
            con.Open();
            string sql = "select nome from Clientes";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader r = command.ExecuteReader();
            String n = "";
            while (r.Read())
            {
                n = (String)r["nome"];
                con.Close();
                return n;
            }
            con.Close();
            return n;
        }

    }
}
