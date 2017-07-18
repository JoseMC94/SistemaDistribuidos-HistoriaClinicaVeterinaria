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
        void RegistrarDuenio(int dni, String nombre, String direccion, String telefono);

       

        [OperationContract]
        String BuscarDuenio(int dniDuenio);

    }
}
