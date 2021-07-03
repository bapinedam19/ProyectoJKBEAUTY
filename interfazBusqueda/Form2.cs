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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        SqlCommand cmd;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.table_ClienteTableAdapter.Fill(this.jKBeautyDataSet.Table_Cliente);

        }

        private void aceptarbn_Click(object sender, EventArgs e)
        {
            con.Open();
            int Id_cliente = 0;
            string cod = textBox7.Text;
            string cadena = "Select Primer_Nombre, Segundo_Nombre, Primer_Apellido, Direccion, Telefono, Correo from Table_Cliente where Id_cliente=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.Parameters.AddWithValue("Id_cliente", Id_cliente);

            SqlDataReader Cliente = cmd.ExecuteReader();

            if (Cliente.Read())
            {
                textBox1.Text = Cliente["Primer_Nombre"].ToString();
                textBox2.Text = Cliente["Segundo_Nombre"].ToString();
                textBox3.Text = Cliente["Primer_Apellido"].ToString();
                textBox4.Text = Cliente["Direccion"].ToString();
                textBox5.Text = Cliente["Telefono"].ToString();
                textBox6.Text = Cliente["Correo"].ToString();
            }

            con.Close();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventananueva1 = new Form1();
            ventananueva1.Show();
            this.Hide();
        }
    }
}
