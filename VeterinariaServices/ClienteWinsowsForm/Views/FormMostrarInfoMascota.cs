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
    public partial class FormMostrarInfoMascota : Form
    {
        public FormMostrarInfoMascota()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var px = new proxyMascota.MascotaServiceClient();
            var mascota = px.MostrarInfoMascota(int.Parse(txtCodigo.Text));

            if (mascota == "Informacion de la Mascota no encontrada")
            {
                lblRespuesta.Text = "Informacion de la Mascota no encontrada";
            }
            else
            {
                lblRespuesta.Text = "Mascota encontrado\n" + mascota.ToString();
            }
        }
    }
}
