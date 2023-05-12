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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCliente.svc o ServiceCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCliente : IService_Cliente
    {
        public DataTable BuscarApellidos(string textobuscar)
        {
            DataTable dt = N_Cliente.BuscarApellidos(textobuscar);
            return dt;
        }

        public DataTable BuscarNum_Documento(string textobuscar)
        {
            DataTable dt = N_Cliente.BuscarNum_Documento(textobuscar);
            return dt;
        }
  
        public DataTable Mostrar()
        {
            DataTable dt = N_Cliente.Mostrar();
            return dt;
        }
    }
}
