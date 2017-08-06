﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWinsowsForm.proxyMascota {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="proxyMascota.IMascotaService")]
    public interface IMascotaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMascotaService/registarMascota", ReplyAction="http://tempuri.org/IMascotaService/registarMascotaResponse")]
        void registarMascota(string nombre, string raza, string sexo, int dniDuenio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMascotaService/registarMascota", ReplyAction="http://tempuri.org/IMascotaService/registarMascotaResponse")]
        System.Threading.Tasks.Task registarMascotaAsync(string nombre, string raza, string sexo, int dniDuenio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMascotaService/MostrarInfoMascota", ReplyAction="http://tempuri.org/IMascotaService/MostrarInfoMascotaResponse")]
        string MostrarInfoMascota(int dniDuenio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMascotaService/MostrarInfoMascota", ReplyAction="http://tempuri.org/IMascotaService/MostrarInfoMascotaResponse")]
        System.Threading.Tasks.Task<string> MostrarInfoMascotaAsync(int dniDuenio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMascotaServiceChannel : ClienteWinsowsForm.proxyMascota.IMascotaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MascotaServiceClient : System.ServiceModel.ClientBase<ClienteWinsowsForm.proxyMascota.IMascotaService>, ClienteWinsowsForm.proxyMascota.IMascotaService {
        
        public MascotaServiceClient() {
        }
        
        public MascotaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MascotaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MascotaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MascotaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void registarMascota(string nombre, string raza, string sexo, int dniDuenio) {
            base.Channel.registarMascota(nombre, raza, sexo, dniDuenio);
        }
        
        public System.Threading.Tasks.Task registarMascotaAsync(string nombre, string raza, string sexo, int dniDuenio) {
            return base.Channel.registarMascotaAsync(nombre, raza, sexo, dniDuenio);
        }
        
        public string MostrarInfoMascota(int dniDuenio) {
            return base.Channel.MostrarInfoMascota(dniDuenio);
        }
        
        public System.Threading.Tasks.Task<string> MostrarInfoMascotaAsync(int dniDuenio) {
            return base.Channel.MostrarInfoMascotaAsync(dniDuenio);
        }
    }
}
