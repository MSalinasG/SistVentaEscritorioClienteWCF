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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service_Trabajador" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service_Trabajador.svc o Service_Trabajador.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service_Trabajador : IService_Trabajador
    { 
  
        public string Editar(int idtrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
        {
            string result = N_Trabajador.Editar(idtrabajador,nombre,apellidos,sexo,fecha_nacimiento,num_documento,direccion,telefono,email,acceso,usuario,password);
            return result;
        }

        public string Eliminar(int idtrabajador)
        {
            string result = N_Trabajador.Eliminar(idtrabajador);
            return result;
        }

        public string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
        {
            string result = N_Trabajador.Insertar(nombre, apellidos, sexo, fecha_nacimiento, num_documento, direccion, telefono, email, acceso, usuario, password);
            return result;
        }

        public DataTable Login(string usuario, string password)
        {
            DataTable dt = N_Trabajador.Login(usuario, password);
            return dt;
        }

        public DataTable Mostrar()
        {
            return N_Trabajador.Mostrar();
        }

        public DataTable BuscarApellidos(string textobuscar)
        {
            DataTable dt = N_Trabajador.BuscarApellidos(textobuscar);
            return dt;
        }

        public DataTable BuscarNum_Documento(string textobuscar)
        {
            DataTable dt = N_Trabajador.BuscarNum_Documento(textobuscar);
            return dt;
        }

    }
}
