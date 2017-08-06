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
    public partial class FormBuscarDuenio : Form
    {
        public FormBuscarDuenio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var px = new proxyDuenio.DuenioServiceClient();
            var duenio = px.BuscarDuenio(int.Parse(txtDni.Text));
            
            if (duenio == "No esta registrado") {
                lblResultado.Text = "Dueño No encontrado ";
            }
            else
            {
                lblResultado.Text = "Dueño encontrado\n"+duenio.ToString();
            }
        }
    }
}
