namespace SistemaEjemplo.Presentación
{
    partial class frmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicio));
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.mostrarServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new SistemaEjemplo.HotelDataSet1();
            this.mostrarServiciosTableAdapter = new SistemaEjemplo.HotelDataSet1TableAdapters.mostrarServiciosTableAdapter();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripción = new System.Windows.Forms.TextBox();
            this.tbBusqAvanzada = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServicio
            // 
            this.dgvServicio.AllowUserToDeleteRows = false;
            this.dgvServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvServicio.Location = new System.Drawing.Point(169, 74);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.ReadOnly = true;
            this.dgvServicio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvServicio.Size = new System.Drawing.Size(464, 150);
            this.dgvServicio.TabIndex = 0;
            this.dgvServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvServicio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicio_CellContentDoubleClick);
            this.dgvServicio.DoubleClick += new System.EventHandler(this.dgvServicio_DoubleClick);
            this.dgvServicio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvServicio_MouseDoubleClick);
            // 
            // mostrarServiciosBindingSource
            // 
            this.mostrarServiciosBindingSource.DataMember = "mostrarServicios";
            this.mostrarServiciosBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarServiciosTableAdapter
            // 
            this.mostrarServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGreen;
            this.btnNuevo.Location = new System.Drawing.Point(27, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightGreen;
            this.btnEditar.Location = new System.Drawing.Point(27, 53);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCancelar.Location = new System.Drawing.Point(27, 83);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.BackColor = System.Drawing.Color.LightGreen;
            this.gbOperaciones.Controls.Add(this.btnGuardar);
            this.gbOperaciones.Controls.Add(this.btnNuevo);
            this.gbOperaciones.Controls.Add(this.btnCancelar);
            this.gbOperaciones.Controls.Add(this.btnEditar);
            this.gbOperaciones.Location = new System.Drawing.Point(12, 21);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(134, 250);
            this.gbOperaciones.TabIndex = 4;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            this.gbOperaciones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Location = new System.Drawing.Point(27, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Location = new System.Drawing.Point(166, 30);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(63, 13);
            this.lblDescripción.TabIndex = 5;
            this.lblDescripción.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(490, 32);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.LightGreen;
            this.tbPrecio.Location = new System.Drawing.Point(533, 27);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 7;
            // 
            // tbDescripción
            // 
            this.tbDescripción.BackColor = System.Drawing.Color.LightGreen;
            this.tbDescripción.Location = new System.Drawing.Point(235, 27);
            this.tbDescripción.Name = "tbDescripción";
            this.tbDescripción.Size = new System.Drawing.Size(246, 20);
            this.tbDescripción.TabIndex = 8;
            this.tbDescripción.TextChanged += new System.EventHandler(this.TbDescripción_TextChanged);
            // 
            // tbBusqAvanzada
            // 
            this.tbBusqAvanzada.BackColor = System.Drawing.Color.LightGreen;
            this.tbBusqAvanzada.Location = new System.Drawing.Point(533, 230);
            this.tbBusqAvanzada.Name = "tbBusqAvanzada";
            this.tbBusqAvanzada.Size = new System.Drawing.Size(100, 20);
            this.tbBusqAvanzada.TabIndex = 9;
            this.tbBusqAvanzada.TextChanged += new System.EventHandler(this.tbBusqAvanzada_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(421, 233);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(106, 13);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Búsqueda Avanzada";
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(664, 283);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbBusqAvanzada);
            this.Controls.Add(this.tbDescripción);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.dgvServicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServicio";
            this.Text = "frmServicio";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            this.gbOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicio;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource mostrarServiciosBindingSource;
        private HotelDataSet1TableAdapters.mostrarServiciosTableAdapter mostrarServiciosTableAdapter;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripción;
        private System.Windows.Forms.TextBox tbBusqAvanzada;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnGuardar;
    }
}