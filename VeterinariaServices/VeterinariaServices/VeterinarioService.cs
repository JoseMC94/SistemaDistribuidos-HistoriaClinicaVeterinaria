using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class VeterinarioService : IVeterinarioService
    {
        private HistoriaClinicaVeterinariaEntities1 bd = new HistoriaClinicaVeterinariaEntities1();
        //private List<Veterinario> listaVeterinario = new List<Veterinario>();

        public void AgregarVeterinario( string nombre, string apellido, string dni, string telefono, string direccion)
        {
            bd.DoctorVeterinario.Add(new DoctorVeterinario() {  nombre=nombre,apellido=apellido, dni = dni, telefono =telefono,direccion=direccion });
            bd.SaveChanges();

        }
    }
}
