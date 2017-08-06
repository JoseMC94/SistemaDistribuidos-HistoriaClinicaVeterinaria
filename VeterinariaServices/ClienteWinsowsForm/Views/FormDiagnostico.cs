using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWinsowsForm.Views
{
    public partial class FormDiagnostico : Form
    {
        public FormDiagnostico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var px = new proxyDiagnostico.DiagnosticoServiceClient();
            px.AgregarDiagnotico(txtEnfermedad.Text, txtMedicina.Text, int.Parse(txtDni.Text), int.Parse(txtMascota.Text));
            //px.RegistrarDuenio(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            lblRespuesta.Text = "Diagnostico AGREGADo";
        }
    }
}
