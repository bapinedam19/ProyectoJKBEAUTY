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
    public partial class BusquedaPedido : Form
    {
        public BusquedaPedido()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
       
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int Id_Pedido = 0;
            string cod = textBox1.Text;
            string cadena = "Select Estado_pedido, Fecha_envio, Fecha_pedido, Fecha_entrega, Destinatario, Direccion from pedido where Id_Pedido=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.Parameters.AddWithValue("Id_Pedido", Id_Pedido);

            SqlDataReader pedido = cmd.ExecuteReader();

            if (pedido.Read())
            {
                textBox2.Text = pedido["Estado_pedido"].ToString();
                textBox3.Text = pedido["Fecha_envio"].ToString();
                textBox4.Text = pedido["Fecha_pedido"].ToString();
                textBox5.Text = pedido["Fecha_entrega"].ToString();
                textBox6.Text = pedido["Destinatario"].ToString();
                textBox7.Text = pedido["Direccion"].ToString();
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
            textBox7.Clear();
            textBox1.Focus();
        }
    }
}
