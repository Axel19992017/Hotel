namespace SistemaEjemplo.Presentación
{
    partial class frmRecaudaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecaudaciones));
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.listMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet2 = new SistemaEjemplo.HotelDataSet2();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.listYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet3 = new SistemaEjemplo.HotelDataSet3();
            this.hotelDataSet = new SistemaEjemplo.HotelDataSet();
            this.hotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listMesTableAdapter = new SistemaEjemplo.HotelDataSet2TableAdapters.listMesTableAdapter();
            this.listYearTableAdapter = new SistemaEjemplo.HotelDataSet3TableAdapters.listYearTableAdapter();
            this.lblRecHabittxt = new System.Windows.Forms.Label();
            this.lblRecServtxt = new System.Windows.Forms.Label();
            this.lblRecServCant = new System.Windows.Forms.Label();
            this.lblRecHabitCant = new System.Windows.Forms.Label();
            this.lblComisionesCant = new System.Windows.Forms.Label();
            this.lblRecTotCant = new System.Windows.Forms.Label();
            this.lblComisiones = new System.Windows.Forms.Label();
            this.lblRecTottxt = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.LightGreen;
            this.cbMes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listMesBindingSource, "Column1", true));
            this.cbMes.DataSource = this.listMesBindingSource;
            this.cbMes.DisplayMember = "Column1";
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(34, 22);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 0;
            this.cbMes.ValueMember = "Column1";
            // 
            // listMesBindingSource
            // 
            this.listMesBindingSource.DataMember = "listMes";
            this.listMesBindingSource.DataSource = this.hotelDataSet2;
            // 
            // hotelDataSet2
            // 
            this.hotelDataSet2.DataSetName = "HotelDataSet2";
            this.hotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.LightGreen;
            this.cbYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listYearBindingSource, "Column1", true));
            this.cbYear.DataSource = this.listYearBindingSource;
            this.cbYear.DisplayMember = "Column1";
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(161, 22);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 1;
            this.cbYear.ValueMember = "Column1";
            // 
            // listYearBindingSource
            // 
            this.listYearBindingSource.DataMember = "listYear";
            this.listYearBindingSource.DataSource = this.hotelDataSet3;
            // 
            // hotelDataSet3
            // 
            this.hotelDataSet3.DataSetName = "HotelDataSet3";
            this.hotelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // listMesTableAdapter
            // 
            this.listMesTableAdapter.ClearBeforeFill = true;
            // 
            // listYearTableAdapter
            // 
            this.listYearTableAdapter.ClearBeforeFill = true;
            // 
            // lblRecHabittxt
            // 
            this.lblRecHabittxt.AutoSize = true;
            this.lblRecHabittxt.Location = new System.Drawing.Point(42, 88);
            this.lblRecHabittxt.Name = "lblRecHabittxt";
            this.lblRecHabittxt.Size = new System.Drawing.Size(155, 13);
            this.lblRecHabittxt.TabIndex = 2;
            this.lblRecHabittxt.Text = "Recaudaciones por habitación:";
            // 
            // lblRecServtxt
            // 
            this.lblRecServtxt.AutoSize = true;
            this.lblRecServtxt.Location = new System.Drawing.Point(42, 114);
            this.lblRecServtxt.Name = "lblRecServtxt";
            this.lblRecServtxt.Size = new System.Drawing.Size(145, 13);
            this.lblRecServtxt.TabIndex = 3;
            this.lblRecServtxt.Text = "Recaudaciones por servicio: ";
            // 
            // lblRecServCant
            // 
            this.lblRecServCant.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRecServCant.AutoSize = true;
            this.lblRecServCant.Location = new System.Drawing.Point(224, 114);
            this.lblRecServCant.Name = "lblRecServCant";
            this.lblRecServCant.Size = new System.Drawing.Size(46, 13);
            this.lblRecServCant.TabIndex = 5;
            this.lblRecServCant.Text = "-------------";
            this.lblRecServCant.Click += new System.EventHandler(this.lblRecServCant_Click);
            // 
            // lblRecHabitCant
            // 
            this.lblRecHabitCant.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRecHabitCant.AutoSize = true;
            this.lblRecHabitCant.Location = new System.Drawing.Point(224, 88);
            this.lblRecHabitCant.Name = "lblRecHabitCant";
            this.lblRecHabitCant.Size = new System.Drawing.Size(49, 13);
            this.lblRecHabitCant.TabIndex = 4;
            this.lblRecHabitCant.Text = "--------------";
            // 
            // lblComisionesCant
            // 
            this.lblComisionesCant.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblComisionesCant.AutoSize = true;
            this.lblComisionesCant.Location = new System.Drawing.Point(224, 171);
            this.lblComisionesCant.Name = "lblComisionesCant";
            this.lblComisionesCant.Size = new System.Drawing.Size(46, 13);
            this.lblComisionesCant.TabIndex = 9;
            this.lblComisionesCant.Text = "-------------";
            // 
            // lblRecTotCant
            // 
            this.lblRecTotCant.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRecTotCant.AutoSize = true;
            this.lblRecTotCant.Location = new System.Drawing.Point(224, 145);
            this.lblRecTotCant.Name = "lblRecTotCant";
            this.lblRecTotCant.Size = new System.Drawing.Size(49, 13);
            this.lblRecTotCant.TabIndex = 8;
            this.lblRecTotCant.Text = "--------------";
            // 
            // lblComisiones
            // 
            this.lblComisiones.AutoSize = true;
            this.lblComisiones.Location = new System.Drawing.Point(42, 171);
            this.lblComisiones.Name = "lblComisiones";
            this.lblComisiones.Size = new System.Drawing.Size(118, 13);
            this.lblComisiones.TabIndex = 7;
            this.lblComisiones.Text = "Comisiones Empleados:";
            // 
            // lblRecTottxt
            // 
            this.lblRecTottxt.AutoSize = true;
            this.lblRecTottxt.Location = new System.Drawing.Point(42, 145);
            this.lblRecTottxt.Name = "lblRecTottxt";
            this.lblRecTottxt.Size = new System.Drawing.Size(98, 13);
            this.lblRecTottxt.TabIndex = 6;
            this.lblRecTottxt.Text = "Recaudación Total";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGenerar.Location = new System.Drawing.Point(86, 49);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(158, 23);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Consultar Recaudaciones";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmRecaudaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(317, 254);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblComisionesCant);
            this.Controls.Add(this.lblRecTotCant);
            this.Controls.Add(this.lblComisiones);
            this.Controls.Add(this.lblRecTottxt);
            this.Controls.Add(this.lblRecServCant);
            this.Controls.Add(this.lblRecHabitCant);
            this.Controls.Add(this.lblRecServtxt);
            this.Controls.Add(this.lblRecHabittxt);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecaudaciones";
            this.Text = "frmRecaudaciones";
            this.Load += new System.EventHandler(this.frmRecaudaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbYear;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource hotelDataSetBindingSource;
        private HotelDataSet2 hotelDataSet2;
        private System.Windows.Forms.BindingSource listMesBindingSource;
        private HotelDataSet2TableAdapters.listMesTableAdapter listMesTableAdapter;
        private HotelDataSet3 hotelDataSet3;
        private System.Windows.Forms.BindingSource listYearBindingSource;
        private HotelDataSet3TableAdapters.listYearTableAdapter listYearTableAdapter;
        private System.Windows.Forms.Label lblRecHabittxt;
        private System.Windows.Forms.Label lblRecServtxt;
        private System.Windows.Forms.Label lblRecServCant;
        private System.Windows.Forms.Label lblRecHabitCant;
        private System.Windows.Forms.Label lblComisionesCant;
        private System.Windows.Forms.Label lblRecTotCant;
        private System.Windows.Forms.Label lblComisiones;
        private System.Windows.Forms.Label lblRecTottxt;
        private System.Windows.Forms.Button btnGenerar;
    }
}