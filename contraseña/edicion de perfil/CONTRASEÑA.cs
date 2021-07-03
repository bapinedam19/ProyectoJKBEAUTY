using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace edicion_de_perfil
{
    public partial class CONTRASEÑA : Form
    {
        static DirectoryEntry srvLDAPActiveDirectory;
        public CONTRASEÑA()
        {
            InitializeComponent();
        }

        SqlCommand cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-BJMBD4J6;Initial Catalog =JkBeauty;Integrated security=True"))
            {
                cn.Open();
                if (textBox3.Text != textBox2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.",
                    "Repetir contraseñas...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Debe indicar la nueva contraseña.",
                        "Nueva contraseña...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox2.Focus();
                    }
                    else
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("la contraseña es incorrecta", "la contraseña es correcta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        Form1 ventanaForm1 = new Form1();
                        ventanaForm1.Show();
                        this.Hide();

                        cn.Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Select();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Select();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                textBox3.Select();
        }
    }

}
