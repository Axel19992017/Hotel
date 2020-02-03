namespace SistemaEjemplo.Presentación
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIdEmpleado = new System.Windows.Forms.ComboBox();
            this.getIdEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet6 = new SistemaEjemplo.HotelDataSet6();
            this.getIdEmpleadosTableAdapter = new SistemaEjemplo.HotelDataSet6TableAdapters.getIdEmpleadosTableAdapter();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIdEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre  del Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbUser.ForeColor = System.Drawing.Color.Black;
            this.tbUser.Location = new System.Drawing.Point(172, 35);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbPass.ForeColor = System.Drawing.Color.Black;
            this.tbPass.Location = new System.Drawing.Point(172, 65);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(129, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(281, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.GridColor = System.Drawing.Color.PaleGreen;
            this.dgvUsuario.Location = new System.Drawing.Point(34, 176);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(241, 150);
            this.dgvUsuario.TabIndex = 6;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IdEmpleado:";
            // 
            // cbIdEmpleado
            // 
            this.cbIdEmpleado.BackColor = System.Drawing.Color.PaleGreen;
            this.cbIdEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getIdEmpleadosBindingSource, "Código", true));
            this.cbIdEmpleado.DataSource = this.getIdEmpleadosBindingSource;
            this.cbIdEmpleado.DisplayMember = "Código";
            this.cbIdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIdEmpleado.FormattingEnabled = true;
            this.cbIdEmpleado.Location = new System.Drawing.Point(172, 92);
            this.cbIdEmpleado.Name = "cbIdEmpleado";
            this.cbIdEmpleado.Size = new System.Drawing.Size(100, 21);
            this.cbIdEmpleado.TabIndex = 8;
            this.cbIdEmpleado.ValueMember = "Código";
            // 
            // getIdEmpleadosBindingSource
            // 
            this.getIdEmpleadosBindingSource.DataMember = "getIdEmpleados";
            this.getIdEmpleadosBindingSource.DataSource = this.hotelDataSet6;
            // 
            // hotelDataSet6
            // 
            this.hotelDataSet6.DataSetName = "HotelDataSet6";
            this.hotelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getIdEmpleadosTableAdapter
            // 
            this.getIdEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.PaleGreen;
            this.lblUsuario.Location = new System.Drawing.Point(298, 223);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "<Usuario>";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.Color.PaleGreen;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Empleado",
            "Administrador",
            "AdminMaestro"});
            this.cbRol.Location = new System.Drawing.Point(172, 120);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(100, 21);
            this.cbRol.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rol en el Sistema";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(364, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbIdEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIdEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIdEmpleado;
        private HotelDataSet6 hotelDataSet6;
        private System.Windows.Forms.BindingSource getIdEmpleadosBindingSource;
        private HotelDataSet6TableAdapters.getIdEmpleadosTableAdapter getIdEmpleadosTableAdapter;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label4;
    }
}