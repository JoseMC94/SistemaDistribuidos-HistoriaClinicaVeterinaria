using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class DiagnosticoService : IDiagnosticoService
    {
        private HistoriaClinicaVeterinariaEntities1 bd = new HistoriaClinicaVeterinariaEntities1();
        // private List<Diagnostico> listaDiagnostico = new List<Diagnostico>();


        public String AgregarDiagnotico( String enfermedad, String Medicina, int dniVeterinario, int idMascota)
        {
            bd.Diagnostico.Add(new Diagnostico()
            {
                enfermedad = enfermedad,
                medicina = Medicina,
                dniVeterianrio = dniVeterinario,
                idmascota = idMascota

            });
            bd.SaveChanges();
            return "Enfermedad" + enfermedad + "Medicina: " + Medicina + "Veterinario: " + dniVeterinario;
        }
    }
}
