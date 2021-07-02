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

namespace Marcas
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog =JkBeauty;Integrated security=True");

        private void existe(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id_marca FROM Marca WHERE id = @IDmarca", con);
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("IDmarca", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("ID existente", "Advertencia", MessageBoxButtons.OK);
                }
                else
                {
                    if (bmtb_ID.Text != "")
                    {
                        if (bmtb_Marca.Text != "")
                        {
                            if (bmt_descrpcion.Text != "")
                            {
                                if (bmt_proveedor.Text != "")
                                {
                                    string query = "INSERT INTO Marca (Id_marca,Descripcion,Nombre_marca,cod_proveedor) VALUES (@IDMarca,@Descrip,@Nombre,@Cproveedor)";
                                    SqlCommand comand = new SqlCommand(query, con);
                                    comand.Parameters.AddWithValue("@IDMarca", Convert.ToInt32(bmtb_ID.Text));
                                    comand.Parameters.AddWithValue("@Descrip", bmt_descrpcion.Text);
                                    comand.Parameters.AddWithValue("@Nombre", bmtb_Marca.Text);
                                    comand.Parameters.AddWithValue("@Cproveedor", Convert.ToInt32(bmt_proveedor.Text));
                                }
                                else
                                {
                                    MessageBox.Show("El codigo del proveedor esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Descripcion esta Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Marca esta Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

        private void bmtb_Marca_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bfb_Agregar_Click(object sender, EventArgs e)
        {
            existe(Convert.ToInt32(bmtb_ID));
        }

        private void bfb_limpiar_Click(object sender, EventArgs e)
        {
            bmtb_ID.Text = "";
            bmt_descrpcion.Text = "";
            bmtb_Marca.Text = "";
            bmt_proveedor.Text = "";
        }
    }
}
