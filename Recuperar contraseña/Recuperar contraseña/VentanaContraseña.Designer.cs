
namespace Recuperar_contraseña
{
    partial class VentanaContraseña
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDEmpleadoLabel;
            System.Windows.Forms.Label primer_NombreLabel;
            System.Windows.Forms.Label segundo_NombreLabel;
            System.Windows.Forms.Label primer_ApellidoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaContraseña));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jKBeautyDataSet = new Recuperar_contraseña.JKBeautyDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Recuperar_contraseña.JKBeautyDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new Recuperar_contraseña.JKBeautyDataSetTableAdapters.TableAdapterManager();
            this.empleadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.empleadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.primer_NombreTextBox = new System.Windows.Forms.TextBox();
            this.segundo_NombreTextBox = new System.Windows.Forms.TextBox();
            this.primer_ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.btn_aplicar = new ePOSOne.btnProduct.Button_WOC();
            iDEmpleadoLabel = new System.Windows.Forms.Label();
            primer_NombreLabel = new System.Windows.Forms.Label();
            segundo_NombreLabel = new System.Windows.Forms.Label();
            primer_ApellidoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingNavigator)).BeginInit();
            this.empleadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDEmpleadoLabel
            // 
            iDEmpleadoLabel.AutoSize = true;
            iDEmpleadoLabel.Location = new System.Drawing.Point(19, 227);
            iDEmpleadoLabel.Name = "iDEmpleadoLabel";
            iDEmpleadoLabel.Size = new System.Drawing.Size(88, 17);
            iDEmpleadoLabel.TabIndex = 8;
            iDEmpleadoLabel.Text = "IDEmpleado:";
            // 
            // primer_NombreLabel
            // 
            primer_NombreLabel.AutoSize = true;
            primer_NombreLabel.Location = new System.Drawing.Point(19, 274);
            primer_NombreLabel.Name = "primer_NombreLabel";
            primer_NombreLabel.Size = new System.Drawing.Size(107, 17);
            primer_NombreLabel.TabIndex = 10;
            primer_NombreLabel.Text = "Primer Nombre:";
            // 
            // segundo_NombreLabel
            // 
            segundo_NombreLabel.AutoSize = true;
            segundo_NombreLabel.Location = new System.Drawing.Point(19, 316);
            segundo_NombreLabel.Name = "segundo_NombreLabel";
            segundo_NombreLabel.Size = new System.Drawing.Size(123, 17);
            segundo_NombreLabel.TabIndex = 12;
            segundo_NombreLabel.Text = "Segundo Nombre:";
            // 
            // primer_ApellidoLabel
            // 
            primer_ApellidoLabel.AutoSize = true;
            primer_ApellidoLabel.Location = new System.Drawing.Point(19, 357);
            primer_ApellidoLabel.Name = "primer_ApellidoLabel";
            primer_ApellidoLabel.Size = new System.Drawing.Size(107, 17);
            primer_ApellidoLabel.TabIndex = 14;
            primer_ApellidoLabel.Text = "Primer Apellido:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(19, 395);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(61, 17);
            usuarioLabel.TabIndex = 16;
            usuarioLabel.Text = "Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(19, 438);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(85, 17);
            contraseñaLabel.TabIndex = 18;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modificar Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recuperar_contraseña.Properties.Resources.iconfinder_211750_gear_icon;
            this.pictureBox1.Location = new System.Drawing.Point(449, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // jKBeautyDataSet
            // 
            this.jKBeautyDataSet.DataSetName = "JKBeautyDataSet";
            this.jKBeautyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.jKBeautyDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.detallepedidoTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.pedidosTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Recuperar_contraseña.JKBeautyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empleadosBindingNavigator
            // 
            this.empleadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadosBindingNavigator.BindingSource = this.empleadosBindingSource;
            this.empleadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.empleadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.empleadosBindingNavigatorSaveItem});
            this.empleadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadosBindingNavigator.Name = "empleadosBindingNavigator";
            this.empleadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadosBindingNavigator.Size = new System.Drawing.Size(1114, 27);
            this.empleadosBindingNavigator.TabIndex = 8;
            this.empleadosBindingNavigator.Text = "bindingNavigator1";
            this.empleadosBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // empleadosBindingNavigatorSaveItem
            // 
            this.empleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosBindingNavigatorSaveItem.Image")));
            this.empleadosBindingNavigatorSaveItem.Name = "empleadosBindingNavigatorSaveItem";
            this.empleadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.empleadosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.empleadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadosBindingNavigatorSaveItem_Click);
            // 
            // empleadosDataGridView
            // 
            this.empleadosDataGridView.AutoGenerateColumns = false;
            this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.empleadosDataGridView.DataSource = this.empleadosBindingSource;
            this.empleadosDataGridView.Location = new System.Drawing.Point(292, 204);
            this.empleadosDataGridView.Name = "empleadosDataGridView";
            this.empleadosDataGridView.RowHeadersWidth = 51;
            this.empleadosDataGridView.RowTemplate.Height = 24;
            this.empleadosDataGridView.Size = new System.Drawing.Size(802, 329);
            this.empleadosDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDEmpleado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Primer_Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Primer_Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Segundo_Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Segundo_Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Primer_Apellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Primer_Apellido";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // iDEmpleadoTextBox
            // 
            this.iDEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "IDEmpleado", true));
            this.iDEmpleadoTextBox.Location = new System.Drawing.Point(148, 224);
            this.iDEmpleadoTextBox.Name = "iDEmpleadoTextBox";
            this.iDEmpleadoTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDEmpleadoTextBox.TabIndex = 9;
            // 
            // primer_NombreTextBox
            // 
            this.primer_NombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Primer_Nombre", true));
            this.primer_NombreTextBox.Location = new System.Drawing.Point(148, 271);
            this.primer_NombreTextBox.Name = "primer_NombreTextBox";
            this.primer_NombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.primer_NombreTextBox.TabIndex = 11;
            // 
            // segundo_NombreTextBox
            // 
            this.segundo_NombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Segundo_Nombre", true));
            this.segundo_NombreTextBox.Location = new System.Drawing.Point(148, 313);
            this.segundo_NombreTextBox.Name = "segundo_NombreTextBox";
            this.segundo_NombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.segundo_NombreTextBox.TabIndex = 13;
            // 
            // primer_ApellidoTextBox
            // 
            this.primer_ApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Primer_Apellido", true));
            this.primer_ApellidoTextBox.Location = new System.Drawing.Point(148, 354);
            this.primer_ApellidoTextBox.Name = "primer_ApellidoTextBox";
            this.primer_ApellidoTextBox.Size = new System.Drawing.Size(100, 22);
            this.primer_ApellidoTextBox.TabIndex = 15;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(148, 392);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.usuarioTextBox.TabIndex = 17;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Location = new System.Drawing.Point(148, 435);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(100, 22);
            this.contraseñaTextBox.TabIndex = 19;
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_aplicar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_aplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aplicar.Location = new System.Drawing.Point(82, 521);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btn_aplicar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_aplicar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_aplicar.Size = new System.Drawing.Size(166, 45);
            this.btn_aplicar.TabIndex = 7;
            this.btn_aplicar.Text = "Aplicar";
            this.btn_aplicar.TextColor = System.Drawing.Color.White;
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // VentanaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1114, 619);
            this.Controls.Add(iDEmpleadoLabel);
            this.Controls.Add(this.iDEmpleadoTextBox);
            this.Controls.Add(primer_NombreLabel);
            this.Controls.Add(this.primer_NombreTextBox);
            this.Controls.Add(segundo_NombreLabel);
            this.Controls.Add(this.segundo_NombreTextBox);
            this.Controls.Add(primer_ApellidoLabel);
            this.Controls.Add(this.primer_ApellidoTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.empleadosDataGridView);
            this.Controls.Add(this.empleadosBindingNavigator);
            this.Controls.Add(this.btn_aplicar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VentanaContraseña";
            this.Text = "VentanaContraseña";
            this.Load += new System.EventHandler(this.VentanaContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingNavigator)).EndInit();
            this.empleadosBindingNavigator.ResumeLayout(false);
            this.empleadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btn_aplicar;
        private JKBeautyDataSet jKBeautyDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private JKBeautyDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private JKBeautyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empleadosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton empleadosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView empleadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iDEmpleadoTextBox;
        private System.Windows.Forms.TextBox primer_NombreTextBox;
        private System.Windows.Forms.TextBox segundo_NombreTextBox;
        private System.Windows.Forms.TextBox primer_ApellidoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
    }
}