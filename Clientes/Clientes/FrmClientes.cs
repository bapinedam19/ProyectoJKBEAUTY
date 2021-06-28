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
using System.Activities.Expressions;

namespace Clientes
{
    public partial class FrmClientes : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog =JkBeauty;Integrated security=True");
        public FrmClientes()
        {
            InitializeComponent();
            BMTB_ID.Focus();
        }

        private void bfb_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Table_Cliente(Id_Cliente,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Direccion,Telefono,Correo) VALUES(@Id,@PrNombre,@SgNombre,@PrApellido,@Direccion,@Telefono,@Correo)";
                con.Open();
                SqlCommand comand = new SqlCommand(query, con);
                comand.Parameters.AddWithValue("@Id", BMTB_ID.Text);
                comand.Parameters.AddWithValue("@PrNombre", BMTB_PrNombre.Text);
                comand.Parameters.AddWithValue("@SgNombre", BMTB_SgNombre.Text);
                comand.Parameters.AddWithValue("@PrApellido", BMTB_PrApellido.Text);
                comand.Parameters.AddWithValue("@Direccion", BMTB_Direccion.Text);
                comand.Parameters.AddWithValue("@Telefono", BMTB_Telefono.Text);
                comand.Parameters.AddWithValue("@Correo", BMTB_Correo.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Clientes Agregados Corecctamente");

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

        private void bfb_limpiar_Click(object sender, EventArgs e)
        {
            try
            {
                BMTB_ID.Text = "";
                BMTB_PrNombre.Text = "";
                BMTB_SgNombre.Text = "";
                BMTB_PrApellido.Text = "";
                BMTB_Direccion.Text = "";
                BMTB_Telefono.Text = "";
                BMTB_Correo.Text = "";

                BMTB_ID.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
