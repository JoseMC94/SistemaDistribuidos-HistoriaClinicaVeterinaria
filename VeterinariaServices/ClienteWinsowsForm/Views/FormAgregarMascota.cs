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
    public partial class FormAgregarMascota : Form
    {
        public FormAgregarMascota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var px = new proxyMascota.MascotaServiceClient();
            px.registarMascota(txtNombre.Text,txtRaza.Text,comboBox1.SelectedText,int.Parse(txtDuenio.Text));
            //px.RegistrarDuenio(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            lblRpt.Text = "Mascota Agregado";
        }
    }
}
