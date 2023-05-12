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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCategoria" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCategoria.svc o ServiceCategoria.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCategoria : IService_Categoria
    {
        public DataTable BuscarNombre(string textobuscar)
        {
            return N_Categoria.BuscarNombre(textobuscar);
        }

        public DataTable Mostrar()
        {
            return N_Categoria.Mostrar();
        }
    }
}
