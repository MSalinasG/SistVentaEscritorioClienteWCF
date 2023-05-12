using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class N_Articulo
    {
 
        public static string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            D_Articulo Obj = new D_Articulo();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;

            return Obj.Insertar(Obj);
        }

         
        public static string Editar(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            D_Articulo Obj = new D_Articulo();
            Obj.Idarticulo = idarticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            return Obj.Editar(Obj);
        }

         
        public static string Eliminar(int idarticulo)
        {
            D_Articulo Obj = new D_Articulo();
            Obj.Idarticulo = idarticulo;
            return Obj.Eliminar(Obj);
        }

       
        public static DataTable Mostrar()
        {
            return new D_Articulo().Mostrar();
        }
         

        public static DataTable BuscarNombre(string textobuscar)
        {
            D_Articulo Obj = new D_Articulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
        public static DataTable Stock_Articulos()
        {
            return new D_Articulo().Stock_Articulos();
        }
         
    }
}
