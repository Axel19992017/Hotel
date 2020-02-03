namespace SistemaEjemplo.Presentación
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.TABLEdatos = new System.Windows.Forms.DataGridView();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.BTNeditar = new System.Windows.Forms.Button();
            this.BTNnuevo = new System.Windows.Forms.Button();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTpnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTsnombre = new System.Windows.Forms.TextBox();
            this.TXTpapellido = new System.Windows.Forms.TextBox();
            this.TXTsapellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTdireccion = new System.Windows.Forms.TextBox();
            this.TXTtelefono = new System.Windows.Forms.TextBox();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TABLEdatos)).BeginInit();
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
            this.TABLEdatos.Size = new System.Drawing.Size(830, 268);
            this.TABLEdatos.TabIndex = 0;
            this.TABLEdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLEdatos_CellContentClick);
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.BackColor = System.Drawing.Color.LightGreen;
            this.BTNeliminar.Enabled = false;
            this.BTNeliminar.Location = new System.Drawing.Point(12, 128);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(125, 23);
            this.BTNeliminar.TabIndex = 22;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = false;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // BTNguardar
            // 
            this.BTNguardar.BackColor = System.Drawing.Color.LightGreen;
            this.BTNguardar.Enabled = false;
            this.BTNguardar.Location = new System.Drawing.Point(12, 41);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(125, 23);
            this.BTNguardar.TabIndex = 21;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = false;
            this.BTNguardar.Click += new System.EventHandler(this.BTNguardar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.BackColor = System.Drawing.Color.LightGreen;
            this.BTNcancelar.Enabled = false;
            this.BTNcancelar.Location = new System.Drawing.Point(12, 70);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(125, 23);
            this.BTNcancelar.TabIndex = 20;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = false;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // BTNeditar
            // 
            this.BTNeditar.BackColor = System.Drawing.Color.LightGreen;
            this.BTNeditar.Enabled = false;
            this.BTNeditar.Location = new System.Drawing.Point(12, 99);
            this.BTNeditar.Name = "BTNeditar";
            this.BTNeditar.Size = new System.Drawing.Size(125, 23);
            this.BTNeditar.TabIndex = 19;
            this.BTNeditar.Text = "Editar";
            this.BTNeditar.UseVisualStyleBackColor = false;
            this.BTNeditar.Click += new System.EventHandler(this.BTNeditar_Click);
            // 
            // BTNnuevo
            // 
            this.BTNnuevo.BackColor = System.Drawing.Color.LightGreen;
            this.BTNnuevo.Location = new System.Drawing.Point(12, 12);
            this.BTNnuevo.Name = "BTNnuevo";
            this.BTNnuevo.Size = new System.Drawing.Size(125, 23);
            this.BTNnuevo.TabIndex = 18;
            this.BTNnuevo.Text = "Nuevo empleado";
            this.BTNnuevo.UseVisualStyleBackColor = false;
            this.BTNnuevo.Click += new System.EventHandler(this.BTNnuevo_Click);
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(58, 428);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(213, 20);
            this.TXTbuscar.TabIndex = 24;
            this.TXTbuscar.TextChanged += new System.EventHandler(this.TXTbuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(161, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Primer nombre:";
            // 
            // TXTpnombre
            // 
            this.TXTpnombre.BackColor = System.Drawing.Color.LightGreen;
            this.TXTpnombre.Enabled = false;
            this.TXTpnombre.Location = new System.Drawing.Point(259, 14);
            this.TXTpnombre.Name = "TXTpnombre";
            this.TXTpnombre.Size = new System.Drawing.Size(166, 20);
            this.TXTpnombre.TabIndex = 26;
            this.TXTpnombre.TextChanged += new System.EventHandler(this.TXTpnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(161, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Segundo nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(161, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Primer apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(161, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Segundo apellido:";
            // 
            // TXTsnombre
            // 
            this.TXTsnombre.BackColor = System.Drawing.Color.LightGreen;
            this.TXTsnombre.Enabled = false;
            this.TXTsnombre.Location = new System.Drawing.Point(258, 43);
            this.TXTsnombre.Name = "TXTsnombre";
            this.TXTsnombre.Size = new System.Drawing.Size(166, 20);
            this.TXTsnombre.TabIndex = 30;
            this.TXTsnombre.TextChanged += new System.EventHandler(this.TXTsnombre_TextChanged);
            // 
            // TXTpapellido
            // 
            this.TXTpapellido.BackColor = System.Drawing.Color.LightGreen;
            this.TXTpapellido.Enabled = false;
            this.TXTpapellido.Location = new System.Drawing.Point(259, 72);
            this.TXTpapellido.Name = "TXTpapellido";
            this.TXTpapellido.Size = new System.Drawing.Size(165, 20);
            this.TXTpapellido.TabIndex = 31;
            this.TXTpapellido.TextChanged += new System.EventHandler(this.TXTpapellido_TextChanged);
            // 
            // TXTsapellido
            // 
            this.TXTsapellido.BackColor = System.Drawing.Color.LightGreen;
            this.TXTsapellido.Enabled = false;
            this.TXTsapellido.Location = new System.Drawing.Point(259, 101);
            this.TXTsapellido.Name = "TXTsapellido";
            this.TXTsapellido.Size = new System.Drawing.Size(165, 20);
            this.TXTsapellido.TabIndex = 32;
            this.TXTsapellido.TextChanged += new System.EventHandler(this.TXTsapellido_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(456, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(456, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            this.label8.Location = new System.Drawing.Point(456, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Correo:";
            // 
            // TXTdireccion
            // 
            this.TXTdireccion.BackColor = System.Drawing.Color.LightGreen;
            this.TXTdireccion.Enabled = false;
            this.TXTdireccion.Location = new System.Drawing.Point(517, 14);
            this.TXTdireccion.Name = "TXTdireccion";
            this.TXTdireccion.Size = new System.Drawing.Size(165, 20);
            this.TXTdireccion.TabIndex = 36;
            this.TXTdireccion.TextChanged += new System.EventHandler(this.TXTdireccion_TextChanged);
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.BackColor = System.Drawing.Color.LightGreen;
            this.TXTtelefono.Enabled = false;
            this.TXTtelefono.Location = new System.Drawing.Point(517, 43);
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(165, 20);
            this.TXTtelefono.TabIndex = 37;
            this.TXTtelefono.TextChanged += new System.EventHandler(this.TXTtelefono_TextChanged);
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.BackColor = System.Drawing.Color.LightGreen;
            this.TXTcorreo.Enabled = false;
            this.TXTcorreo.Location = new System.Drawing.Point(517, 72);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(165, 20);
            this.TXTcorreo.TabIndex = 38;
            this.TXTcorreo.TextChanged += new System.EventHandler(this.TXTcorreo_TextChanged);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(854, 453);
            this.Controls.Add(this.TXTcorreo);
            this.Controls.Add(this.TXTtelefono);
            this.Controls.Add(this.TXTdireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTsapellido);
            this.Controls.Add(this.TXTpapellido);
            this.Controls.Add(this.TXTsnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTpnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.BTNguardar);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNeditar);
            this.Controls.Add(this.BTNnuevo);
            this.Controls.Add(this.TABLEdatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 492);
            this.MinimumSize = new System.Drawing.Size(870, 492);
            this.Name = "frmEmpleado";
            this.Text = "Registros de empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLEdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLEdatos;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.Button BTNguardar;
        private System.Windows.Forms.Button BTNcancelar;
        private System.Windows.Forms.Button BTNeditar;
        private System.Windows.Forms.Button BTNnuevo;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTpnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTsnombre;
        private System.Windows.Forms.TextBox TXTpapellido;
        private System.Windows.Forms.TextBox TXTsapellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTdireccion;
        private System.Windows.Forms.TextBox TXTtelefono;
        private System.Windows.Forms.TextBox TXTcorreo;
    }
}