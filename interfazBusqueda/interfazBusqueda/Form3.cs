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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        SqlCommand cmd;

        private void Form3_Load(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.jKBeautyDataSet.Productos);
        }

        private void aceptarbn2_Click(object sender, EventArgs e)
        {
            con.Open();
            int ID_Producto = 0;
            string cod = textBox1.Text;
            string cadena = "Select Nombre_Producto, Existencia, Precio_Actual, Fecha_Vencimiento from Productos where ID_Producto=" + cod;
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.Parameters.AddWithValue("ID_Producto", ID_Producto);

            SqlDataReader Cliente = cmd.ExecuteReader();

            if (Cliente.Read())
            {
                textBox2.Text = Cliente["Nombre_Producto"].ToString();
                textBox3.Text = Cliente["Existencia"].ToString();
                textBox4.Text = Cliente["Precio_Actual"].ToString();
                textBox5.Text = Cliente["Fecha_Vencimiento"].ToString();
             
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
