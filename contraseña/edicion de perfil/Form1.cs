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

namespace edicion_de_perfil
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string cod = textBox2.Text;
            string Primer_Nombre = textBox1.Text;
            string Usuario = TXTUSUARIO.Text;
            string Correo = TXTCORREO.Text;
            string Contraseña = TXTCONTRASEÑA.Text;
            string cadena = "update Empleado set Primer_Nombre='" + Primer_Nombre + "', Usuario=" + Usuario + "Correo = " + Correo + "Contraseña = " + Contraseña + " where IDEmpleado=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);

            MessageBox.Show("Se modificaron los datos del artículo");
            textBox1.Text = "";
            textBox2.Text = "";
            TXTUSUARIO.Text = "";
            TXTCORREO.Text = "";
            TXTCONTRASEÑA.Text = "";

            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            CONTRASEÑA Nuevaventana2 = new CONTRASEÑA();
            Nuevaventana2.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
