namespace SistemaEjemplo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.catálogoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("habitacionesToolStripMenuItem.Image")));
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviciosToolStripMenuItem.Image")));
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservaToolStripMenuItem.Image")));
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoToolStripMenuItem.Image")));
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponibilidadHabitacionesToolStripMenuItem,
            this.recaudacionesToolStripMenuItem,
            this.agregarReservaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // disponibilidadHabitacionesToolStripMenuItem
            // 
            this.disponibilidadHabitacionesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.disponibilidadHabitacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disponibilidadHabitacionesToolStripMenuItem.Image")));
            this.disponibilidadHabitacionesToolStripMenuItem.Name = "disponibilidadHabitacionesToolStripMenuItem";
            this.disponibilidadHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.disponibilidadHabitacionesToolStripMenuItem.Text = "Disponibilidad Habitaciones";
            this.disponibilidadHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadHabitacionesToolStripMenuItem_Click);
            // 
            // recaudacionesToolStripMenuItem
            // 
            this.recaudacionesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.recaudacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recaudacionesToolStripMenuItem.Image")));
            this.recaudacionesToolStripMenuItem.Name = "recaudacionesToolStripMenuItem";
            this.recaudacionesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.recaudacionesToolStripMenuItem.Text = "Recaudaciones por mes";
            this.recaudacionesToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // agregarReservaToolStripMenuItem
            // 
            this.agregarReservaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarReservaToolStripMenuItem.Image")));
            this.agregarReservaToolStripMenuItem.Name = "agregarReservaToolStripMenuItem";
            this.agregarReservaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agregarReservaToolStripMenuItem.Text = "Agregar Reserva";
            this.agregarReservaToolStripMenuItem.Click += new System.EventHandler(this.agregarReservaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(825, 512);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
    }
}

