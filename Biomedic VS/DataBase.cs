using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Biomedic_VS
{

    class Conexion
    {
        private static Conexion_Instancia instancia = null;
        public static SQLiteConnection instanciaDb()
        {
            if (instancia == null)
            {
                instancia = new Conexion_Instancia();
            }
            return instancia.con;
        }
    }
    class Conexion_Instancia
    {
        public SQLiteConnection con = null;
        public Conexion_Instancia()
        {
            con = new SQLiteConnection("Data Source=database.sqlite3");
            con.Open();
        }
        ~Conexion_Instancia()
        {
            //con.Close();
        }
    }
}
