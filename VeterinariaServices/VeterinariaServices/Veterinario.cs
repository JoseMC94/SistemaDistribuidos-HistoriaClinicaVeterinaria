using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class Veterinario
    {
        [DataMember]
        public int idMedico { set; get; }

        [DataMember]
        public String Nombre { set; get; }

        [DataMember]
        public String Apellido { set; get; }

        [DataMember]
        public int Dni { set; get; }

        [DataMember]
        public String telefono { set; get; }

        [DataMember]
        public String Direccion { set; get; }

    }
}
