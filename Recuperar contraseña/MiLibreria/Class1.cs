using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=JKBeauty;Integrated Security=True");
            Con.Open();

            DataSet Ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, Con);
            dp.Fill(Ds);

            Con.Close();
            return Ds;
        }


    }
}
