using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [DataContract]
    class HistoriaClinica
    {

        public int Dni { get; set; }

        public int idDiagnostico { get; set; }

    }
}
