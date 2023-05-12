using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class N_Categoria
    {
 
        public static string Insertar(string nombre, string descripcion)
        {
            D_Categoria Obj = new D_Categoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }
 
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            D_Categoria Obj = new D_Categoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }
 
        public static string Eliminar(int idcategoria)
        {
            D_Categoria Obj = new D_Categoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }
 
        public static DataTable Mostrar()
        {
            return new D_Categoria().Mostrar();
        }
 
        public static DataTable BuscarNombre(string textobuscar)
        {
            D_Categoria Obj = new D_Categoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
