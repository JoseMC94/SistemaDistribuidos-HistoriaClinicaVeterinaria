using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class Diagnostico
    {
        [DataMember]
        public int idDiagnostico { get; set; }

        [DataMember]
        public int dniDuenio { get; set; }

        [DataMember]
        public String Enfermedad { get; set; }

        [DataMember]
        public String Medicina { get; set; }

        [DataMember]
        public int dniDoctor { get; set; }



    }
}
