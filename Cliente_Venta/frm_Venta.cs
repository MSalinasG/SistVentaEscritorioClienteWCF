using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Venta
{
    public partial class frm_Venta : Form
    {
        //variables globales
        ServiceVenta.Service_VentaClient sc = new ServiceVenta.Service_VentaClient();
        private bool IsNuevo = false;
        public int Idtrabajador;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private static frm_Venta _instancia;

        public static frm_Venta GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frm_Venta();
            }
            return _instancia;
        }

        public void setCliente(string idcliente, string nombre)
        {
            this.txtIdcliente.Text = idcliente;
            this.txtCliente.Text = nombre;
        }

        public void setArticulo(string iddetalle_ingreso, string nombre,
                                decimal precio_compra, decimal precio_venta, int stock,
                                DateTime fecha_vencimiento)
        {
            this.txtIdarticulo.Text = iddetalle_ingreso;
            this.txtArticulo.Text = nombre;
            this.txtPrecio_Compra.Text = Convert.ToString(Math.Round(precio_compra,2));
            this.txtPrecio_Venta.Text = Convert.ToString(Math.Round(precio_venta, 2));
            this.txtStock_Actual.Text = Convert.ToString(stock);
            this.dtFecha_Vencimiento.Value = fecha_vencimiento;
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIdventa.Text = string.Empty;
            this.txtIdcliente.Text = string.Empty;
            this.txtCliente.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtCorrelativo.Text = string.Empty;

            //
            this.txt_igv.Text = "0";
            this.txtSubTotal.Text = "0.00";
            this.txtTotal.Text = "0.00";
            cbTipo_Comprobante.SelectedIndex = 0;
           this.crearTabla();
        }
         
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Impuesto", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dataListadoDetalle.DataSource = this.dtDetalle;
            this.dataListadoDetalle.Columns[6].Visible = false;

        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiarDetalle()
        {
            this.txtIdarticulo.Text = string.Empty;
            this.txtArticulo.Text = string.Empty;
            this.txtStock_Actual.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtPrecio_Compra.Text = string.Empty;
            this.txtPrecio_Venta.Text = string.Empty;
            this.txtDescuento.Text = "0";
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtIdventa.ReadOnly = !valor;
            this.txtSerie.ReadOnly = !valor;
            this.txtCorrelativo.ReadOnly = !valor;
            this.dtFecha.Enabled = valor;
            this.cbTipo_Comprobante.Enabled = valor;
            this.txtCantidad.ReadOnly = !valor;
            this.txtPrecio_Compra.ReadOnly = !valor;
            this.txtPrecio_Venta.ReadOnly = !valor;
            this.txtStock_Actual.ReadOnly = !valor;
            this.txtDescuento.ReadOnly = !valor;
            this.dtFecha_Vencimiento.Enabled = valor;

            this.btnBuscarArticulo.Enabled = valor;
            this.btnBuscarCliente.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = sc.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        public frm_Venta()
        {
            InitializeComponent();
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void frm_Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        //Método BuscarFechas
        private void BuscarFechas()
        {
            this.dataListado.DataSource = sc.BuscarFechas(this.dtFecha1.Value.ToString("dd/MM/yyyy"),
                this.dtFecha2.Value.ToString("dd/MM/yyyy"));
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
                btnEliminar.Enabled = false;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
                btnEliminar.Enabled = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
                if (!Convert.ToBoolean(ChkEliminar.Value))
                {                    
                    btnEliminar.Enabled = false;
                }
                else
                {                   
                    btnEliminar.Enabled = true;
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = sc.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente la venta");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.chkEliminar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmVistaCliente_Venta vista = new frmVistaCliente_Venta();
            vista.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(true);
            this.txtSerie.Focus();
            this.txtDescuento.Text = "0";
            totalPagado = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIdarticulo.Text == string.Empty || this.txtCantidad.Text == string.Empty
                    || this.txtDescuento.Text == string.Empty || this.txtPrecio_Venta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtIdarticulo, "Ingrese un Valor");
                    errorIcono.SetError(txtCantidad, "Ingrese un Valor"); 
                    errorIcono.SetError(txtPrecio_Venta, "Ingrese un Valor");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["iddetalle_ingreso"]) == Convert.ToInt32(this.txtIdarticulo.Text))
                        {
                            registrar = false;
                            this.MensajeError("YA se encuentra el artículo en el detalle");
                            return;
                        }
                    }

                    if (Convert.ToDecimal(this.txtDescuento.Text) > (Convert.ToDecimal(this.txtCantidad.Text) * Convert.ToDecimal(this.txtPrecio_Venta.Text)))
                    {
                        this.MensajeError("El descuento no puede ser mayor al precio total"); 
                        return;
                    }

                    if (registrar && Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock_Actual.Text))
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtCantidad.Text) * Convert.ToDecimal(this.txtPrecio_Venta.Text) - Convert.ToDecimal(this.txtDescuento.Text);
                        totalPagado = totalPagado + subTotal;

                      //  this.txtSubTotal.Text = subTotal.ToString("#0.00#");
                        // 
                        if (cbTipo_Comprobante.SelectedIndex == 0)
                        {
                            this.txtSubTotal.Text = totalPagado.ToString("#0.00#");
                            this.txtTotal.Text = totalPagado.ToString("#0.00#");
                        }
                        else
                        {
                            this.txtSubTotal.Text = totalPagado.ToString("#0.00#");
                            double impuesto = Convert.ToDouble(totalPagado.ToString("#0.00#")) * (Convert.ToDouble(txt_igv.Text) / 100);
                            double total = Convert.ToDouble(totalPagado.ToString("#0.00#")) + impuesto;
                            this.txtTotal.Text = total.ToString("#0.00#"); 
                        }


                        //Agregar ese detalle al datalistadoDetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["iddetalle_ingreso"] = Convert.ToInt32(this.txtIdarticulo.Text);
                        row["articulo"] = this.txtArticulo.Text;
                        row["cantidad"] = Convert.ToInt32(this.txtCantidad.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtPrecio_Venta.Text);
                        row["descuento"] = Convert.ToDecimal(this.txtDescuento.Text);
                        row["subtotal"] = subTotal;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();
                    }
                    else
                    {
                        MensajeError("No hay Stock Suficiente");
                    }                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.dataListadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuir el totalPAgado
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["subtotal"].ToString());

                //
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);

              if (cbTipo_Comprobante.SelectedIndex == 0)
                {
                    this.txtSubTotal.Text = totalPagado.ToString("#0.00#");
                    this.txtTotal.Text = totalPagado.ToString("#0.00#");
                }
                else
                {
                    this.txtSubTotal.Text = totalPagado.ToString("#0.00#");
                    double impuesto = Convert.ToDouble(totalPagado.ToString("#0.00#")) * (Convert.ToDouble(txt_igv.Text) / 100);
                    double total = Convert.ToDouble(totalPagado.ToString("#0.00#")) + impuesto;
                    this.txtTotal.Text = total.ToString("#0.00#");
                }
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtIdcliente.Text == string.Empty || this.txtSerie.Text == string.Empty
                    || this.txtCorrelativo.Text == string.Empty )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtIdcliente, "Ingrese un Valor");
                    errorIcono.SetError(txtSerie, "Ingrese un Valor");
                    errorIcono.SetError(txtCorrelativo, "Ingrese un Valor");
                }
                else
                {

                    if (this.IsNuevo)
                    {

                        if (cbTipo_Comprobante.SelectedIndex == 0)
                        {              
                            rpta = sc.Insertar(Convert.ToInt32(this.txtIdcliente.Text), Idtrabajador,
                           dtFecha.Value, cbTipo_Comprobante.Text, txtSerie.Text, txtCorrelativo.Text,
                           Convert.ToDecimal(txt_igv.Text), dtDetalle);
                        }
                        else
                        {                           
                            rpta = sc.Insertar(Convert.ToInt32(this.txtIdcliente.Text), Idtrabajador,
                            dtFecha.Value, cbTipo_Comprobante.Text, txtSerie.Text, txtCorrelativo.Text,
                            Convert.ToDecimal(txt_igv.Text), dtDetalle);
                        }

                        
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        } 
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = sc.MostrarDetalle(this.txtIdventa.Text);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(false);
            totalPagado = 0;
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmVistaArticulo_Venta vista = new frmVistaArticulo_Venta();
            vista.ShowDialog();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdventa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idventa"].Value);
            this.txtCliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cliente"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cbTipo_Comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Tipo de Comprobante"].Value);
            if (Convert.ToString(this.dataListado.CurrentRow.Cells["Tipo de Comprobante"].Value) == "FACTURA")
            {
                decimal subTotal = Convert.ToDecimal(Math.Round(Convert.ToDecimal(this.dataListado.CurrentRow.Cells["Total"].Value), 2)) / (Convert.ToDecimal(txt_igv.Text) / 100 + 1);
                this.txtSubTotal.Text = "" + Math.Round(subTotal, 2);
                this.txtTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(this.dataListado.CurrentRow.Cells["Total"].Value), 2)); 
            }
            else
            {
                this.txtSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(this.dataListado.CurrentRow.Cells["Total"].Value), 2));
                this.txtTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(this.dataListado.CurrentRow.Cells["Total"].Value), 2));
            }

            this.txtSerie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Serie"].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Correlativo"].Value);             
            this.txt_igv.Text = Convert.ToString(Math.Round(Convert.ToDecimal(this.dataListado.CurrentRow.Cells["Impuesto"].Value)));
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void txtIdcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_Comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo_Comprobante.SelectedIndex == 0)
            {
                txt_igv.Text = "0";
            }
            else
            {                
                txt_igv.Text = "18";
            }
        }
    }
}
