using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class DuenioService : IDuenioService
    {

        private List<Duenio> listaDuenio = new List<Duenio>();

        public string BuscarDuenio(string dniDuenio)
        {
            var duenio = listaDuenio.FirstOrDefault(x => x.dni == dniDuenio);
            return duenio == null ? "No esta registrado" : duenio.dni+" existe";

        }

        public void RegistrarDuenio(string dni, string nombre, string direccion, string telefono)
        {
            listaDuenio.Add(new Duenio() { dni = dni, nombre = nombre, direccion = direccion, telefono = telefono });

        }
    }
}
