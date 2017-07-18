using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class MascotaService : IMascotaService
    {
        private HistoriaClinicaVeterinariaEntities1 bd = new HistoriaClinicaVeterinariaEntities1();
        //private List<Mascota> listaMascota = new List<Mascota>();
        public string MostrarInfoMascota(string dniDuenio)
        {
            var mascota = bd.Mascota.Find(dniDuenio);
            return mascota  == null ? "Historia Clinica no encontrada" : mascota.nombre+mascota.raza+mascota.sexo;

        }

        public void registarMascota(string nombre, string raza, string sexo, string dniDuenio)
        {
            bd.Mascota.Add(new Mascota() { nombre = nombre, raza = raza, sexo = sexo, dniDuenio = Int32.Parse(dniDuenio) });
            //listaMascota.Add(new Mascota() { Nombre = nombre,Raza=raza,Sexo=sexo,dniDuenio=dniDuenio  });

        }

        
    }
}
