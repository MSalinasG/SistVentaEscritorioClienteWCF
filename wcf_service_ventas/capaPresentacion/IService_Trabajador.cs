using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService_Trabajador" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService_Trabajador
    {  
        [OperationContract]
        string Insertar(string nombre, string apellidos, string sexo,
                                        DateTime fecha_nacimiento, string num_documento,
                                        string direccion, string telefono, string email, string acceso,
                                        string usuario, string password);
        [OperationContract]
        string Editar(int idtrabajador, string nombre, string apellidos,
            string sexo,
            DateTime fecha_nacimiento, string num_documento,
            string direccion, string telefono, string email, string acceso, string usuario,
            string password);

        [OperationContract]
        string Eliminar(int idtrabajador);

        [OperationContract]
        DataTable Mostrar();

        [OperationContract]
        DataTable BuscarApellidos(string textobuscar);

        [OperationContract]
        DataTable BuscarNum_Documento(string textobuscar);
        [OperationContract]
        DataTable Login(string usuario, string password);
    }
}
