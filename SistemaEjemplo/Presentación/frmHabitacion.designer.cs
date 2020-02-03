namespace SistemaEjemplo.Presentación
{
    partial class frmHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabitacion));
            this.TABLEdatos = new System.Windows.Forms.DataGridView();
            this.BTNnuevo = new System.Windows.Forms.Button();
            this.BTNeditar = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COMBOtipohabitacion = new System.Windows.Forms.ComboBox();
            this.listaTipoHabitacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet5 = new SistemaEjemplo.HotelDataSet5();
            this.listaTipoHabitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TXTdescripcion = new System.Windows.Forms.TextBox();
            this.NUMcapacidad = new System.Windows.Forms.NumericUpDown();
            this.COMBOestado = new System.Windows.Forms.ComboBox();
            this.listaIDhabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTnohabitacion = new System.Windows.Forms.TextBox();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.listaTipoHabitacionTableAdapter = new SistemaEjemplo.HotelDataSet5TableAdapters.ListaTipoHabitacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TABLEdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoHabitacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoHabitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMcapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaIDhabitacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLEdatos
            // 
            this.TABLEdatos.AllowUserToAddRows = false;
            this.TABLEdatos.AllowUserToDeleteRows = false;
            this.TABLEdatos.AllowUserToResizeRows = false;
            this.TABLEdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLEdatos.Location = new System.Drawing.Point(12, 157);
            this.TABLEdatos.Name = "TABLEdatos";
            this.TABLEdatos.ReadOnly = true;
            this.TABLEdatos.Size = new System.Drawing.Size(660, 268);
            this.TABLEdatos.TabIndex = 0;
            this.TABLEdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLEdatos_CellContentClick);
            // 
            // BTNnuevo
            // 
            this.BTNnuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.BTNnuevo.Location = new System.Drawing.Point(12, 12);
            this.BTNnuevo.Name = "BTNnuevo";
            this.BTNnuevo.Size = new System.Drawing.Size(125, 23);
            this.BTNnuevo.TabIndex = 1;
            this.BTNnuevo.Text = "Nueva habitacion";
            this.BTNnuevo.UseVisualStyleBackColor = false;
            this.BTNnuevo.Click += new System.EventHandler(this.BTNnuevo_Click);
            // 
            // BTNeditar
            // 
            this.BTNeditar.BackColor = System.Drawing.Color.PaleGreen;
            this.BTNeditar.Enabled = false;
            this.BTNeditar.Location = new System.Drawing.Point(12, 99);
            this.BTNeditar.Name = "BTNeditar";
            this.BTNeditar.Size = new System.Drawing.Size(125, 23);
            this.BTNeditar.TabIndex = 2;
            this.BTNeditar.Text = "Editar";
            this.BTNeditar.UseVisualStyleBackColor = false;
            this.BTNeditar.Click += new System.EventHandler(this.BTNeditar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.BackColor = System.Drawing.Color.PaleGreen;
            this.BTNcancelar.Enabled = false;
            this.BTNcancelar.Location = new System.Drawing.Point(12, 70);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(125, 23);
            this.BTNcancelar.TabIndex = 3;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = false;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // BTNguardar
            // 
            this.BTNguardar.BackColor = System.Drawing.Color.PaleGreen;
            this.BTNguardar.Enabled = false;
            this.BTNguardar.Location = new System.Drawing.Point(12, 41);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(125, 23);
            this.BTNguardar.TabIndex = 4;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = false;
            this.BTNguardar.Click += new System.EventHandler(this.BTNguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(161, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de habitacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(161, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrpcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(161, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Capacidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(161, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado:";
            // 
            // COMBOtipohabitacion
            // 
            this.COMBOtipohabitacion.BackColor = System.Drawing.Color.PaleGreen;
            this.COMBOtipohabitacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTipoHabitacionBindingSource1, "nom_tipo", true));
            this.COMBOtipohabitacion.DataSource = this.listaTipoHabitacionBindingSource1;
            this.COMBOtipohabitacion.DisplayMember = "nom_tipo";
            this.COMBOtipohabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOtipohabitacion.Enabled = false;
            this.COMBOtipohabitacion.FormattingEnabled = true;
            this.COMBOtipohabitacion.Location = new System.Drawing.Point(299, 14);
            this.COMBOtipohabitacion.Name = "COMBOtipohabitacion";
            this.COMBOtipohabitacion.Size = new System.Drawing.Size(198, 21);
            this.COMBOtipohabitacion.TabIndex = 9;
            this.COMBOtipohabitacion.ValueMember = "cod_tipo";
            // 
            // listaTipoHabitacionBindingSource1
            // 
            this.listaTipoHabitacionBindingSource1.DataMember = "ListaTipoHabitacion";
            this.listaTipoHabitacionBindingSource1.DataSource = this.hotelDataSet5;
            // 
            // hotelDataSet5
            // 
            this.hotelDataSet5.DataSetName = "HotelDataSet5";
            this.hotelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaTipoHabitacionBindingSource
            // 
            this.listaTipoHabitacionBindingSource.DataMember = "ListaTipoHabitacion";
            // 
            // TXTdescripcion
            // 
            this.TXTdescripcion.BackColor = System.Drawing.Color.PaleGreen;
            this.TXTdescripcion.Enabled = false;
            this.TXTdescripcion.Location = new System.Drawing.Point(299, 43);
            this.TXTdescripcion.Name = "TXTdescripcion";
            this.TXTdescripcion.Size = new System.Drawing.Size(198, 20);
            this.TXTdescripcion.TabIndex = 10;
            // 
            // NUMcapacidad
            // 
            this.NUMcapacidad.BackColor = System.Drawing.Color.PaleGreen;
            this.NUMcapacidad.Enabled = false;
            this.NUMcapacidad.Location = new System.Drawing.Point(299, 73);
            this.NUMcapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUMcapacidad.Name = "NUMcapacidad";
            this.NUMcapacidad.ReadOnly = true;
            this.NUMcapacidad.Size = new System.Drawing.Size(198, 20);
            this.NUMcapacidad.TabIndex = 11;
            this.NUMcapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // COMBOestado
            // 
            this.COMBOestado.BackColor = System.Drawing.Color.PaleGreen;
            this.COMBOestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOestado.Enabled = false;
            this.COMBOestado.FormattingEnabled = true;
            this.COMBOestado.Items.AddRange(new object[] {
            "DISPONIBLE",
            "OCUPADA",
            "RESERVADA"});
            this.COMBOestado.Location = new System.Drawing.Point(299, 101);
            this.COMBOestado.Name = "COMBOestado";
            this.COMBOestado.Size = new System.Drawing.Size(198, 21);
            this.COMBOestado.TabIndex = 12;
            // 
            // listaIDhabitacionesBindingSource
            // 
            this.listaIDhabitacionesBindingSource.DataMember = "listaIDhabitaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar:";
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(58, 428);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(213, 20);
            this.TXTbuscar.TabIndex = 14;
            this.TXTbuscar.TextChanged += new System.EventHandler(this.TXTbuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Location = new System.Drawing.Point(161, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero de habitacion:";
            // 
            // TXTnohabitacion
            // 
            this.TXTnohabitacion.BackColor = System.Drawing.Color.PaleGreen;
            this.TXTnohabitacion.Enabled = false;
            this.TXTnohabitacion.Location = new System.Drawing.Point(299, 128);
            this.TXTnohabitacion.Name = "TXTnohabitacion";
            this.TXTnohabitacion.Size = new System.Drawing.Size(198, 20);
            this.TXTnohabitacion.TabIndex = 16;
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.BackColor = System.Drawing.Color.PaleGreen;
            this.BTNeliminar.Enabled = false;
            this.BTNeliminar.Location = new System.Drawing.Point(12, 128);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(125, 23);
            this.BTNeliminar.TabIndex = 17;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = false;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // listaTipoHabitacionTableAdapter
            // 
            this.listaTipoHabitacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(684, 453);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.TXTnohabitacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COMBOestado);
            this.Controls.Add(this.NUMcapacidad);
            this.Controls.Add(this.TXTdescripcion);
            this.Controls.Add(this.COMBOtipohabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNguardar);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNeditar);
            this.Controls.Add(this.BTNnuevo);
            this.Controls.Add(this.TABLEdatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 492);
            this.MinimumSize = new System.Drawing.Size(700, 492);
            this.Name = "frmHabitacion";
            this.Text = "Registros de habitación";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLEdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoHabitacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoHabitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMcapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaIDhabitacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLEdatos;
        private System.Windows.Forms.Button BTNnuevo;
        private System.Windows.Forms.Button BTNeditar;
        private System.Windows.Forms.Button BTNcancelar;
        private System.Windows.Forms.Button BTNguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMBOtipohabitacion;
        private System.Windows.Forms.TextBox TXTdescripcion;
        private System.Windows.Forms.NumericUpDown NUMcapacidad;
        private System.Windows.Forms.ComboBox COMBOestado;
        private System.Windows.Forms.BindingSource listaTipoHabitacionBindingSource;
        private System.Windows.Forms.BindingSource listaIDhabitacionesBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTnohabitacion;
        private System.Windows.Forms.Button BTNeliminar;
        private HotelDataSet5 hotelDataSet5;
        private System.Windows.Forms.BindingSource listaTipoHabitacionBindingSource1;
        private HotelDataSet5TableAdapters.ListaTipoHabitacionTableAdapter listaTipoHabitacionTableAdapter;
    }
}