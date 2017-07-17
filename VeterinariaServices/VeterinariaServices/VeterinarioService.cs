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
        private List<Veterinario> listaVeterinario = new List<Veterinario>();

        public void AgregarVeterinario(int dni, string nombre, string apellido, string telefono, string direccion)
        {
            listaVeterinario.Add(new Veterinario() { Dni=dni, Nombre=nombre,Apellido=apellido,telefono=telefono,Direccion=direccion });
        }
    }
}
