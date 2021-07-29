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

namespace edicion_de_perfil
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True");
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvpruebaEmpleado.Visible = false;
            this.empleadosTableAdapter.Fill(this.jKBeautyDataSet.Empleados);
            /*con.Open();
            string cadena = "Select IDEmpleado, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Usuario, Contraseña" + " From Empleados";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
             dgvpruebaEmpleado.DataSource = dt;

            con.Close();*/
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string cod = txtID.Text;
            SqlCommand command = new SqlCommand("UPDATE Empleados Set Primer_Nombre = @name1, Segundo_Nombre = @name2, Primer_Apellido = @lastname, Usuario = @user, Contraseña = @contra WHERE IDEmpleado = @ID", con);
            //SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@user", txtUser.Text);
            command.Parameters.AddWithValue("@name1", txtFirstName.Text);
            command.Parameters.AddWithValue("@name2", txtSecName.Text);
            command.Parameters.AddWithValue("@lastname", txtLastName.Text);
            command.Parameters.AddWithValue("@contra", txtAcContra.Text);
            
            command.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Actualizado");
            ;
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            txtNuevaContra.Visible = false;
            txtConfirContra.Visible = false;
            lbConfirContra.Visible = false;
            lbNuevaContra.Visible = false;
            SqlCommand cmd = new SqlCommand ("Select * From Empleados Where IDEmpleado=@Id",con);
            cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            con.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["Usuario"].ToString();
                textBox3.Text = registro["Primer_Nombre"].ToString();
                textBox4.Text = registro["Segundo_Nombre"].ToString();
                textBox5.Text = registro["Primer_Apellido"].ToString();
                textBox6.Text = registro["Contraseña"].ToString();
                txtID.Text = registro["IDEmpleado"].ToString();
                txtUser.Text = registro["Usuario"].ToString();
                txtFirstName.Text = registro["Primer_Nombre"].ToString();
                txtSecName.Text = registro["Segundo_Nombre"].ToString();
                txtLastName.Text = registro["Primer_Apellido"].ToString();
                txtAcContra.Text = registro["Contraseña"].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNuevaContra.Visible = true;
            txtConfirContra.Visible = true;
            lbConfirContra.Visible = true;
            lbNuevaContra.Visible = true;
            
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            /*if (textBox1.Text == dgvpruebaEmpleado.CurrentRow.Cells[0].Value.ToString())
            {*/
                /*if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    textBox1.Text = dgvpruebaEmpleado.CurrentRow.Cells[0].Value.ToString();
                    textBox2.Text = dgvpruebaEmpleado.CurrentRow.Cells[1].Value.ToString();
                    textBox3.Text = dgvpruebaEmpleado.CurrentRow.Cells[2].Value.ToString();
                    textBox4.Text = dgvpruebaEmpleado.CurrentRow.Cells[3].Value.ToString();
                    textBox5.Text = dgvpruebaEmpleado.CurrentRow.Cells[4].Value.ToString();
                    textBox6.Text = dgvpruebaEmpleado.CurrentRow.Cells[5].Value.ToString();

                    txtID.Text = dgvpruebaEmpleado.CurrentRow.Cells[0].Value.ToString();
                    txtFirstName.Text = dgvpruebaEmpleado.CurrentRow.Cells[1].Value.ToString();
                    txtSecName.Text = dgvpruebaEmpleado.CurrentRow.Cells[2].Value.ToString();
                    txtLastName.Text = dgvpruebaEmpleado.CurrentRow.Cells[3].Value.ToString();
                    txtUser.Text = dgvpruebaEmpleado.CurrentRow.Cells[4].Value.ToString();
                    txtAcContra.Text = dgvpruebaEmpleado.CurrentRow.Cells[5].Value.ToString();
                }*/
                
            //}

        }
    }
}
   
