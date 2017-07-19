using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class HistoriaClinicaService : IHistoriaClinicaService
    {
        private HistoriaClinicaVeterinariaEntities1 bd = new HistoriaClinicaVeterinariaEntities1();
        //private List<Diagnostico> listaCuenta = new List<Diagnostico>();

        public string ConsultarHistoria(int idMascota)
        {
            var mascota = bd.Diagnostico.Where(c => c.idmascota == idMascota).First();
            //var historia = bd.Diagnostico.Find(dniDuenioo);

//            var diagnostico = listaCuenta.FirstOrDefault(x => x.dniDuenio == dniDuenioo);
            return mascota == null ? "Historia Clinica no encontrada" : ""+mascota.dniVeterianrio+mascota.enfermedad+mascota.medicina;

        }
    }
}
