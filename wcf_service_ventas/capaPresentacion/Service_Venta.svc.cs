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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service_Venta" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service_Venta.svc o Service_Venta.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service_Venta : IService_Venta
    {
        public DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DataTable dt = N_Venta.BuscarFechas(textobuscar, textobuscar2);
            return dt;
        }

        public string Eliminar(int iD_Venta)
        {
            string resultado = N_Venta.Eliminar(iD_Venta);
            return resultado;
        }

        public string Insertar(int idcliente, int idtrabajador, DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, DataTable dtDetalles)
        {
            string resultado = N_Venta.Insertar(idcliente, idtrabajador, fecha, tipo_comprobante, serie, correlativo, igv, dtDetalles);
            return resultado;
        }

        public DataTable Mostrar()
        {
            return N_Venta.Mostrar();
        }

        public DataTable MostrarArticulo_Venta()
        {
            return N_Venta.MostrarArticulo_Venta();
        }

        public DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            DataTable dt = N_Venta.MostrarArticulo_Venta_Codigo(textobuscar);
            return dt;
        }

        public DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            DataTable dt = N_Venta.MostrarArticulo_Venta_Nombre(textobuscar);
            return dt;
        }

        public DataTable MostrarDetalle(string textobuscar)
        {
            DataTable dt = N_Venta.MostrarDetalle(textobuscar);
            return dt;
        }
    }
}
