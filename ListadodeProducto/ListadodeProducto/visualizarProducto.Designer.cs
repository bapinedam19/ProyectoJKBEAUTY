
namespace ListadodeProducto
{
    partial class visualizarProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jKBeautyDataSet = new ListadodeProducto.JKBeautyDataSet();
            this.productoTableAdapter = new ListadodeProducto.JKBeautyDataSetTableAdapters.ProductoTableAdapter();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtIdmarca = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtPrecioAc = new System.Windows.Forms.TextBox();
            this.txtFechaVen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.idmarcaDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.precioActualDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            // 
            // idmarcaDataGridViewTextBoxColumn
            // 
            this.idmarcaDataGridViewTextBoxColumn.DataPropertyName = "Id_marca";
            this.idmarcaDataGridViewTextBoxColumn.HeaderText = "Id_marca";
            this.idmarcaDataGridViewTextBoxColumn.Name = "idmarcaDataGridViewTextBoxColumn";
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            // 
            // precioActualDataGridViewTextBoxColumn
            // 
            this.precioActualDataGridViewTextBoxColumn.DataPropertyName = "Precio_Actual";
            this.precioActualDataGridViewTextBoxColumn.HeaderText = "Precio_Actual";
            this.precioActualDataGridViewTextBoxColumn.Name = "precioActualDataGridViewTextBoxColumn";
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.jKBeautyDataSet;
            // 
            // jKBeautyDataSet
            // 
            this.jKBeautyDataSet.DataSetName = "JKBeautyDataSet";
            this.jKBeautyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(741, 127);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(113, 20);
            this.txtIDProducto.TabIndex = 1;
            this.txtIDProducto.TextChanged += new System.EventHandler(this.txtIDProducto_TextChanged);
            // 
            // txtIdmarca
            // 
            this.txtIdmarca.Location = new System.Drawing.Point(741, 177);
            this.txtIdmarca.Name = "txtIdmarca";
            this.txtIdmarca.Size = new System.Drawing.Size(113, 20);
            this.txtIdmarca.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(741, 223);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(113, 20);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(741, 272);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(113, 20);
            this.txtExistencia.TabIndex = 4;
            // 
            // txtPrecioAc
            // 
            this.txtPrecioAc.Location = new System.Drawing.Point(741, 319);
            this.txtPrecioAc.Name = "txtPrecioAc";
            this.txtPrecioAc.Size = new System.Drawing.Size(113, 20);
            this.txtPrecioAc.TabIndex = 5;
            // 
            // txtFechaVen
            // 
            this.txtFechaVen.Location = new System.Drawing.Point(741, 365);
            this.txtFechaVen.Name = "txtFechaVen";
            this.txtFechaVen.Size = new System.Drawing.Size(113, 20);
            this.txtFechaVen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(822, 446);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 60);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(722, 446);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(82, 60);
            this.txtEliminar.TabIndex = 10;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.UseVisualStyleBackColor = true;
            this.txtEliminar.Click += new System.EventHandler(this.txtEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ListadodeProducto.Properties.Resources.icons8_actualizar_48;
            this.pictureBox1.Location = new System.Drawing.Point(48, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // visualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaVen);
            this.Controls.Add(this.txtPrecioAc);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtIdmarca);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "visualizarProducto";
            this.Text = "visualizarProducto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JKBeautyDataSet jKBeautyDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private JKBeautyDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.TextBox txtIdmarca;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtPrecioAc;
        private System.Windows.Forms.TextBox txtFechaVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button txtEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

