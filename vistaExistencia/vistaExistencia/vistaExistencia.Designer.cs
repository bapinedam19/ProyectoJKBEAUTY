
namespace vistaExistencia
{
    partial class vistaExistencia
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
            this.components = new System.ComponentModel.Container();
            this.visExisGridview = new System.Windows.Forms.DataGridView();
            this.idexistenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadexistenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadbodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadtiendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.jKBeautyDataSet = new vistaExistencia.JKBeautyDataSet();
            //this.existenciasTableAdapter = new vistaExistencia.JKBeautyDataSetTableAdapters.ExistenciasTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdexistencias = new System.Windows.Forms.TextBox();
            this.txtID_Produc = new System.Windows.Forms.TextBox();
            this.txtcanExis = new System.Windows.Forms.TextBox();
            this.txtCantBodega = new System.Windows.Forms.TextBox();
            this.txtcantTienda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.visExisGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // visExisGridview
            // 
            this.visExisGridview.AllowUserToAddRows = false;
            this.visExisGridview.AutoGenerateColumns = false;
            this.visExisGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visExisGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idexistenciasDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn,
            this.cantidadexistenciasDataGridViewTextBoxColumn,
            this.cantidadbodegaDataGridViewTextBoxColumn,
            this.cantidadtiendaDataGridViewTextBoxColumn});
            this.visExisGridview.DataSource = this.existenciasBindingSource;
            this.visExisGridview.Location = new System.Drawing.Point(39, 121);
            this.visExisGridview.Name = "visExisGridview";
            this.visExisGridview.RowHeadersVisible = false;
            this.visExisGridview.Size = new System.Drawing.Size(552, 282);
            this.visExisGridview.TabIndex = 0;
            this.visExisGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisExisGridView_CellContentClick);
            // 
            // idexistenciasDataGridViewTextBoxColumn
            // 
            this.idexistenciasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idexistenciasDataGridViewTextBoxColumn.DataPropertyName = "Id_existencias";
            this.idexistenciasDataGridViewTextBoxColumn.HeaderText = "Id_existencias";
            this.idexistenciasDataGridViewTextBoxColumn.Name = "idexistenciasDataGridViewTextBoxColumn";
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            // 
            // cantidadexistenciasDataGridViewTextBoxColumn
            // 
            this.cantidadexistenciasDataGridViewTextBoxColumn.DataPropertyName = "cantidad_existencias";
            this.cantidadexistenciasDataGridViewTextBoxColumn.HeaderText = "cantidad_existencias";
            this.cantidadexistenciasDataGridViewTextBoxColumn.Name = "cantidadexistenciasDataGridViewTextBoxColumn";
            // 
            // cantidadbodegaDataGridViewTextBoxColumn
            // 
            this.cantidadbodegaDataGridViewTextBoxColumn.DataPropertyName = "cantidad_bodega";
            this.cantidadbodegaDataGridViewTextBoxColumn.HeaderText = "cantidad_bodega";
            this.cantidadbodegaDataGridViewTextBoxColumn.Name = "cantidadbodegaDataGridViewTextBoxColumn";
            // 
            // cantidadtiendaDataGridViewTextBoxColumn
            // 
            this.cantidadtiendaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_tienda";
            this.cantidadtiendaDataGridViewTextBoxColumn.HeaderText = "Cantidad_tienda";
            this.cantidadtiendaDataGridViewTextBoxColumn.Name = "cantidadtiendaDataGridViewTextBoxColumn";
            // 
            // existenciasBindingSource
            // 
            this.existenciasBindingSource.DataMember = "Existencias";
            this.existenciasBindingSource.DataSource = this.jKBeautyDataSet;
            // 
            // jKBeautyDataSet
            // 
            this.jKBeautyDataSet.DataSetName = "JKBeautyDataSet";
            this.jKBeautyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // existenciasTableAdapter
            // 
            this.existenciasTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vistaExistencia.Properties.Resources.icons8_actualizar_48;
            this.pictureBox1.Location = new System.Drawing.Point(39, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(608, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 54);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(714, 349);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 54);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIdexistencias
            // 
            this.txtIdexistencias.Location = new System.Drawing.Point(636, 135);
            this.txtIdexistencias.Name = "txtIdexistencias";
            this.txtIdexistencias.Size = new System.Drawing.Size(129, 20);
            this.txtIdexistencias.TabIndex = 4;
            // 
            // txtID_Produc
            // 
            this.txtID_Produc.Location = new System.Drawing.Point(636, 172);
            this.txtID_Produc.Name = "txtID_Produc";
            this.txtID_Produc.Size = new System.Drawing.Size(129, 20);
            this.txtID_Produc.TabIndex = 5;
            // 
            // txtcanExis
            // 
            this.txtcanExis.Location = new System.Drawing.Point(636, 210);
            this.txtcanExis.Name = "txtcanExis";
            this.txtcanExis.Size = new System.Drawing.Size(129, 20);
            this.txtcanExis.TabIndex = 6;
            // 
            // txtCantBodega
            // 
            this.txtCantBodega.Location = new System.Drawing.Point(636, 249);
            this.txtCantBodega.Name = "txtCantBodega";
            this.txtCantBodega.Size = new System.Drawing.Size(129, 20);
            this.txtCantBodega.TabIndex = 7;
            // 
            // txtcantTienda
            // 
            this.txtcantTienda.Location = new System.Drawing.Point(636, 293);
            this.txtcantTienda.Name = "txtcantTienda";
            this.txtcantTienda.Size = new System.Drawing.Size(129, 20);
            this.txtcantTienda.TabIndex = 8;
            // 
            // vistaExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 461);
            this.Controls.Add(this.txtcantTienda);
            this.Controls.Add(this.txtCantBodega);
            this.Controls.Add(this.txtcanExis);
            this.Controls.Add(this.txtID_Produc);
            this.Controls.Add(this.txtIdexistencias);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visExisGridview);
            this.Name = "vistaExistencia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visExisGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visExisGridview;
        private JKBeautyDataSet jKBeautyDataSet;
        private System.Windows.Forms.BindingSource existenciasBindingSource;
        private JKBeautyDataSetTableAdapters.ExistenciasTableAdapter existenciasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexistenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadexistenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadbodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadtiendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIdexistencias;
        private System.Windows.Forms.TextBox txtID_Produc;
        private System.Windows.Forms.TextBox txtcanExis;
        private System.Windows.Forms.TextBox txtCantBodega;
        private System.Windows.Forms.TextBox txtcantTienda;
    }
}

