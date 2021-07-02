
namespace Marcas
{
    partial class Marcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Clientes = new System.Windows.Forms.Label();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.bmt_descrpcion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bmtb_ID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bmt_proveedor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bmtb_Marca = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bfb_limpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfb_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.bfb_limpiar);
            this.panel2.Controls.Add(this.bfb_Agregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 51);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mzButtonWindows1);
            this.panel1.Controls.Add(this.lb_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 51);
            this.panel1.TabIndex = 35;
            // 
            // lb_Clientes
            // 
            this.lb_Clientes.AutoSize = true;
            this.lb_Clientes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Clientes.Location = new System.Drawing.Point(69, 12);
            this.lb_Clientes.Name = "lb_Clientes";
            this.lb_Clientes.Size = new System.Drawing.Size(155, 29);
            this.lb_Clientes.TabIndex = 21;
            this.lb_Clientes.Text = "Agregar Marcas";
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(972, 3);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 37;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Marca";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(193, 149);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(31, 29);
            this.lb_ID.TabIndex = 46;
            this.lb_ID.Text = "ID";
            // 
            // bmt_descrpcion
            // 
            this.bmt_descrpcion.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_descrpcion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_descrpcion.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_descrpcion.BorderThickness = 3;
            this.bmt_descrpcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_descrpcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_descrpcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_descrpcion.isPassword = false;
            this.bmt_descrpcion.Location = new System.Drawing.Point(303, 288);
            this.bmt_descrpcion.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_descrpcion.Name = "bmt_descrpcion";
            this.bmt_descrpcion.Size = new System.Drawing.Size(214, 44);
            this.bmt_descrpcion.TabIndex = 51;
            this.bmt_descrpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtb_ID
            // 
            this.bmtb_ID.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmtb_ID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtb_ID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmtb_ID.BorderThickness = 3;
            this.bmtb_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtb_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtb_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtb_ID.isPassword = false;
            this.bmtb_ID.Location = new System.Drawing.Point(303, 149);
            this.bmtb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.bmtb_ID.Name = "bmtb_ID";
            this.bmtb_ID.Size = new System.Drawing.Size(214, 44);
            this.bmtb_ID.TabIndex = 54;
            this.bmtb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_proveedor
            // 
            this.bmt_proveedor.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmt_proveedor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_proveedor.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmt_proveedor.BorderThickness = 3;
            this.bmt_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_proveedor.isPassword = false;
            this.bmt_proveedor.Location = new System.Drawing.Point(787, 288);
            this.bmt_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_proveedor.Name = "bmt_proveedor";
            this.bmt_proveedor.Size = new System.Drawing.Size(214, 44);
            this.bmt_proveedor.TabIndex = 53;
            this.bmt_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtb_Marca
            // 
            this.bmtb_Marca.BorderColorFocused = System.Drawing.Color.Blue;
            this.bmtb_Marca.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtb_Marca.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bmtb_Marca.BorderThickness = 3;
            this.bmtb_Marca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtb_Marca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtb_Marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtb_Marca.isPassword = false;
            this.bmtb_Marca.Location = new System.Drawing.Point(787, 149);
            this.bmtb_Marca.Margin = new System.Windows.Forms.Padding(4);
            this.bmtb_Marca.Name = "bmtb_Marca";
            this.bmtb_Marca.Size = new System.Drawing.Size(214, 44);
            this.bmtb_Marca.TabIndex = 52;
            this.bmtb_Marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmtb_Marca.OnValueChanged += new System.EventHandler(this.bmtb_Marca_OnValueChanged);
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
            this.bfb_limpiar.Location = new System.Drawing.Point(213, 0);
            this.bfb_limpiar.Name = "bfb_limpiar";
            this.bfb_limpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_limpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_limpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_limpiar.selected = false;
            this.bfb_limpiar.Size = new System.Drawing.Size(124, 48);
            this.bfb_limpiar.TabIndex = 3;
            this.bfb_limpiar.Text = "Limpiar";
            this.bfb_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfb_limpiar.Textcolor = System.Drawing.Color.White;
            this.bfb_limpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_limpiar.Click += new System.EventHandler(this.bfb_limpiar_Click);
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
            this.bfb_Agregar.Location = new System.Drawing.Point(61, 0);
            this.bfb_Agregar.Name = "bfb_Agregar";
            this.bfb_Agregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_Agregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_Agregar.selected = false;
            this.bfb_Agregar.Size = new System.Drawing.Size(124, 48);
            this.bfb_Agregar.TabIndex = 2;
            this.bfb_Agregar.Text = "Agregar";
            this.bfb_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfb_Agregar.Textcolor = System.Drawing.Color.White;
            this.bfb_Agregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_Agregar.Click += new System.EventHandler(this.bfb_Agregar_Click);
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 589);
            this.Controls.Add(this.bmtb_ID);
            this.Controls.Add(this.bmt_proveedor);
            this.Controls.Add(this.bmtb_Marca);
            this.Controls.Add(this.bmt_descrpcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marcas";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Clientes;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmtb_ID;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_proveedor;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmtb_Marca;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_descrpcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ID;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_limpiar;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_Agregar;
    }
}

