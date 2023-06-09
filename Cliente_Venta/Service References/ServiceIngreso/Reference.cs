﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_Venta.ServiceIngreso {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceIngreso.IService_Ingreso")]
    public interface IService_Ingreso {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/Insertar", ReplyAction="http://tempuri.org/IService_Ingreso/InsertarResponse")]
        string Insertar(int idtrabajador, int idproveedor, System.DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado, System.Data.DataTable dtDetalles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/Insertar", ReplyAction="http://tempuri.org/IService_Ingreso/InsertarResponse")]
        System.Threading.Tasks.Task<string> InsertarAsync(int idtrabajador, int idproveedor, System.DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado, System.Data.DataTable dtDetalles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/Anular", ReplyAction="http://tempuri.org/IService_Ingreso/AnularResponse")]
        string Anular(int idingreso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/Anular", ReplyAction="http://tempuri.org/IService_Ingreso/AnularResponse")]
        System.Threading.Tasks.Task<string> AnularAsync(int idingreso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/Mostrar", ReplyAction="http://tempuri.org/IService_Ingreso/MostrarResponse")]
        System.Data.DataTable Mostrar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/Mostrar", ReplyAction="http://tempuri.org/IService_Ingreso/MostrarResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MostrarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/BuscarFechas", ReplyAction="http://tempuri.org/IService_Ingreso/BuscarFechasResponse")]
        System.Data.DataTable BuscarFechas(string textobuscar, string textobuscar2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/BuscarFechas", ReplyAction="http://tempuri.org/IService_Ingreso/BuscarFechasResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> BuscarFechasAsync(string textobuscar, string textobuscar2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/MostrarDetalle", ReplyAction="http://tempuri.org/IService_Ingreso/MostrarDetalleResponse")]
        System.Data.DataTable MostrarDetalle(string textobuscar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Ingreso/MostrarDetalle", ReplyAction="http://tempuri.org/IService_Ingreso/MostrarDetalleResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MostrarDetalleAsync(string textobuscar);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_IngresoChannel : Cliente_Venta.ServiceIngreso.IService_Ingreso, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_IngresoClient : System.ServiceModel.ClientBase<Cliente_Venta.ServiceIngreso.IService_Ingreso>, Cliente_Venta.ServiceIngreso.IService_Ingreso {
        
        public Service_IngresoClient() {
        }
        
        public Service_IngresoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_IngresoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_IngresoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_IngresoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Insertar(int idtrabajador, int idproveedor, System.DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado, System.Data.DataTable dtDetalles) {
            return base.Channel.Insertar(idtrabajador, idproveedor, fecha, tipo_comprobante, serie, correlativo, igv, estado, dtDetalles);
        }
        
        public System.Threading.Tasks.Task<string> InsertarAsync(int idtrabajador, int idproveedor, System.DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado, System.Data.DataTable dtDetalles) {
            return base.Channel.InsertarAsync(idtrabajador, idproveedor, fecha, tipo_comprobante, serie, correlativo, igv, estado, dtDetalles);
        }
        
        public string Anular(int idingreso) {
            return base.Channel.Anular(idingreso);
        }
        
        public System.Threading.Tasks.Task<string> AnularAsync(int idingreso) {
            return base.Channel.AnularAsync(idingreso);
        }
        
        public System.Data.DataTable Mostrar() {
            return base.Channel.Mostrar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MostrarAsync() {
            return base.Channel.MostrarAsync();
        }
        
        public System.Data.DataTable BuscarFechas(string textobuscar, string textobuscar2) {
            return base.Channel.BuscarFechas(textobuscar, textobuscar2);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> BuscarFechasAsync(string textobuscar, string textobuscar2) {
            return base.Channel.BuscarFechasAsync(textobuscar, textobuscar2);
        }
        
        public System.Data.DataTable MostrarDetalle(string textobuscar) {
            return base.Channel.MostrarDetalle(textobuscar);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MostrarDetalleAsync(string textobuscar) {
            return base.Channel.MostrarDetalleAsync(textobuscar);
        }
    }
}
