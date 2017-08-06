namespace ClienteWinsowsForm.Views
{
    partial class FormAsignarCita
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNumeroC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "numeroConsultorio";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(243, 95);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(218, 20);
            this.txtHora.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(243, 127);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(218, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtNumeroC
            // 
            this.txtNumeroC.Location = new System.Drawing.Point(243, 161);
            this.txtNumeroC.Name = "txtNumeroC";
            this.txtNumeroC.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroC.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(240, 246);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.lblRespuesta.TabIndex = 10;
            this.lblRespuesta.Text = "label5";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(243, 55);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(218, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // FormAsignarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 298);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumeroC);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAsignarCita";
            this.Text = "FormAsignarCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNumeroC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtFecha;
    }
}