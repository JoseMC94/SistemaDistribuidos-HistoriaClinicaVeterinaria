using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceContract]
    interface IMascotaService
    {
        [OperationContract]
        void registarMascota(String nombre,String raza,String sexo,int dniDuenio);
        [OperationContract]
        String MostrarInfoMascota(int dniDuenio);

    }
}
