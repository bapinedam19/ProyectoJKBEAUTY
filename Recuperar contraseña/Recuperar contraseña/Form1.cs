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
using System.Data;
using MiLibreria;

namespace Recuperar_contraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion connect = new Conexion();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("SELECT * FROM Empleados WHERE IDEmpleado='{0}' AND Usuario='{1}'",txt_idempleado.Text.Trim(), txt_nombreUsuario.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                string idempleado = ds.Tables[0].Rows[0]["IDEmpleado"].ToString().Trim();
                string usuario = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                VentanaContraseña ventana = new VentanaContraseña();

                if(idempleado == txt_idempleado.Text.Trim() && usuario == txt_nombreUsuario.Text.Trim())
                {
                    MessageBox.Show("Credenciales correctas!");
                    txt_idempleado.Clear();
                    txt_nombreUsuario.Clear();
                    
                    ventana.Show();
                }
               


            }

            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
                txt_idempleado.Clear();
                txt_nombreUsuario.Clear();

            }



        }
    }
}
