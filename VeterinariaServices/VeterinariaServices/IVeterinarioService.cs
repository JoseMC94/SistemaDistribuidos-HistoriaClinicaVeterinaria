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
        void AgregarVeterinario(int dni,String nombre, String apellido,String telefono, String direccion);
    }
}
