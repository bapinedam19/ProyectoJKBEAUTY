using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace interfazBusqueda
{
    public partial class BusquedaProveedor : Form
    {
        public BusquedaProveedor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int cod_proveedor = 0;
            int tel_propietario = 0;
            string cod = textBox1.Text;
            string tel = textBox4.Text;
            string cadena = "Select nom_proveedor, direccion_proveedor, tel_propietario, correo_proveedor, productos_proveedor from proveedores where cod_proveedor=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.Parameters.AddWithValue("cod_proveedor", cod_proveedor);
            cmd.Parameters.AddWithValue("tel_propietario", tel_propietario);

            SqlDataReader proveedores = cmd.ExecuteReader();

            if (proveedores.Read())
            {
                textBox2.Text = proveedores["nom_proveedor"].ToString();
                textBox3.Text = proveedores["direccion_proveedor"].ToString();
                textBox4.Text = proveedores["tel_propietario"].ToString();
                textBox5.Text = proveedores["correo_proveedor"].ToString();
                textBox6.Text = proveedores["productos_proveedor"].ToString();
                
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Busqueda ventananueva1 = new Busqueda();
            ventananueva1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }
    }
}
