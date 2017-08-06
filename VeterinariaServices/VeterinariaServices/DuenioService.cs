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
        private HistoriaClinicaVeterinariaEntities1 bd = new HistoriaClinicaVeterinariaEntities1();
        //private List<Duenio> listaDuenio = new List<Duenio>();

        public string BuscarDuenio(int dniDuenio)
        {
            //var duenio = listaDuenio.FirstOrDefault(x => x.dni == dniDuenio);
            var duenio = bd.Duenio.Find(dniDuenio);
            return duenio == null ? "No esta registrado" : "DNI: "+duenio.dni+" \nNombre : "+duenio.nombre+"\nApellido : "+duenio.apellido;

        }

        public void RegistrarDuenio(int dni, string nombre,string apellido, string direccion, string telefono)
        {
            //listaDuenio.Add(new Duenio() { dni = dni, nombre = nombre, direccion = direccion, telefono = telefono });
            bd.Duenio.Add(new Duenio() { dni = dni, nombre = nombre,apellido=apellido, direccion = direccion, telefono = telefono });
            bd.SaveChanges();
        }
    }
}
