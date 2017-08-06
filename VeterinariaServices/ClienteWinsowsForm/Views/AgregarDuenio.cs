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
    public partial class AgregarDuenio : Form
    {
        public AgregarDuenio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var px = new proxyDuenio.DuenioServiceClient();
            px.RegistrarDuenio(int.Parse(txtDni.Text),txtNombre.Text,txtApellido.Text,txtDireccion.Text,txtTelefono.Text);
            lblRpt.Text = "usuario Agregado";
        }
    }
}
