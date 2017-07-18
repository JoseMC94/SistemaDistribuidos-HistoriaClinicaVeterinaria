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

        public string ConsultarHistoria(int dniDuenioo)
        {
            var historia = bd.HistoriaClinica.Find(dniDuenioo);

//            var diagnostico = listaCuenta.FirstOrDefault(x => x.dniDuenio == dniDuenioo);
            return historia == null ? "Historia Clinica no encontrada" : historia.dniDuenio+historia.idHistoriaClinica;

        }
    }
}
