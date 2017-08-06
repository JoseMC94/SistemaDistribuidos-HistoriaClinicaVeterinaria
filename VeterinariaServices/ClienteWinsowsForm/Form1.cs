using ClienteWinsowsForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWinsowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void veterinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registrarDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDuenio frm = new AgregarDuenio();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void buscarDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarDuenio frm = new FormBuscarDuenio();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void registrarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarMascota frm = new FormAgregarMascota();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void mostrarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarInfoMascota frm = new FormMostrarInfoMascota();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarHistoria frm = new BuscarHistoria();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void registrarVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignarVeterinario frm = new FormAsignarVeterinario();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void asignarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignarCita frm = new FormAsignarCita();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void agregarDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiagnostico frm = new FormDiagnostico();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
