namespace SistemaEjemplo.Presentación
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.pReserva = new System.Windows.Forms.Panel();
            this.lblReserva = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAddHabit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHabitDisp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActHabDisp = new System.Windows.Forms.Button();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHabRes = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPrecioServicio = new System.Windows.Forms.Label();
            this.btnAddServicio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.lblidHabitRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new SistemaEjemplo.HotelDataSet();
            this.hotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pReserva
            // 
            this.pReserva.BackColor = System.Drawing.Color.LightGreen;
            this.pReserva.Controls.Add(this.lblReserva);
            this.pReserva.Controls.Add(this.dgvReserva);
            this.pReserva.Location = new System.Drawing.Point(12, 12);
            this.pReserva.Name = "pReserva";
            this.pReserva.Size = new System.Drawing.Size(784, 230);
            this.pReserva.TabIndex = 10;
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(335, -3);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(79, 24);
            this.lblReserva.TabIndex = 13;
            this.lblReserva.Text = "Reserva";
            // 
            // dgvReserva
            // 
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(14, 36);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(742, 165);
            this.dgvReserva.TabIndex = 11;
            this.dgvReserva.DoubleClick += new System.EventHandler(this.dgvReserva_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblIdReserva);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblHabRes);
            this.panel3.Controls.Add(this.dgvHabitaciones);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.panel3.Location = new System.Drawing.Point(12, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 357);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.btnAddHabit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbHabitDisp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnActHabDisp);
            this.panel1.Controls.Add(this.dtpFechaEntrada);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpFechaSalida);
            this.panel1.Location = new System.Drawing.Point(405, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 293);
            this.panel1.TabIndex = 32;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(69, 222);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 15);
            this.lblPrecio.TabIndex = 34;
            this.lblPrecio.Text = "<Precio>";
            // 
            // btnAddHabit
            // 
            this.btnAddHabit.Location = new System.Drawing.Point(8, 258);
            this.btnAddHabit.Name = "btnAddHabit";
            this.btnAddHabit.Size = new System.Drawing.Size(107, 23);
            this.btnAddHabit.TabIndex = 33;
            this.btnAddHabit.Text = "Agregar";
            this.btnAddHabit.UseVisualStyleBackColor = true;
            this.btnAddHabit.Click += new System.EventHandler(this.btnAddHabit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id Habitación";
            // 
            // cbHabitDisp
            // 
            this.cbHabitDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitDisp.FormattingEnabled = true;
            this.cbHabitDisp.Location = new System.Drawing.Point(8, 219);
            this.cbHabitDisp.Name = "cbHabitDisp";
            this.cbHabitDisp.Size = new System.Drawing.Size(60, 21);
            this.cbHabitDisp.TabIndex = 31;
            this.cbHabitDisp.SelectedIndexChanged += new System.EventHandler(this.cbHabitDisp_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fecha de Entrada";
            // 
            // btnActHabDisp
            // 
            this.btnActHabDisp.Location = new System.Drawing.Point(14, 145);
            this.btnActHabDisp.Name = "btnActHabDisp";
            this.btnActHabDisp.Size = new System.Drawing.Size(101, 23);
            this.btnActHabDisp.TabIndex = 30;
            this.btnActHabDisp.Text = "Actualizar";
            this.btnActHabDisp.UseVisualStyleBackColor = true;
            this.btnActHabDisp.Click += new System.EventHandler(this.btnActHabDisp_Click);
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(14, 41);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaEntrada.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fecha de Salida";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(14, 109);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaSalida.TabIndex = 27;
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Location = new System.Drawing.Point(339, 34);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(76, 15);
            this.lblIdReserva.TabIndex = 12;
            this.lblIdReserva.Text = "<idReserva>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "IdReserva:";
            // 
            // lblHabRes
            // 
            this.lblHabRes.AutoSize = true;
            this.lblHabRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabRes.Location = new System.Drawing.Point(10, 10);
            this.lblHabRes.Name = "lblHabRes";
            this.lblHabRes.Size = new System.Drawing.Size(223, 24);
            this.lblHabRes.TabIndex = 10;
            this.lblHabRes.Text = "Habitaciones Reservadas";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(14, 52);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(370, 293);
            this.dgvHabitaciones.TabIndex = 9;
            this.dgvHabitaciones.DoubleClick += new System.EventHandler(this.dgvHabitaciones_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblidHabitRes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvServicios);
            this.panel2.Location = new System.Drawing.Point(570, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 357);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPrecioServicio);
            this.panel4.Controls.Add(this.btnAddServicio);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cbServicio);
            this.panel4.Location = new System.Drawing.Point(355, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 129);
            this.panel4.TabIndex = 33;
            // 
            // lblPrecioServicio
            // 
            this.lblPrecioServicio.AutoSize = true;
            this.lblPrecioServicio.Location = new System.Drawing.Point(74, 47);
            this.lblPrecioServicio.Name = "lblPrecioServicio";
            this.lblPrecioServicio.Size = new System.Drawing.Size(49, 13);
            this.lblPrecioServicio.TabIndex = 34;
            this.lblPrecioServicio.Text = "<Precio>";
            // 
            // btnAddServicio
            // 
            this.btnAddServicio.Location = new System.Drawing.Point(13, 83);
            this.btnAddServicio.Name = "btnAddServicio";
            this.btnAddServicio.Size = new System.Drawing.Size(107, 23);
            this.btnAddServicio.TabIndex = 33;
            this.btnAddServicio.Text = "Agregar";
            this.btnAddServicio.UseVisualStyleBackColor = true;
            this.btnAddServicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Id Servicio";
            // 
            // cbServicio
            // 
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(13, 44);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(60, 21);
            this.cbServicio.TabIndex = 31;
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblidHabitRes
            // 
            this.lblidHabitRes.AutoSize = true;
            this.lblidHabitRes.Location = new System.Drawing.Point(264, 34);
            this.lblidHabitRes.Name = "lblidHabitRes";
            this.lblidHabitRes.Size = new System.Drawing.Size(52, 13);
            this.lblidHabitRes.TabIndex = 14;
            this.lblidHabitRes.Text = "<idHabit>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Servicios a la Habitación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "IdHabitaciónReserva";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(24, 52);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(312, 293);
            this.dgvServicios.TabIndex = 10;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDataSetBindingSource
            // 
            this.hotelDataSetBindingSource.DataSource = this.hotelDataSet;
            this.hotelDataSetBindingSource.Position = 0;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1086, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReserva";
            this.Text = "frmReserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pReserva.ResumeLayout(false);
            this.pReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pReserva;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHabRes;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidHabitRes;
        private System.Windows.Forms.Label label4;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource hotelDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAddHabit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHabitDisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnActHabDisp;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPrecioServicio;
        private System.Windows.Forms.Button btnAddServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbServicio;
    }
}