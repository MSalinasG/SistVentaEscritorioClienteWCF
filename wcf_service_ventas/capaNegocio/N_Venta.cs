using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class N_Venta
    {
        public static string Insertar(int idcliente, int idtrabajador, DateTime fecha,
           string tipo_comprobante, string serie, string correlativo, decimal igv,
           DataTable dtDetalles)
        {
            D_Venta Obj = new D_Venta();
            Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            List<D_Detalle_Venta> detalles = new List<D_Detalle_Venta>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                D_Detalle_Venta detalle = new D_Detalle_Venta();
                detalle.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public static string Eliminar(int iD_Venta)
        {
            D_Venta Obj = new D_Venta();
            Obj.Idventa = iD_Venta;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new D_Venta().Mostrar();
        }

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            D_Venta Obj = new D_Venta();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalle(string textobuscar)
        {
            D_Venta Obj = new D_Venta();
            return Obj.MostrarDetalle(textobuscar);
        }
        public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            D_Venta Obj = new D_Venta();
            return Obj.MostrarArticulo_Venta_Nombre(textobuscar);
        }
        public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            D_Venta Obj = new D_Venta();
            return Obj.MostrarArticulo_Venta_codigo(textobuscar);
        }

        public static DataTable MostrarArticulo_Venta()
        {
            D_Venta obj = new D_Venta();
            return obj.MostrarArticulo_Venta();
        }
    }
}
