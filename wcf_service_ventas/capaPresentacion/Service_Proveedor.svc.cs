using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using capaNegocio;
namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service_Proveedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service_Proveedor.svc o Service_Proveedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service_Proveedor : IService_Proveedor
    {
        public DataTable BuscarNum_Documento(string textobuscar)
        {
            return N_Proveedor.BuscarNum_Documento(textobuscar);
        }

        public DataTable BuscarRazon_social(string textobuscar)
        {
            return N_Proveedor.BuscarRazon_social(textobuscar);
        }

        public string Editar(int iD_Proveedor, string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {
            return N_Proveedor.Editar(iD_Proveedor, razon_proveedor, sector_comercial, tipo_documento, num_documento, direccion, telefono, email, url);
        }

        public string Eliminar(int iD_Proveedor)
        {
            return N_Proveedor.Eliminar(iD_Proveedor);
        }

        public string Insertar(string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {
            return N_Proveedor.Insertar(razon_proveedor, sector_comercial, tipo_documento, num_documento, direccion, telefono, email, url);
        }

        public DataTable Mostrar()
        {
            return N_Proveedor.Mostrar();
        }
    }
}
