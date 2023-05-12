using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class N_Proveedor
    {
        public static string Insertar(string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento,
                    string direccion, string telefono, string email, string url)
        {
            D_Proveedor Obj = new D_Proveedor();
            Obj.Razon_Social = razon_proveedor;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int iD_Proveedor, string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento,
            string direccion, string telefono, string email, string url)
        {
            D_Proveedor Obj = new D_Proveedor();
            Obj.ID_Proveedor = iD_Proveedor;
            Obj.Razon_Social = razon_proveedor;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int iD_Proveedor)
        {
            D_Proveedor Obj = new D_Proveedor();
            Obj.ID_Proveedor = iD_Proveedor;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new D_Proveedor().Mostrar();
        }

        public static DataTable BuscarRazon_social(string textobuscar)
        {
            D_Proveedor Obj = new D_Proveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            D_Proveedor Obj = new D_Proveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
