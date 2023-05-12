﻿using System;
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
    public partial class frmVistaArticulo_Venta : Form
    {
        ServiceVenta.Service_VentaClient sc = new ServiceVenta.Service_VentaClient();
        public frmVistaArticulo_Venta()
        {
            InitializeComponent();
        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
        }

        //Método BuscarNombre
        private void MostrarArticulo_Venta_Nombre()
        {
            this.dataListado.DataSource = sc.MostrarArticulo_Venta_Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void MostrarArticulo_Venta_Codigo()
        {
            this.dataListado.DataSource = sc.MostrarArticulo_Venta_Codigo(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void MostrarArticulo_Venta()
        {
            this.dataListado.DataSource = sc.MostrarArticulo_Venta_Nombre("");
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Codigo"))
            {
                this.MostrarArticulo_Venta_Codigo();
            }
            else if (cbBuscar.Text.Equals("Nombre"))
            {
                this.MostrarArticulo_Venta_Nombre();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frm_Venta form = frm_Venta.GetInstancia();
                string par1, par2;
                decimal par3, par4;
                int par5;
                DateTime par6;
                par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["iddetalle_ingreso"].Value);
                par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                par3 = Convert.ToDecimal(this.dataListado.CurrentRow.Cells["precio_compra"].Value);
                par4 = Convert.ToDecimal(this.dataListado.CurrentRow.Cells["precio_venta"].Value);
                par5 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["stock_actual"].Value);
                par6 = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_vencimiento"].Value);
                form.setArticulo(par1, par2, par3, par4, par5, par6);
                this.Hide();
            }
            catch (NullReferenceException)
            {
                return;
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void frmVistaArticulo_Venta_Load(object sender, EventArgs e)
        {
            this.MostrarArticulo_Venta();
        }
    }
}
