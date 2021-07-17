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

namespace ListadodeProducto
{
    public partial class visualizarProducto : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        
        public visualizarProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.jKBeautyDataSet.Producto);
            try 
            {
                txtEliminar.Visible = false;
                con.Open();
                string cadena = "Select ID_Producto, Id_marca, Nombre_Producto, Existencia, Precio_Actual, Fecha_Vencimiento" + " From Producto";
                SqlDataAdapter adapter = new SqlDataAdapter(cadena, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Update(dt);
                dataGridView1.DataSource = dt;
                txtEliminar.Visible = false;
            }
            catch(Exception ex)
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
          
            txtEliminar.Visible = true;
            int ID_Producto = 0;
            string cod = txtIDProducto.Text;
            SqlCommand command = new SqlCommand("UPDATE Producto Set Nombre_Producto = @Nombre_Producto, Existencia = @Existencia, Precio_Actual = @Precio_Actual, Fecha_Vencimiento = @Fecha_Vencimiento WHERE ID_Producto = @ID", con);
            con.Open();
            //SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@ID", txtIDProducto.Text);
            command.Parameters.AddWithValue("@Nombre_Producto", txtNombreProducto.Text);
            command.Parameters.AddWithValue("@Existencia", txtExistencia.Text);
            command.Parameters.AddWithValue("@Precio_Actual", txtPrecioAc.Text);
            command.Parameters.AddWithValue("@Fecha_Vencimiento", txtFechaVen.Text);
            command.ExecuteNonQuery();
          
            con.Close();
            MessageBox.Show("Actualizado");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtIdmarca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNombreProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtExistencia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrecioAc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFechaVen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnMostsrar_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtEliminar.Visible = true;
            try
            {
                con.Open();
                string actualizar = "SELECT ID_Producto,Id_marca, Nombre_Producto,Existencia,Precio_Actual,Fecha_Vencimiento" + " FROM Producto";
                SqlDataAdapter adapter = new SqlDataAdapter(actualizar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string eliminar = "DELETE  FROM Producto WHERE ID_Producto = @ID";
                SqlCommand command = new SqlCommand(eliminar, con);

                command.Parameters.AddWithValue("@ID", int.Parse(txtIDProducto.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtIDProducto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
