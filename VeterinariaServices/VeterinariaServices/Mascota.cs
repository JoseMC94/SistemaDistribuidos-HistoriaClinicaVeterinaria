using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class Mascota
    {
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public String Raza { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String dniDuenio { get; set; }
    }
}
