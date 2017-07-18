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
        public int AsignarCita(int dniD,String fechaC,String horaC,int numC)
        {
            bd.Cita.Add(new Cita() { dniDuenio = dniD, fecha = fechaC, hora = horaC, numeroConsultorio = ""+numC });
            bd.SaveChanges();
            //listaCita.Add(new Cita() {dniDuenio = dniD, fechaCita = fechaC,horaCita=horaC,numConsultorio=numC });
            return numC;
        }
    }
}
