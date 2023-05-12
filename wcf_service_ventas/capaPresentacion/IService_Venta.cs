using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService_Venta" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService_Venta
    {
        [OperationContract]
        string Insertar(int idcliente, int idtrabajador, DateTime fecha,
           string tipo_comprobante, string serie, string correlativo, decimal igv,
           DataTable dtDetalles);

        [OperationContract]
        string Eliminar(int iD_Venta);

        [OperationContract]
        DataTable Mostrar();

        [OperationContract]
        DataTable BuscarFechas(string textobuscar, string textobuscar2);

        [OperationContract]
        DataTable MostrarDetalle(string textobuscar);

        [OperationContract]
        DataTable MostrarArticulo_Venta_Nombre(string textobuscar);

        [OperationContract]
        DataTable MostrarArticulo_Venta_Codigo(string textobuscar);

        [OperationContract]
        DataTable MostrarArticulo_Venta();
    }
}
