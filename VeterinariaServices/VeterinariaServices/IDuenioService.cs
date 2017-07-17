using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceContract]
    interface IDuenioService
    {
        [OperationContract]
        void RegistrarDuenio(String dni, String nombre, String direccion, String telefono);

       

        [OperationContract]
        String BuscarDuenio(string dniDuenio);

    }
}
