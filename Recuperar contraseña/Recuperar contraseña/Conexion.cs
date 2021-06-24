using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recuperar_contraseña
{
    public class Conexion
    {
        SqlDataAdapter da;
        string conexion = "Data Source = .; Initial Catalog = JKBeauty; Integrated Security = true";

        public SqlConnection sc = new SqlConnection();

        public Conexion()
        {
            sc.ConnectionString = conexion;
        }
        public void abrir()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al abrir la base de datos " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cerrar()
        {
            sc.Close();
        }


        
    }
}
