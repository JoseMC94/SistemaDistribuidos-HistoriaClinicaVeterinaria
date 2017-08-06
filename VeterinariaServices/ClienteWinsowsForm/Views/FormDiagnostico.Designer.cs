namespace ClienteWinsowsForm.Views
{
    partial class FormDiagnostico
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
            this.Enfermedad = new System.Windows.Forms.Label();
            this.Medicina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.txtMedicina = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enfermedad
            // 
            this.Enfermedad.AutoSize = true;
            this.Enfermedad.Location = new System.Drawing.Point(99, 43);
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.Size = new System.Drawing.Size(64, 13);
            this.Enfermedad.TabIndex = 0;
            this.Enfermedad.Text = "Enfermedad";
            // 
            // Medicina
            // 
            this.Medicina.AutoSize = true;
            this.Medicina.Location = new System.Drawing.Point(113, 72);
            this.Medicina.Name = "Medicina";
            this.Medicina.Size = new System.Drawing.Size(50, 13);
            this.Medicina.TabIndex = 1;
            this.Medicina.Text = "Medicina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI Vetrinario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Mascota";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(248, 222);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.lblRespuesta.TabIndex = 4;
            this.lblRespuesta.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(184, 43);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(168, 20);
            this.txtEnfermedad.TabIndex = 6;
            // 
            // txtMedicina
            // 
            this.txtMedicina.Location = new System.Drawing.Point(184, 72);
            this.txtMedicina.Name = "txtMedicina";
            this.txtMedicina.Size = new System.Drawing.Size(168, 20);
            this.txtMedicina.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(184, 101);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(168, 20);
            this.txtDni.TabIndex = 8;
            // 
            // txtMascota
            // 
            this.txtMascota.Location = new System.Drawing.Point(184, 134);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(168, 20);
            this.txtMascota.TabIndex = 9;
            // 
            // FormDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.txtMascota);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtMedicina);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Medicina);
            this.Controls.Add(this.Enfermedad);
            this.Name = "FormDiagnostico";
            this.Text = "FormDiagnostico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enfermedad;
        private System.Windows.Forms.Label Medicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.TextBox txtMedicina;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtMascota;
    }
}