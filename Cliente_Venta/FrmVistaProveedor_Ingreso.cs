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
    public partial class FrmVistaProveedor_Ingreso : Form
    {

        ServiceProveedor.Service_ProveedorClient sc = new ServiceProveedor.Service_ProveedorClient();
        public FrmVistaProveedor_Ingreso()
        {
            InitializeComponent();
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

        //Método BuscarRazon_Social
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = sc.BuscarRazon_social(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNum_Documento
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = sc.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            frm_Ingreso form = frm_Ingreso.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            form.setProveedor(par1, par2);
            this.Hide();
        }

        private void FrmVistaProveedor_Ingreso_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
