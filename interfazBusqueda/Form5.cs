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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        SqlCommand cmd;


        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //DateTime fecha = new DateTime();
            int Id_Pedido = 0;
            string cod = textBox1.Text;
            string cadena = "Select Estado_pedido, Fecha_envio, Fecha_pedido, Fecha_entrega, Destinario, Direccion from pedido where Id_Pedido=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.Parameters.AddWithValue("Id_Pedido", Id_Pedido);
           

            SqlDataReader Cliente = cmd.ExecuteReader();

            if (Cliente.Read())
            {
                textBox2.Text = Cliente["Estado_pedido"].ToString();
                textBox3.Text = Cliente["Fecha_envio"].ToString();
                textBox4.Text = Cliente["Fecha_pedido"].ToString();
                textBox5.Text = Cliente["Fecha_entrega"].ToString();
                textBox6.Text = Cliente["Destinario"].ToString();
                textBox7.Text = Cliente["Direccion"].ToString();
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ventananueva1 = new Form1();
            ventananueva1.Show();
            this.Hide();
        }
    }
}
