namespace ClienteWinsowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veterinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDueñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDueñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVeterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinariaToolStripMenuItem,
            this.mascotaToolStripMenuItem,
            this.historiaClinicaToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.veterinarioToolStripMenuItem,
            this.diagnosticoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veterinariaToolStripMenuItem
            // 
            this.veterinariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDueñoToolStripMenuItem,
            this.buscarDueñoToolStripMenuItem});
            this.veterinariaToolStripMenuItem.Name = "veterinariaToolStripMenuItem";
            this.veterinariaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.veterinariaToolStripMenuItem.Text = "Dueño";
            this.veterinariaToolStripMenuItem.Click += new System.EventHandler(this.veterinariaToolStripMenuItem_Click);
            // 
            // registrarDueñoToolStripMenuItem
            // 
            this.registrarDueñoToolStripMenuItem.Name = "registrarDueñoToolStripMenuItem";
            this.registrarDueñoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.registrarDueñoToolStripMenuItem.Text = "Registrar Dueño";
            this.registrarDueñoToolStripMenuItem.Click += new System.EventHandler(this.registrarDueñoToolStripMenuItem_Click);
            // 
            // buscarDueñoToolStripMenuItem
            // 
            this.buscarDueñoToolStripMenuItem.Name = "buscarDueñoToolStripMenuItem";
            this.buscarDueñoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buscarDueñoToolStripMenuItem.Text = "Buscar Dueño";
            this.buscarDueñoToolStripMenuItem.Click += new System.EventHandler(this.buscarDueñoToolStripMenuItem_Click);
            // 
            // mascotaToolStripMenuItem
            // 
            this.mascotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMascotaToolStripMenuItem,
            this.mostrarMascotaToolStripMenuItem});
            this.mascotaToolStripMenuItem.Name = "mascotaToolStripMenuItem";
            this.mascotaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mascotaToolStripMenuItem.Text = "Mascota";
            // 
            // registrarMascotaToolStripMenuItem
            // 
            this.registrarMascotaToolStripMenuItem.Name = "registrarMascotaToolStripMenuItem";
            this.registrarMascotaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarMascotaToolStripMenuItem.Text = "Registrar Mascota";
            this.registrarMascotaToolStripMenuItem.Click += new System.EventHandler(this.registrarMascotaToolStripMenuItem_Click);
            // 
            // mostrarMascotaToolStripMenuItem
            // 
            this.mostrarMascotaToolStripMenuItem.Name = "mostrarMascotaToolStripMenuItem";
            this.mostrarMascotaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mostrarMascotaToolStripMenuItem.Text = "Mostrar Mascota";
            this.mostrarMascotaToolStripMenuItem.Click += new System.EventHandler(this.mostrarMascotaToolStripMenuItem_Click);
            // 
            // historiaClinicaToolStripMenuItem
            // 
            this.historiaClinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            this.historiaClinicaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.historiaClinicaToolStripMenuItem.Text = "Historia Clinica";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarCitaToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // asignarCitaToolStripMenuItem
            // 
            this.asignarCitaToolStripMenuItem.Name = "asignarCitaToolStripMenuItem";
            this.asignarCitaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asignarCitaToolStripMenuItem.Text = "Asignar Cita";
            this.asignarCitaToolStripMenuItem.Click += new System.EventHandler(this.asignarCitaToolStripMenuItem_Click);
            // 
            // veterinarioToolStripMenuItem
            // 
            this.veterinarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVeterinarioToolStripMenuItem});
            this.veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            this.veterinarioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.veterinarioToolStripMenuItem.Text = "Veterinario";
            // 
            // registrarVeterinarioToolStripMenuItem
            // 
            this.registrarVeterinarioToolStripMenuItem.Name = "registrarVeterinarioToolStripMenuItem";
            this.registrarVeterinarioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.registrarVeterinarioToolStripMenuItem.Text = "registrar Veterinario";
            this.registrarVeterinarioToolStripMenuItem.Click += new System.EventHandler(this.registrarVeterinarioToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDiagnosticoToolStripMenuItem});
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            // 
            // agregarDiagnosticoToolStripMenuItem
            // 
            this.agregarDiagnosticoToolStripMenuItem.Name = "agregarDiagnosticoToolStripMenuItem";
            this.agregarDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarDiagnosticoToolStripMenuItem.Text = "Agregar Diagnostico";
            this.agregarDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.agregarDiagnosticoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Historia Clinica de Veterinaria - UNSC  - SSDD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veterinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDueñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarDueñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVeterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDiagnosticoToolStripMenuItem;
    }
}

