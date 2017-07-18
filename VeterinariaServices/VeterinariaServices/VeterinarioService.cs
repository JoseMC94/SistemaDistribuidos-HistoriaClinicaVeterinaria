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

        public void AgregarVeterinario(String dni, string nombre, string apellido, string telefono, string direccion)
        {
            bd.Veterinario.Add(new Veterinario() { dniVeterinario= dni, nombre=nombre,apellido=apellido,telefono=telefono,direccion=direccion });
        }
    }
}
