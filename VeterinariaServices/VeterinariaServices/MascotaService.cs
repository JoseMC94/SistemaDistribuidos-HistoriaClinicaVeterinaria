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
        private List<Mascota> listaMascota = new List<Mascota>();
        public string MostrarInfoMascota(string dniDuenio)
        {
            var mascota = listaMascota.FirstOrDefault(x => x.dniDuenio == dniDuenio);
            return mascota  == null ? "Historia Clinica no encontrada" : mascota.Nombre+mascota.Raza+mascota.Sexo;

        }

        public void registarMascota(string nombre, string raza, string sexo,string dniDuenio)
        {
            listaMascota.Add(new Mascota() { Nombre = nombre,Raza=raza,Sexo=sexo,dniDuenio=dniDuenio  });

        }

        
    }
}
