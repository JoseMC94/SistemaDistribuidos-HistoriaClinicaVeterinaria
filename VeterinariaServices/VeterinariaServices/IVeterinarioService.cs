using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceContract]
    interface IVeterinarioService
    {
        [OperationContract]
        void AgregarVeterinario(String nombre, String apellido, String dni, String telefono, String direccion);
    }
}
