namespace SistemaEjemplo.Presentación
{
    partial class frmDisponibilidadHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisponibilidadHabitaciones));
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblDateEntrada = new System.Windows.Forms.Label();
            this.lblDateSalida = new System.Windows.Forms.Label();
            this.lbHabit = new System.Windows.Forms.Label();
            this.cbNumHabitación = new System.Windows.Forms.ComboBox();
            this.dvResultado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxNoHabitacion = new System.Windows.Forms.CheckBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(122, 62);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrada.TabIndex = 0;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(122, 97);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalida.TabIndex = 1;
            // 
            // lblDateEntrada
            // 
            this.lblDateEntrada.AutoSize = true;
            this.lblDateEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEntrada.Location = new System.Drawing.Point(12, 62);
            this.lblDateEntrada.Name = "lblDateEntrada";
            this.lblDateEntrada.Size = new System.Drawing.Size(104, 15);
            this.lblDateEntrada.TabIndex = 2;
            this.lblDateEntrada.Text = "Fecha de Entrada";
            this.lblDateEntrada.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDateSalida
            // 
            this.lblDateSalida.AutoSize = true;
            this.lblDateSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSalida.Location = new System.Drawing.Point(15, 98);
            this.lblDateSalida.Name = "lblDateSalida";
            this.lblDateSalida.Size = new System.Drawing.Size(96, 15);
            this.lblDateSalida.TabIndex = 3;
            this.lblDateSalida.Text = "Fecha de Salida";
            // 
            // lbHabit
            // 
            this.lbHabit.AutoSize = true;
            this.lbHabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHabit.Location = new System.Drawing.Point(12, 26);
            this.lbHabit.Name = "lbHabit";
            this.lbHabit.Size = new System.Drawing.Size(129, 15);
            this.lbHabit.TabIndex = 4;
            this.lbHabit.Text = "Número de habitación";
            this.lbHabit.Click += new System.EventHandler(this.lbHabit_Click);
            // 
            // cbNumHabitación
            // 
            this.cbNumHabitación.BackColor = System.Drawing.Color.PaleGreen;
            this.cbNumHabitación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumHabitación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumHabitación.FormattingEnabled = true;
            this.cbNumHabitación.Location = new System.Drawing.Point(138, 23);
            this.cbNumHabitación.Name = "cbNumHabitación";
            this.cbNumHabitación.Size = new System.Drawing.Size(62, 21);
            this.cbNumHabitación.TabIndex = 5;
            this.cbNumHabitación.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dvResultado
            // 
            this.dvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResultado.Location = new System.Drawing.Point(18, 196);
            this.dvResultado.Name = "dvResultado";
            this.dvResultado.Size = new System.Drawing.Size(304, 222);
            this.dvResultado.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(111, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 22);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxNoHabitacion
            // 
            this.cbxNoHabitacion.AutoSize = true;
            this.cbxNoHabitacion.BackColor = System.Drawing.Color.PaleGreen;
            this.cbxNoHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNoHabitacion.Location = new System.Drawing.Point(207, 26);
            this.cbxNoHabitacion.Name = "cbxNoHabitacion";
            this.cbxNoHabitacion.Size = new System.Drawing.Size(121, 17);
            this.cbxNoHabitacion.TabIndex = 8;
            this.cbxNoHabitacion.Text = "Cualquier Habitación";
            this.cbxNoHabitacion.UseVisualStyleBackColor = false;
            this.cbxNoHabitacion.CheckStateChanged += new System.EventHandler(this.cbIdHabitación_CheckStateChanged);
            // 
            // frmDisponibilidadHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(346, 430);
            this.Controls.Add(this.cbxNoHabitacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dvResultado);
            this.Controls.Add(this.cbNumHabitación);
            this.Controls.Add(this.lbHabit);
            this.Controls.Add(this.lblDateSalida);
            this.Controls.Add(this.lblDateEntrada);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisponibilidadHabitaciones";
            this.Text = "frmDisponibilidadHabitaciones";
            this.Load += new System.EventHandler(this.frmDisponibilidadHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblDateEntrada;
        private System.Windows.Forms.Label lblDateSalida;
        private System.Windows.Forms.Label lbHabit;
        private System.Windows.Forms.ComboBox cbNumHabitación;
        private System.Windows.Forms.DataGridView dvResultado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbxNoHabitacion;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}