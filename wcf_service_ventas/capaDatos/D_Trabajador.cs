using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
   public class D_Trabajador
    {
        //Variables
        private int _Idtrabajador;
        private string _Nombre;
        private string _Apellidos;
        private string _Sexo;
        private DateTime _Fecha_Nacimiento;
        private string _Num_Documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Acceso;
        private string _Usuario;
        private string _Password;
        private string _TextoBuscar;

        //Constructores
        public D_Trabajador()
        {

        }
        public D_Trabajador(int _Idtrabajador, string _Nombre, string _Apellidos, string _Sexo, DateTime _Fecha_Nacimiento, string _Num_Documento, string _Direccion, string _Telefono, string _Email, string _Acceso, string _Usuario, string _Password, string _TextoBuscar)
        {
            this._Idtrabajador = _Idtrabajador;
            this._Nombre = _Nombre;
            this._Apellidos = _Apellidos;
            this._Sexo = _Sexo;
            this._Fecha_Nacimiento = _Fecha_Nacimiento;
            this._Num_Documento = _Num_Documento;
            this._Direccion = _Direccion;
            this._Telefono = _Telefono;
            this._Email = _Email;
            this._Acceso = _Acceso;
            this._Usuario = _Usuario;
            this._Password = _Password;
            this._TextoBuscar = _TextoBuscar;
        }

        public int Idtrabajador
        {
            get
            {
                return _Idtrabajador;
            }

            set
            {
                _Idtrabajador = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public DateTime Fecha_Nacimiento
        {
            get
            {
                return _Fecha_Nacimiento;
            }

            set
            {
                _Fecha_Nacimiento = value;
            }
        }

        public string Num_Documento
        {
            get
            {
                return _Num_Documento;
            }

            set
            {
                _Num_Documento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Acceso
        {
            get
            {
                return _Acceso;
            }

            set
            {
                _Acceso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        //Métodos Insertar
        public string Insertar(D_Trabajador Trabajador)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Trabajador.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Trabajador.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Trabajador.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@fecha_nacimiento";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.Date; 
                ParFecha_Nacimiento.Value = Trabajador.Fecha_Nacimiento;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 11;
                ParNum_Documento.Value = Trabajador.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Trabajador.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Trabajador.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Trabajador.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = Trabajador.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Editar
        public string Editar(D_Trabajador Trabajador)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Trabajador.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Trabajador.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Trabajador.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Trabajador.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@fecha_nacimiento";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.Date; 
                ParFecha_Nacimiento.Value = Trabajador.Fecha_Nacimiento;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 11;
                ParNum_Documento.Value = Trabajador.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Trabajador.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Trabajador.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Trabajador.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = Trabajador.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Eliminar(D_Trabajador Trabajador)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Trabajador.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Trabajador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Método Buscar Apellidos
        public DataTable BuscarApellidos(D_Trabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("Trabajador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_trabajador_apellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Trabajador.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Método Buscar por Documento
        public DataTable BuscarNum_Documento(D_Trabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("Trabajador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_trabajador_num_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Trabajador.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Login
        public DataTable Login(D_Trabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("Trabajador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ConexionBD.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 20;
                ParPassword.Value = Trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
