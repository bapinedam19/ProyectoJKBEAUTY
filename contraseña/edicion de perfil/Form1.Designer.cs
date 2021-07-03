
namespace edicion_de_perfil
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.TXTCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.TXTCAMBIARCONTRASEÑA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CUENTA = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::edicion_de_perfil.Properties.Resources.simple_user_icon;
            this.pictureBox1.Image = global::edicion_de_perfil.Properties.Resources.simple_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(928, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CORREO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Location = new System.Drawing.Point(234, 206);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(123, 20);
            this.TXTUSUARIO.TabIndex = 4;
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(234, 241);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.Size = new System.Drawing.Size(123, 20);
            this.TXTCORREO.TabIndex = 5;
            // 
            // TXTCONTRASEÑA
            // 
            this.TXTCONTRASEÑA.Location = new System.Drawing.Point(234, 286);
            this.TXTCONTRASEÑA.Name = "TXTCONTRASEÑA";
            this.TXTCONTRASEÑA.Size = new System.Drawing.Size(123, 20);
            this.TXTCONTRASEÑA.TabIndex = 6;
            // 
            // TXTCAMBIARCONTRASEÑA
            // 
            this.TXTCAMBIARCONTRASEÑA.AutoSize = true;
            this.TXTCAMBIARCONTRASEÑA.BackColor = System.Drawing.Color.Transparent;
            this.TXTCAMBIARCONTRASEÑA.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCAMBIARCONTRASEÑA.Location = new System.Drawing.Point(264, 309);
            this.TXTCAMBIARCONTRASEÑA.Name = "TXTCAMBIARCONTRASEÑA";
            this.TXTCAMBIARCONTRASEÑA.Size = new System.Drawing.Size(93, 14);
            this.TXTCAMBIARCONTRASEÑA.TabIndex = 7;
            this.TXTCAMBIARCONTRASEÑA.Text = "Cambiar contraseña";
            this.TXTCAMBIARCONTRASEÑA.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NOMBRE:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(344, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::edicion_de_perfil.Properties.Resources.simple_user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(344, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // CUENTA
            // 
            this.CUENTA.AutoSize = true;
            this.CUENTA.BackColor = System.Drawing.Color.Transparent;
            this.CUENTA.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUENTA.Location = new System.Drawing.Point(339, 117);
            this.CUENTA.Name = "CUENTA";
            this.CUENTA.Size = new System.Drawing.Size(126, 29);
            this.CUENTA.TabIndex = 12;
            this.CUENTA.Text = "CUENTA";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::edicion_de_perfil.Properties.Resources.Sin_título_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CUENTA);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTCAMBIARCONTRASEÑA);
            this.Controls.Add(this.TXTCONTRASEÑA);
            this.Controls.Add(this.TXTCORREO);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EDICION DE PERFIL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.TextBox TXTCORREO;
        private System.Windows.Forms.TextBox TXTCONTRASEÑA;
        private System.Windows.Forms.Label TXTCAMBIARCONTRASEÑA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CUENTA;
        private System.Windows.Forms.TextBox textBox2;
    }
}

