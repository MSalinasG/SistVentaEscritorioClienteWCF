using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class D_Detalle_Ingreso
    {
        //Variables
        private int _Iddetalle_Ingreso;
        private int _Idingreso;
        private int _Idarticulo;
        private decimal _Precio_Compra;
        private decimal _Precio_Venta;
        private int _Stock_Inicial;
        private int _Stock_Actual;
        private DateTime _Fecha_Produccion;
        private DateTime _Fecha_Vencimiento;

        public int Iddetalle_Ingreso
        {
            get
            {
                return _Iddetalle_Ingreso;
            }

            set
            {
                _Iddetalle_Ingreso = value;
            }
        }

        public int Idingreso
        {
            get
            {
                return _Idingreso;
            }

            set
            {
                _Idingreso = value;
            }
        }

        public int Idarticulo
        {
            get
            {
                return _Idarticulo;
            }

            set
            {
                _Idarticulo = value;
            }
        }

        public decimal Precio_Compra
        {
            get
            {
                return _Precio_Compra;
            }

            set
            {
                _Precio_Compra = value;
            }
        }

        public decimal Precio_Venta
        {
            get
            {
                return _Precio_Venta;
            }

            set
            {
                _Precio_Venta = value;
            }
        }

        public int Stock_Inicial
        {
            get
            {
                return _Stock_Inicial;
            }

            set
            {
                _Stock_Inicial = value;
            }
        }

        public int Stock_Actual
        {
            get
            {
                return _Stock_Actual;
            }

            set
            {
                _Stock_Actual = value;
            }
        }

        public DateTime Fecha_Produccion
        {
            get
            {
                return _Fecha_Produccion;
            }

            set
            {
                _Fecha_Produccion = value;
            }
        }

        public DateTime Fecha_Vencimiento
        {
            get
            {
                return _Fecha_Vencimiento;
            }

            set
            {
                _Fecha_Vencimiento = value;
            }
        }

        public D_Detalle_Ingreso(int _Iddetalle_Ingreso, int _Idingreso, int _Idarticulo, decimal _Precio_Compra, decimal _Precio_Venta, int _Stock_Inicial, int _Stock_Actual, DateTime _Fecha_Produccion, DateTime _Fecha_Vencimiento)
        {
            this.Iddetalle_Ingreso = _Iddetalle_Ingreso;
            this.Idingreso = _Idingreso;
            this.Idarticulo = _Idarticulo;
            this.Precio_Compra = _Precio_Compra;
            this.Precio_Venta = _Precio_Venta;
            this.Stock_Inicial = _Stock_Inicial;
            this.Stock_Actual = _Stock_Actual;
            this.Fecha_Produccion = _Fecha_Produccion;
            this.Fecha_Vencimiento = _Fecha_Vencimiento;
        }

        public D_Detalle_Ingreso()
        {

        }

        //Método Insertar
        public string Insertar(D_Detalle_Ingreso Detalle_Ingreso,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Ingreso = new SqlParameter();
                ParIddetalle_Ingreso.ParameterName = "@iddetalle_ingreso";
                ParIddetalle_Ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_Ingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Ingreso);

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Detalle_Ingreso.Idingreso;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_Ingreso.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@precio_compra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Money;
                ParPrecio_Compra.Value = Detalle_Ingreso.Precio_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@precio_venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Money;
                ParPrecio_Venta.Value = Detalle_Ingreso.Precio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParStock_Actual = new SqlParameter();
                ParStock_Actual.ParameterName = "@stock_actual";
                ParStock_Actual.SqlDbType = SqlDbType.Int;
                ParStock_Actual.Value = Detalle_Ingreso.Stock_Actual;
                SqlCmd.Parameters.Add(ParStock_Actual);

                SqlParameter ParStock_Inicial = new SqlParameter();
                ParStock_Inicial.ParameterName = "@stock_inicial";
                ParStock_Inicial.SqlDbType = SqlDbType.Int;
                ParStock_Inicial.Value = Detalle_Ingreso.Stock_Inicial;
                SqlCmd.Parameters.Add(ParStock_Inicial);

                SqlParameter ParFecha_Produccion = new SqlParameter();
                ParFecha_Produccion.ParameterName = "@fecha_produccion";
                ParFecha_Produccion.SqlDbType = SqlDbType.Date;
                ParFecha_Produccion.Value = Detalle_Ingreso.Fecha_Produccion;
                SqlCmd.Parameters.Add(ParFecha_Produccion);

                SqlParameter ParFecha_Vencimiento = new SqlParameter();
                ParFecha_Vencimiento.ParameterName = "@fecha_vencimiento";
                ParFecha_Vencimiento.SqlDbType = SqlDbType.Date;
                ParFecha_Vencimiento.Value = Detalle_Ingreso.Fecha_Vencimiento;
                SqlCmd.Parameters.Add(ParFecha_Vencimiento);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }
    }
}
