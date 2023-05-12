using capaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service_Ingreso" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service_Ingreso.svc o Service_Ingreso.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service_Ingreso : IService_Ingreso
    {
        public string Anular(int idingreso)
        {
            string resultado = N_Ingreso.Anular(idingreso);
            return resultado;
        }

        public DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DataTable dt = N_Ingreso.BuscarFechas(textobuscar, textobuscar2);
            return dt;
        }
 

        public string Insertar(int idtrabajador, int idproveedor, DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado, DataTable dtDetalles)
        {
            string resultado = N_Ingreso.Insertar(idtrabajador, idproveedor, fecha, tipo_comprobante, serie, correlativo, igv, estado, dtDetalles);
            return resultado;
        }

        public DataTable Mostrar()
        {
            return N_Ingreso.Mostrar();
        }

        public DataTable MostrarDetalle(string textobuscar)
        {
            DataTable dt = N_Ingreso.MostrarDetalle(textobuscar);
            return dt;
        }
 
    }
}
