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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Articulo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Articulo.svc or Service_Articulo.svc.cs at the Solution Explorer and start debugging.
    public class Service_Articulo : IService_Articulo
    {
        public DataTable BuscarNombre(string textobuscar)
        {
            return N_Articulo.BuscarNombre(textobuscar);
        }

        public string Editar(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            return N_Articulo.Editar(idarticulo, codigo, nombre, descripcion, imagen, idcategoria, idpresentacion);
        }

        public string Eliminar(int idarticulo)
        {
            return N_Articulo.Eliminar(idarticulo);
        }

        public string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            return N_Articulo.Insertar(codigo, nombre, descripcion, imagen, idcategoria, idpresentacion);
        }

        public DataTable Mostrar()
        {
            return N_Articulo.Mostrar();
        }

        public DataTable Stock_Articulos()
        {
            return N_Articulo.Stock_Articulos();
        }
    }
}
