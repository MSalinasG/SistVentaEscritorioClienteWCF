using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Articulo" in both code and config file together.
    [ServiceContract]
    public interface IService_Articulo
    {
        [OperationContract]
        string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion);

        [OperationContract]
        string Editar(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion);

        [OperationContract]
        string Eliminar(int idarticulo);

        [OperationContract]
        DataTable Mostrar();

        [OperationContract]
        DataTable BuscarNombre(string textobuscar);

        [OperationContract]
        DataTable Stock_Articulos();
         

    }
}
