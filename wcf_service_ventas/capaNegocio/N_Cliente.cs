using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class N_Cliente
    {
        public static DataTable Mostrar()
        {
            return new D_Cliente().Mostrar();
        } 

        public static DataTable BuscarApellidos(string textobuscar)
        {
            D_Cliente Obj = new D_Cliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        } 
         
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            D_Cliente Obj = new D_Cliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
