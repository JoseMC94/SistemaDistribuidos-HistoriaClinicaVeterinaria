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
        private List<Diagnostico> listaDiagnostico = new List<Diagnostico>();


        public String AgregarDiagnotico(int dniDuenio,String enfermedad,String Medicina,int dniVet)
        {
            listaDiagnostico.Add(new Diagnostico() { dniDuenio = dniDuenio, Enfermedad = enfermedad, Medicina = Medicina, veterinario = dniVet });
            return "Dni Dueño"+ dniDuenio +"Enfermedad"+ enfermedad +"Medicina: "+Medicina + "Veterinario: "+dniVet;
        }
    }
}
