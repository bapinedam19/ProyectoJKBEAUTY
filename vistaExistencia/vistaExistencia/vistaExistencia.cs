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

namespace vistaExistencia
{
    public partial class vistaExistencia : Form
    {
        public vistaExistencia()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");

        private void VisExisGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jKBeautyDataSet.Existencias' Puede moverla o quitarla según sea necesario.
            //this.existenciasTableAdapter.Fill(this.jKBeautyDataSet.Existencias);
            try
            {
                btnEliminar.Visible = false;
                con.Open();
                string cadena = "Select ID_Producto, cantidad_existencias, cantidad_bodega, cantidad_tienda" + " From Existencias";
                SqlDataAdapter adapter = new SqlDataAdapter(cadena, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Update(dt);
                visExisGridview.DataSource = dt;
                btnEliminar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
            int Id_existencias = 0;

            string cod = txtIdexistencias.Text;
            SqlCommand command = new SqlCommand("UPDATE Existencias Set ID_Producto = @Idproducto, cantidad_existencia = @cantExis, cantidad_bodega = @cantBodega, cantidad_tienda = @cantTienda WHERE Id_existencias = @ID", con);
            con.Open();
            //SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@ID", txtIdexistencias.Text);
            command.Parameters.AddWithValue("@Idproducto", txtID_Produc.Text);
            command.Parameters.AddWithValue("@cantExis", txtcanExis.Text);
            command.Parameters.AddWithValue("@cantBodega", txtCantBodega.Text);
            command.Parameters.AddWithValue("@cantTienda", txtcantTienda.Text);
            command.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Actualizado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
            try
            {
                con.Open();
                string actualizar = "SELECT Id_existencias, ID_Producto,cantidad_existencias, cantidad_bodega, cantidad_tienda" + " FROM Existencias";
                SqlDataAdapter adapter = new SqlDataAdapter(actualizar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                visExisGridview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
