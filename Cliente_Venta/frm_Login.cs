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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceTrabajador.Service_TrabajadorClient st = new ServiceTrabajador.Service_TrabajadorClient();
                string usuario, password;
                usuario = TxtUsuario.Text;
                password = TxtPassword.Text;

                DataTable dtResp = new DataTable();
                dtResp = st.Login(usuario, password);
                if (dtResp.Rows.Count == 0)
                {
                    MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    string nombre, apellido;
                    nombre = dtResp.Rows[0][2].ToString();
                    apellido = dtResp.Rows[0][1].ToString();

                    MessageBox.Show("Bienvenido(a) : " + nombre + " " + apellido, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_Principal frm = new frm_Principal();
                    frm.Idtrabajador = dtResp.Rows[0][0].ToString();
                    frm.Apellidos = apellido;
                    frm.Nombre = nombre;
                    frm.Acceso = dtResp.Rows[0][3].ToString();

                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
