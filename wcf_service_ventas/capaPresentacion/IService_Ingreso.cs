using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService_Ingreso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService_Ingreso
    {
        [OperationContract]
        string Insertar(int idtrabajador, int idproveedor, DateTime fecha,
                  string tipo_comprobante, string serie, string correlativo, decimal igv,
                  string estado, DataTable dtDetalles);

        [OperationContract]
        string Anular(int idingreso);

        [OperationContract]
        DataTable Mostrar();

        [OperationContract]
        DataTable BuscarFechas(string textobuscar, string textobuscar2);

        [OperationContract]
        DataTable MostrarDetalle(string textobuscar);
    }
}

