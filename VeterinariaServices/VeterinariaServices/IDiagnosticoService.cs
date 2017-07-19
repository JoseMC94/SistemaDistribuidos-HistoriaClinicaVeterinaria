using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceContract]
    interface IDiagnosticoService
    {

        [OperationContract]
        String AgregarDiagnotico( String enfermedad, String Medicina, int dniVeterinario, int idMascota);

    }
}
