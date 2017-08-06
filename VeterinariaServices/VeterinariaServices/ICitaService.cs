using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceContract]
    interface ICitaService
    {
        [OperationContract]
        String AsignarCita(String horaC, String fechaC, int dniD,  String numC); 
    }
}
