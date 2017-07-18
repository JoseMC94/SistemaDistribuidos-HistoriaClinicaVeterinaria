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


        public String AgregarDiagnotico(int dniVeterinario, String enfermedad, String Medicina, String idMascota)
        {
            bd.Diagnostico.Add(new Diagnostico()
            {
                dniVeterianrio = dniVeterinario,
                enfermedad = enfermedad,
                medicina = Medicina,
                idmascota = Int32.Parse(idMascota)

            });
            bd.SaveChanges();
            return "Enfermedad" + enfermedad + "Medicina: " + Medicina + "Veterinario: " + dniVeterinario;
        }
    }
}
