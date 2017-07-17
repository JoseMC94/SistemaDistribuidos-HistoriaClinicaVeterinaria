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
        private List<Diagnostico> listaCuenta = new List<Diagnostico>();

        public string ConsultarHistoria(int dniDuenioo)
        {
            var diagnostico = listaCuenta.FirstOrDefault(x => x.dniDuenio == dniDuenioo);
            return diagnostico == null ? "Historia Clinica no encontrada" : diagnostico.dniDuenio+diagnostico.Enfermedad+diagnostico.Medicina+diagnostico.veterinario;

        }
    }
}
