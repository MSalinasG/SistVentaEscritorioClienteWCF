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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service_Presentacion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service_Presentacion.svc o Service_Presentacion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service_Presentacion : IService_Presentacion
    {
        public DataTable Mostrar()
        {
            return N_Presentacion.Mostrar();
        }
    }
}
