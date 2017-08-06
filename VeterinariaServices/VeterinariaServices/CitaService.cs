using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices
{
    [ServiceBehavior (InstanceContextMode = InstanceContextMode.Single)]
    class CitaService : ICitaService
    {

        // private List<Cita> listaCita = new List<Cita>();
        private HistoriaClinicaVeterinariaEntities1 bd = new HistoriaClinicaVeterinariaEntities1();
        public String AsignarCita(string horaC, string fechaC, int dniD,string numC)
        {
            bd.Cita.Add(new Cita() { hora = horaC, fecha = fechaC, dniDuenio = dniD,   numeroConsultorio = numC });
            bd.SaveChangesAsync();
            //listaCita.Add(new Cita() {dniDuenio = dniD, fechaCita = fechaC,horaCita=horaC,numConsultorio=numC });
            return numC;
        }
    }
}
