using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class Paciente
    {
        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public String Sexo { get; set; }

        [DataMember]
        public String Raza { get; set; }
        [DataMember]
        public String NombreDuenio { get; set; }
        [DataMember]
        public String DireccionDuenio { get; set; }
        [DataMember]
        public String TelefonoDuenio { get; set; }
        [DataMember]
        public string DniDuenio { get; set; }
    }
}
