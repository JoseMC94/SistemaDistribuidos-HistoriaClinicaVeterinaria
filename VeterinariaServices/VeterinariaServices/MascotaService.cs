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
        public string MostrarInfoMascota(int dniDuenio)
        {
            var mascota = bd.Mascota.Where(c => c.dniDuenio == dniDuenio).First();
            //var mascota = bd.Mascota.Find(dniDuenio);
            //return duenio == null ? "No esta registrado" : duenio.dni + " existe";
            return mascota == null ? "Informacion de la Mascota no encontrada" : mascota.nombre;
        }
        

        public void registarMascota(string nombre, string raza, string sexo, int dniDuenio)
        {
            bd.Mascota.Add(new Mascota() { nombre = nombre, raza = raza, sexo = sexo, dniDuenio = dniDuenio });
            bd.SaveChangesAsync();
            //listaMascota.Add(new Mascota() { Nombre = nombre,Raza=raza,Sexo=sexo,dniDuenio=dniDuenio  });

        }

        
    }
}
