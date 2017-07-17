using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class Duenio
    {
        [DataMember]
        public int idDuenio { get; set; }
        [DataMember]
        public String dni { get; set; }
        [DataMember]
        public String nombre { get; set; }
        [DataMember]
        public String telefono { get; set; }
        [DataMember]
        public String direccion { get; set; }

    }
}
