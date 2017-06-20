using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class Cita
    {


        [DataMember]
        public int idCita { get; set; }

        [DataMember]
        public String horaCita { get; set; }

        [DataMember]
        public String fechaCita { get; set; }

        [DataMember]
        public int idPaciente { get; set; }

        public int consultorio { get; set; }
    }
}
