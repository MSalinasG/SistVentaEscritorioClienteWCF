using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService_Proveedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService_Proveedor
    {
        [OperationContract]
        string Insertar(string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento,
                    string direccion, string telefono, string email, string url);
        [OperationContract]
        string Editar(int iD_Proveedor, string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento,
            string direccion, string telefono, string email, string url);
        [OperationContract]
        string Eliminar(int iD_Proveedor);
        [OperationContract]
        DataTable Mostrar();
        [OperationContract]
        DataTable BuscarRazon_social(string textobuscar);
        [OperationContract]
        DataTable BuscarNum_Documento(string textobuscar);

    }
}
