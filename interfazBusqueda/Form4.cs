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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        SqlCommand cmd;

        private void botonaceptar_Click(object sender, EventArgs e)
        {
            con.Open();
            int IDEmpleado = 0;
            int Contraseña = 0;
            string cod = textBox1.Text;
            string cadena = "Select Primer_Nombre, Segundo_Nombre, Primer_Apellido, Usuario, Contraseña from Empleados where IDEmpleado=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.Parameters.AddWithValue("IDEmpleado", IDEmpleado);
            cmd.Parameters.AddWithValue("Contraseña", Contraseña);


            SqlDataReader Cliente = cmd.ExecuteReader();

            if (Cliente.Read())
            {
                textBox2.Text = Cliente["Primer_Nombre"].ToString();
                textBox3.Text = Cliente["Segundo_Nombre"].ToString();
                textBox4.Text = Cliente["Primer_Apellido"].ToString();
                textBox5.Text = Cliente["Usuario"].ToString();
                textBox6.Text = Cliente["Contraseña"].ToString();
                
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventananueva1 = new Form1();
            ventananueva1.Show();
            this.Hide();
        }
    }
}
