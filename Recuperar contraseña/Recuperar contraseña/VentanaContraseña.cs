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
    public partial class VentanaContraseña : Form
    {
        public VentanaContraseña()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaContraseña_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jKBeautyDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.jKBeautyDataSet.Empleados);
            conexion.abrir();
        }
        public SqlConnection sc = new SqlConnection();
        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.ModificarEmpleados(iDEmpleadoTextBox.Text, primer_NombreTextBox.Text, segundo_NombreTextBox.Text, primer_ApellidoTextBox.Text, usuarioTextBox.Text, contraseñaTextBox.Text, iDEmpleadoTextBox.Text);
            this.empleadosTableAdapter.Fill(this.jKBeautyDataSet.Empleados);
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jKBeautyDataSet);

        }
    }
}
