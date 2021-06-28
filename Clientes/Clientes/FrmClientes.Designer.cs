
namespace Clientes
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.lb_Clientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.lb_PrNombre = new System.Windows.Forms.Label();
            this.lb_SgNombre = new System.Windows.Forms.Label();
            this.lb_PrApellido = new System.Windows.Forms.Label();
            this.lb_Dirección = new System.Windows.Forms.Label();
            this.lb_Telefono = new System.Windows.Forms.Label();
            this.lb_Correo = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bfb_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BMTB_ID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BMTB_PrNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BMTB_SgNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BMTB_PrApellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BMTB_Direccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BMTB_Telefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BMTB_Correo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bfb_limpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Clientes
            // 
            this.lb_Clientes.AutoSize = true;
            this.lb_Clientes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Clientes.Location = new System.Drawing.Point(58, 19);
            this.lb_Clientes.Name = "lb_Clientes";
            this.lb_Clientes.Size = new System.Drawing.Size(83, 29);
            this.lb_Clientes.TabIndex = 21;
            this.lb_Clientes.Text = "Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mzButtonWindows1);
            this.panel1.Controls.Add(this.lb_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 51);
            this.panel1.TabIndex = 2;
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(973, 12);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 3;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null;
            // 
            // lb_PrNombre
            // 
            this.lb_PrNombre.AutoSize = true;
            this.lb_PrNombre.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrNombre.Location = new System.Drawing.Point(99, 197);
            this.lb_PrNombre.Name = "lb_PrNombre";
            this.lb_PrNombre.Size = new System.Drawing.Size(146, 29);
            this.lb_PrNombre.TabIndex = 28;
            this.lb_PrNombre.Text = "Primer Nombre";
            // 
            // lb_SgNombre
            // 
            this.lb_SgNombre.AutoSize = true;
            this.lb_SgNombre.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SgNombre.Location = new System.Drawing.Point(555, 197);
            this.lb_SgNombre.Name = "lb_SgNombre";
            this.lb_SgNombre.Size = new System.Drawing.Size(167, 29);
            this.lb_SgNombre.TabIndex = 27;
            this.lb_SgNombre.Text = "Segundo Nombre";
            // 
            // lb_PrApellido
            // 
            this.lb_PrApellido.AutoSize = true;
            this.lb_PrApellido.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrApellido.Location = new System.Drawing.Point(99, 306);
            this.lb_PrApellido.Name = "lb_PrApellido";
            this.lb_PrApellido.Size = new System.Drawing.Size(145, 29);
            this.lb_PrApellido.TabIndex = 26;
            this.lb_PrApellido.Text = "Primer Apellido";
            // 
            // lb_Dirección
            // 
            this.lb_Dirección.AutoSize = true;
            this.lb_Dirección.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dirección.Location = new System.Drawing.Point(555, 305);
            this.lb_Dirección.Name = "lb_Dirección";
            this.lb_Dirección.Size = new System.Drawing.Size(95, 29);
            this.lb_Dirección.TabIndex = 25;
            this.lb_Dirección.Text = "Dirección";
            // 
            // lb_Telefono
            // 
            this.lb_Telefono.AutoSize = true;
            this.lb_Telefono.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Telefono.Location = new System.Drawing.Point(99, 409);
            this.lb_Telefono.Name = "lb_Telefono";
            this.lb_Telefono.Size = new System.Drawing.Size(90, 29);
            this.lb_Telefono.TabIndex = 24;
            this.lb_Telefono.Text = "Teléfono";
            // 
            // lb_Correo
            // 
            this.lb_Correo.AutoSize = true;
            this.lb_Correo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Correo.Location = new System.Drawing.Point(555, 409);
            this.lb_Correo.Name = "lb_Correo";
            this.lb_Correo.Size = new System.Drawing.Size(74, 29);
            this.lb_Correo.TabIndex = 23;
            this.lb_Correo.Text = "Corréo";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(99, 113);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(31, 29);
            this.lb_ID.TabIndex = 22;
            this.lb_ID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.bfb_limpiar);
            this.panel2.Controls.Add(this.bfb_Agregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 51);
            this.panel2.TabIndex = 29;
            // 
            // bfb_Agregar
            // 
            this.bfb_Agregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_Agregar.BorderRadius = 0;
            this.bfb_Agregar.ButtonText = "Agregar";
            this.bfb_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfb_Agregar.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_Agregar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_Agregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_Agregar.Iconimage")));
            this.bfb_Agregar.Iconimage_right = null;
            this.bfb_Agregar.Iconimage_right_Selected = null;
            this.bfb_Agregar.Iconimage_Selected = null;
            this.bfb_Agregar.IconMarginLeft = 0;
            this.bfb_Agregar.IconMarginRight = 0;
            this.bfb_Agregar.IconRightVisible = true;
            this.bfb_Agregar.IconRightZoom = 0D;
            this.bfb_Agregar.IconVisible = true;
            this.bfb_Agregar.IconZoom = 90D;
            this.bfb_Agregar.IsTab = false;
            this.bfb_Agregar.Location = new System.Drawing.Point(79, 0);
            this.bfb_Agregar.Name = "bfb_Agregar";
            this.bfb_Agregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_Agregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_Agregar.selected = false;
            this.bfb_Agregar.Size = new System.Drawing.Size(124, 48);
            this.bfb_Agregar.TabIndex = 0;
            this.bfb_Agregar.Text = "Agregar";
            this.bfb_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfb_Agregar.Textcolor = System.Drawing.Color.White;
            this.bfb_Agregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_Agregar.Click += new System.EventHandler(this.bfb_Agregar_Click);
            // 
            // BMTB_ID
            // 
            this.BMTB_ID.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_ID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_ID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_ID.BorderThickness = 3;
            this.BMTB_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_ID.isPassword = false;
            this.BMTB_ID.Location = new System.Drawing.Point(154, 113);
            this.BMTB_ID.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_ID.Name = "BMTB_ID";
            this.BMTB_ID.Size = new System.Drawing.Size(225, 44);
            this.BMTB_ID.TabIndex = 30;
            this.BMTB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BMTB_PrNombre
            // 
            this.BMTB_PrNombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_PrNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_PrNombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_PrNombre.BorderThickness = 3;
            this.BMTB_PrNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_PrNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_PrNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_PrNombre.isPassword = false;
            this.BMTB_PrNombre.Location = new System.Drawing.Point(252, 182);
            this.BMTB_PrNombre.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_PrNombre.Name = "BMTB_PrNombre";
            this.BMTB_PrNombre.Size = new System.Drawing.Size(225, 44);
            this.BMTB_PrNombre.TabIndex = 31;
            this.BMTB_PrNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BMTB_SgNombre
            // 
            this.BMTB_SgNombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_SgNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_SgNombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_SgNombre.BorderThickness = 3;
            this.BMTB_SgNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_SgNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_SgNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_SgNombre.isPassword = false;
            this.BMTB_SgNombre.Location = new System.Drawing.Point(729, 182);
            this.BMTB_SgNombre.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_SgNombre.Name = "BMTB_SgNombre";
            this.BMTB_SgNombre.Size = new System.Drawing.Size(225, 44);
            this.BMTB_SgNombre.TabIndex = 32;
            this.BMTB_SgNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BMTB_PrApellido
            // 
            this.BMTB_PrApellido.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_PrApellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_PrApellido.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_PrApellido.BorderThickness = 3;
            this.BMTB_PrApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_PrApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_PrApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_PrApellido.isPassword = false;
            this.BMTB_PrApellido.Location = new System.Drawing.Point(251, 305);
            this.BMTB_PrApellido.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_PrApellido.Name = "BMTB_PrApellido";
            this.BMTB_PrApellido.Size = new System.Drawing.Size(225, 44);
            this.BMTB_PrApellido.TabIndex = 33;
            this.BMTB_PrApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BMTB_Direccion
            // 
            this.BMTB_Direccion.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_Direccion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_Direccion.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_Direccion.BorderThickness = 3;
            this.BMTB_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_Direccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_Direccion.isPassword = false;
            this.BMTB_Direccion.Location = new System.Drawing.Point(671, 305);
            this.BMTB_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_Direccion.Name = "BMTB_Direccion";
            this.BMTB_Direccion.Size = new System.Drawing.Size(225, 44);
            this.BMTB_Direccion.TabIndex = 34;
            this.BMTB_Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BMTB_Telefono
            // 
            this.BMTB_Telefono.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_Telefono.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_Telefono.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_Telefono.BorderThickness = 3;
            this.BMTB_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_Telefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_Telefono.isPassword = false;
            this.BMTB_Telefono.Location = new System.Drawing.Point(210, 394);
            this.BMTB_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_Telefono.Name = "BMTB_Telefono";
            this.BMTB_Telefono.Size = new System.Drawing.Size(225, 44);
            this.BMTB_Telefono.TabIndex = 35;
            this.BMTB_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BMTB_Correo
            // 
            this.BMTB_Correo.BorderColorFocused = System.Drawing.Color.Blue;
            this.BMTB_Correo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_Correo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BMTB_Correo.BorderThickness = 3;
            this.BMTB_Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMTB_Correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BMTB_Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMTB_Correo.isPassword = false;
            this.BMTB_Correo.Location = new System.Drawing.Point(654, 394);
            this.BMTB_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.BMTB_Correo.Name = "BMTB_Correo";
            this.BMTB_Correo.Size = new System.Drawing.Size(225, 44);
            this.BMTB_Correo.TabIndex = 36;
            this.BMTB_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bfb_limpiar
            // 
            this.bfb_limpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_limpiar.BorderRadius = 0;
            this.bfb_limpiar.ButtonText = "Limpiar";
            this.bfb_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfb_limpiar.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_limpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_limpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_limpiar.Iconimage")));
            this.bfb_limpiar.Iconimage_right = null;
            this.bfb_limpiar.Iconimage_right_Selected = null;
            this.bfb_limpiar.Iconimage_Selected = null;
            this.bfb_limpiar.IconMarginLeft = 0;
            this.bfb_limpiar.IconMarginRight = 0;
            this.bfb_limpiar.IconRightVisible = true;
            this.bfb_limpiar.IconRightZoom = 0D;
            this.bfb_limpiar.IconVisible = true;
            this.bfb_limpiar.IconZoom = 90D;
            this.bfb_limpiar.IsTab = false;
            this.bfb_limpiar.Location = new System.Drawing.Point(231, 0);
            this.bfb_limpiar.Name = "bfb_limpiar";
            this.bfb_limpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_limpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_limpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_limpiar.selected = false;
            this.bfb_limpiar.Size = new System.Drawing.Size(124, 48);
            this.bfb_limpiar.TabIndex = 1;
            this.bfb_limpiar.Text = "Limpiar";
            this.bfb_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfb_limpiar.Textcolor = System.Drawing.Color.White;
            this.bfb_limpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_limpiar.Click += new System.EventHandler(this.bfb_limpiar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 569);
            this.Controls.Add(this.BMTB_Correo);
            this.Controls.Add(this.BMTB_Telefono);
            this.Controls.Add(this.BMTB_Direccion);
            this.Controls.Add(this.BMTB_PrApellido);
            this.Controls.Add(this.BMTB_SgNombre);
            this.Controls.Add(this.BMTB_PrNombre);
            this.Controls.Add(this.BMTB_ID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_PrNombre);
            this.Controls.Add(this.lb_SgNombre);
            this.Controls.Add(this.lb_PrApellido);
            this.Controls.Add(this.lb_Dirección);
            this.Controls.Add(this.lb_Telefono);
            this.Controls.Add(this.lb_Correo);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Clientes;
        private System.Windows.Forms.Panel panel1;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_PrNombre;
        private System.Windows.Forms.Label lb_SgNombre;
        private System.Windows.Forms.Label lb_PrApellido;
        private System.Windows.Forms.Label lb_Dirección;
        private System.Windows.Forms.Label lb_Telefono;
        private System.Windows.Forms.Label lb_Correo;
        private System.Windows.Forms.Label lb_ID;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_Correo;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_Telefono;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_Direccion;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_PrApellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_SgNombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_PrNombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox BMTB_ID;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_Agregar;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_limpiar;
    }
}

