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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        SqlCommand cmd;

        private void bnBuscar_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaCliente Nuevaventana2 = new BusquedaCliente();
            Nuevaventana2.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaProducto ventananueva3 = new BusquedaProducto();
            ventananueva3.Show();
            this.Hide();
        }

        private void elijaUnaOpcionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaEmpleado ventananueva4 = new BusquedaEmpleado();
            ventananueva4.Show();
            this.Hide();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaPedido ventananueva5 = new BusquedaPedido();
            ventananueva5.Show();
            this.Hide();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void proveedortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaProveedor ventananueva6 = new BusquedaProveedor();
            ventananueva6.Show();
            this.Hide();
        }
    }
}
