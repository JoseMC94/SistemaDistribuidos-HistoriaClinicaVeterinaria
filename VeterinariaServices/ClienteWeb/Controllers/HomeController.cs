using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ConsultarDuenio(int dni)
        {
            var px = new proxyDuenio.DuenioServiceClient();
            var msg = "";
            var duenio = px.BuscarDuenio(dni);

            if (duenio == "No esta registrado")
            {
                msg = "Dueño No encontrado ";
            }
            else
            {
                msg = "Dueño encontrado\n" + duenio.ToString();
            }
            return Json("  " + msg.ToString(), JsonRequestBehavior.AllowGet);

        }


        public ActionResult RegistrarDuenio(int dni, string nombre, string apellido, string direccion, string telefono)
        {
            var msg = "";
            var px = new proxyDuenio.DuenioServiceClient();
            px.RegistrarDuenio(dni, nombre, apellido, direccion, telefono);
            msg = "usuario Agregado";
            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Duenio()
        {
            return View();
        }

        public ActionResult Mascota()
        {
            return View();
        }
        public ActionResult Mostrarinfo(int codigo)
        {
            var msg = "";
            var px = new proxyMascota.MascotaServiceClient();
            var mascota = px.MostrarInfoMascota(codigo);

            if (mascota == "Informacion de la Mascota no encontrada")
            {
                msg = "Informacion de la Mascota no encontrada";
            }
            else
            {
                msg = "Mascota encontrado\n" + mascota.ToString();
            }
            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult RegistrarMascota(string nombre, string raza, string sexo, int dni)
        {
            var msg = "";
            var px = new proxyMascota.MascotaServiceClient();
            px.registarMascota(nombre, raza, sexo, dni);
            //px.RegistrarDuenio(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            msg = "Mascota Agregado";
            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult HistoriaClinica()
        {
            return View();
        }

        public ActionResult HistoriaClinicaConsulta(int codigo)
        {
            var msg = "";
            var px = new proxyHistoriaClinica.HistoriaClinicaServiceClient();
            var historia = px.ConsultarHistoria(codigo);

            if (historia == "Historia Clinica no encontrada")
            {
                msg = "Informacion de la Historia no encontrada";
            }
            else
            {
                msg = "Historia encontrado\n" + historia.ToString();
            }
            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Cita()
        {
            return View();
        }

        public ActionResult AsignarCita(string hora, string fecha, int dni, string numeroConsultorio)
        {
            var msg = "";
            var px = new proxyCita.CitaServiceClient();
            px.AsignarCita(hora, fecha, dni, numeroConsultorio);
            //px.RegistrarDuenio(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            msg = "CITA AGREGADA";
            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Veterinario()
        {
            return View();
        }

        public ActionResult AgregarVeterinario(string nombre, string apellido, string dni, string telefono, string direccion)
        {
            var msg = "";

            var px = new proxyVeterinario.VeterinarioServiceClient();
            px.AgregarVeterinario(nombre, apellido, dni, telefono, direccion);
            //px.RegistrarDuenio(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            msg = "Veterinario AGREGADO";
            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Diagnostico()
        {

            return View();
        }

        public ActionResult agregarDiagnostico(string enfermedad,string medicina, int dniV,int Idmascota)
        {
            var msg = "";

            var px = new proxyDiagnostico.DiagnosticoServiceClient();
            px.AgregarDiagnotico( enfermedad,  medicina,  dniV,  Idmascota);
            //px.RegistrarDuenio(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            msg = "Diagnostico AGREGADo";

            return Json(" " + msg.ToString(), JsonRequestBehavior.AllowGet);
        }
    }
}