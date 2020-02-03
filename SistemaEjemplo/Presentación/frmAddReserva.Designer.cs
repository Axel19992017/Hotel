namespace SistemaEjemplo.Presentación
{
    partial class frmAddReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddReserva));
            this.lblEmpleadotxt = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblClienteSelect = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.btnActCliente = new System.Windows.Forms.Button();
            this.btnPaso1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbEstadoPagado = new System.Windows.Forms.CheckBox();
            this.cbEstadoReservado = new System.Windows.Forms.CheckBox();
            this.cbMetodoTarjeta = new System.Windows.Forms.CheckBox();
            this.cbPagoContado = new System.Windows.Forms.CheckBox();
            this.cbDivisaCordobas = new System.Windows.Forms.CheckBox();
            this.cbDivisaDolares = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpleadotxt
            // 
            this.lblEmpleadotxt.AutoSize = true;
            this.lblEmpleadotxt.Location = new System.Drawing.Point(25, 6);
            this.lblEmpleadotxt.Name = "lblEmpleadotxt";
            this.lblEmpleadotxt.Size = new System.Drawing.Size(90, 13);
            this.lblEmpleadotxt.TabIndex = 1;
            this.lblEmpleadotxt.Text = "Código Empleado";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(122, 6);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(35, 13);
            this.lblIdEmpleado.TabIndex = 2;
            this.lblIdEmpleado.Text = "label1";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(31, 63);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(264, 150);
            this.dgvCliente.TabIndex = 3;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(28, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(109, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Seleccione el Cliente:";
            // 
            // lblClienteSelect
            // 
            this.lblClienteSelect.AutoSize = true;
            this.lblClienteSelect.Location = new System.Drawing.Point(32, 231);
            this.lblClienteSelect.Name = "lblClienteSelect";
            this.lblClienteSelect.Size = new System.Drawing.Size(163, 13);
            this.lblClienteSelect.TabIndex = 5;
            this.lblClienteSelect.Text = "Código del Cliente Seleccionado:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(232, 231);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(63, 13);
            this.lblIdCliente.TabIndex = 6;
            this.lblIdCliente.Text = "<Id Cliente>";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(195, 6);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaReserva.TabIndex = 7;
            // 
            // btnActCliente
            // 
            this.btnActCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActCliente.Location = new System.Drawing.Point(220, 34);
            this.btnActCliente.Name = "btnActCliente";
            this.btnActCliente.Size = new System.Drawing.Size(75, 23);
            this.btnActCliente.TabIndex = 8;
            this.btnActCliente.Text = "Actualizar";
            this.btnActCliente.UseVisualStyleBackColor = true;
            this.btnActCliente.Click += new System.EventHandler(this.btnActCliente_Click);
            // 
            // btnPaso1
            // 
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Location = new System.Drawing.Point(220, 417);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 23);
            this.btnPaso1.TabIndex = 12;
            this.btnPaso1.Text = "Registrar";
            this.btnPaso1.UseVisualStyleBackColor = true;
            this.btnPaso1.Click += new System.EventHandler(this.btnPaso1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblIdReserva);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvCliente);
            this.panel2.Controls.Add(this.lblEmpleadotxt);
            this.panel2.Controls.Add(this.lblIdEmpleado);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.lblClienteSelect);
            this.panel2.Controls.Add(this.lblIdCliente);
            this.panel2.Controls.Add(this.dtpFechaReserva);
            this.panel2.Controls.Add(this.btnActCliente);
            this.panel2.Controls.Add(this.btnPaso1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 454);
            this.panel2.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Código de la Reserva:";
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Location = new System.Drawing.Point(122, 417);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(71, 13);
            this.lblIdReserva.TabIndex = 14;
            this.lblIdReserva.Text = "<Id Reserva>";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbEstadoPagado);
            this.panel4.Controls.Add(this.cbEstadoReservado);
            this.panel4.Controls.Add(this.cbMetodoTarjeta);
            this.panel4.Controls.Add(this.cbPagoContado);
            this.panel4.Controls.Add(this.cbDivisaCordobas);
            this.panel4.Controls.Add(this.cbDivisaDolares);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(28, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 126);
            this.panel4.TabIndex = 13;
            // 
            // cbEstadoPagado
            // 
            this.cbEstadoPagado.AutoSize = true;
            this.cbEstadoPagado.Checked = true;
            this.cbEstadoPagado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstadoPagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoPagado.Location = new System.Drawing.Point(186, 89);
            this.cbEstadoPagado.Name = "cbEstadoPagado";
            this.cbEstadoPagado.Size = new System.Drawing.Size(60, 17);
            this.cbEstadoPagado.TabIndex = 32;
            this.cbEstadoPagado.Text = "Pagado";
            this.cbEstadoPagado.UseVisualStyleBackColor = true;
            this.cbEstadoPagado.CheckedChanged += new System.EventHandler(this.cbEstadoPagado_CheckedChanged);
            // 
            // cbEstadoReservado
            // 
            this.cbEstadoReservado.AutoSize = true;
            this.cbEstadoReservado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoReservado.Location = new System.Drawing.Point(110, 89);
            this.cbEstadoReservado.Name = "cbEstadoReservado";
            this.cbEstadoReservado.Size = new System.Drawing.Size(75, 17);
            this.cbEstadoReservado.TabIndex = 31;
            this.cbEstadoReservado.Text = "Reservado";
            this.cbEstadoReservado.UseVisualStyleBackColor = true;
            this.cbEstadoReservado.CheckedChanged += new System.EventHandler(this.cbEstadoReservado_CheckedChanged);
            // 
            // cbMetodoTarjeta
            // 
            this.cbMetodoTarjeta.AutoSize = true;
            this.cbMetodoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMetodoTarjeta.Location = new System.Drawing.Point(186, 49);
            this.cbMetodoTarjeta.Name = "cbMetodoTarjeta";
            this.cbMetodoTarjeta.Size = new System.Drawing.Size(56, 17);
            this.cbMetodoTarjeta.TabIndex = 30;
            this.cbMetodoTarjeta.Text = "Tarjeta";
            this.cbMetodoTarjeta.UseVisualStyleBackColor = true;
            this.cbMetodoTarjeta.CheckedChanged += new System.EventHandler(this.cbMetodoTarjeta_CheckedChanged);
            // 
            // cbPagoContado
            // 
            this.cbPagoContado.AutoSize = true;
            this.cbPagoContado.Checked = true;
            this.cbPagoContado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPagoContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPagoContado.Location = new System.Drawing.Point(110, 49);
            this.cbPagoContado.Name = "cbPagoContado";
            this.cbPagoContado.Size = new System.Drawing.Size(63, 17);
            this.cbPagoContado.TabIndex = 29;
            this.cbPagoContado.Text = "Contado";
            this.cbPagoContado.UseVisualStyleBackColor = true;
            this.cbPagoContado.CheckedChanged += new System.EventHandler(this.cbPagoContado_CheckedChanged_1);
            // 
            // cbDivisaCordobas
            // 
            this.cbDivisaCordobas.AutoSize = true;
            this.cbDivisaCordobas.Checked = true;
            this.cbDivisaCordobas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDivisaCordobas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDivisaCordobas.Location = new System.Drawing.Point(182, 9);
            this.cbDivisaCordobas.Name = "cbDivisaCordobas";
            this.cbDivisaCordobas.Size = new System.Drawing.Size(68, 17);
            this.cbDivisaCordobas.TabIndex = 28;
            this.cbDivisaCordobas.Text = "Córdobas";
            this.cbDivisaCordobas.UseVisualStyleBackColor = true;
            this.cbDivisaCordobas.CheckedChanged += new System.EventHandler(this.cbDivisaCordobas_CheckedChanged);
            // 
            // cbDivisaDolares
            // 
            this.cbDivisaDolares.AutoSize = true;
            this.cbDivisaDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDivisaDolares.Location = new System.Drawing.Point(110, 9);
            this.cbDivisaDolares.Name = "cbDivisaDolares";
            this.cbDivisaDolares.Size = new System.Drawing.Size(59, 17);
            this.cbDivisaDolares.TabIndex = 27;
            this.cbDivisaDolares.Text = "Dólares";
            this.cbDivisaDolares.UseVisualStyleBackColor = true;
            this.cbDivisaDolares.CheckedChanged += new System.EventHandler(this.cbDivisaDolares_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estado de Reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Método de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Divisa";
            // 
            // frmAddReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(344, 476);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddReserva";
            this.Load += new System.EventHandler(this.frmAddReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEmpleadotxt;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteSelect;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Button btnActCliente;
        private System.Windows.Forms.Button btnPaso1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbEstadoPagado;
        private System.Windows.Forms.CheckBox cbEstadoReservado;
        private System.Windows.Forms.CheckBox cbMetodoTarjeta;
        private System.Windows.Forms.CheckBox cbPagoContado;
        private System.Windows.Forms.CheckBox cbDivisaCordobas;
        private System.Windows.Forms.CheckBox cbDivisaDolares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIdReserva;
    }
}