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
    public partial class BuscarHistoria : Form
    {
        public BuscarHistoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var px = new proxyHistoriaClinica.HistoriaClinicaServiceClient();
            var historia = px.ConsultarHistoria(int.Parse(txtIdMascota.Text));

            if (historia == "Historia Clinica no encontrada")
            {
                lblRespuesta.Text = "Informacion de la Historia no encontrada";
            }
            else
            {
                lblRespuesta.Text = "Historia encontrado\n" + historia.ToString();
            }
        }
    }
}
