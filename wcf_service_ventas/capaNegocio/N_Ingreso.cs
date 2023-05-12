using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class N_Ingreso
    {
        public static string Insertar(int idtrabajador, int idproveedor, DateTime fecha,
            string tipo_comprobante, string serie, string correlativo, decimal igv,
            string estado, DataTable dtDetalles)
        {
            D_Ingreso Obj = new D_Ingreso();
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            Obj.Estado = estado;
            List<D_Detalle_Ingreso> detalles = new List<D_Detalle_Ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                D_Detalle_Ingreso detalle = new D_Detalle_Ingreso();
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_Produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.Fecha_Vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public static string Anular(int idingreso)
        {
            D_Ingreso Obj = new D_Ingreso();
            Obj.Idingreso = idingreso;
            return Obj.Anular(Obj);
        }

        public static DataTable Mostrar()
        {
            return new D_Ingreso().Mostrar();
        }

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            D_Ingreso Obj = new D_Ingreso();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalle(string textobuscar)
        {
            D_Ingreso Obj = new D_Ingreso();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
