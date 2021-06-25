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
namespace prueba2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-OS3HTSV1\EXPRESS2014;Initial Catalog =JkBeauty;Integrated security=True");
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Registro (string usuario, string primer_nombre, string segundo_apellido, string apellidos, string correo, string contraseña, string confirmar_contraseña)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Primer_Nombre,Segundo_apellido,Apellidos,Correo,Contraseña,Confirmar_contraseña FROM Empleados WHERE Usuario =@Usuario AND Contraseña = @Contrasena", con);
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("Primer_Nombre", primer_nombre);
                cmd.Parameters.AddWithValue("Segundo_apellido", segundo_apellido);
                cmd.Parameters.AddWithValue("Apellidos", apellidos);
                cmd.Parameters.AddWithValue("Correo", correo);
                cmd.Parameters.AddWithValue("Contrasena", contraseña);
                cmd.Parameters.AddWithValue("Confirmar_contraseña", confirmar_contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    // if(dt.Rows[0][])
                }
                else
                {
                    MessageBox.Show("Usuario y/o correo Incorrecta");
                    txtusuario.Text = "";
                    txtprimer_nombre.Text = "";
                    txtsegundo_apellido.Text = "";
                    txtapellidos.Text = "";
                    txtcorreo.Text = "";
                    txtcontraseña.Text = "";
                    txtverificar_contraseña.Text = "";

                    txtusuario.Focus();
                }
            }


            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro(this.txtusuario.Text, this.txtprimer_nombre.Text, this.txtsegundo_apellido.Text, this.txtapellidos.Text, this.txtcorreo.Text, this.txtcontraseña.Text, this.txtverificar_contraseña.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

