using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSaics.Datos;

namespace PSaics.Vista
{
    public partial class FRMcusuario : Form
    {
        public FRMcusuario()
        {
            InitializeComponent();
        }
        CLusuarios OBJusuarios = new CLusuarios();
        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            OBJusuarios.Documento = TXTbdocumento.Text;
            DGVusuarios.DataSource = OBJusuarios.MTDbuscar();
        }
        public void MTDcargarp()
        {
            OBJusuarios.Documento = TXTdocumento.Text;
            OBJusuarios.Correo = TXTcorreo.Text;
            OBJusuarios.Contraseña = TXTcontraseña.Text;
            OBJusuarios.TipoUsuario = CMBtipousuario.Text;
            OBJusuarios.NombreUsuario = TXTnombreusuario.Text;
        }

        private void BTNmodificar_Click(object sender, EventArgs e)
        {
            MTDcargarp();
            OBJusuarios.MTDactualizar();
            BTNbuscar_Click(null, null);
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            MTDcargarp();
            OBJusuarios.MTDeliminar();
            BTNbuscar_Click(null, null);
        }

        private void BTNregistrar_Click(object sender, EventArgs e)
        {
            MTDcargarp();
            OBJusuarios.MTDregistrar();
            BTNbuscar_Click(null, null);
        }

        private void DGVusuarios_DoubleClick(object sender, EventArgs e)
        {
            TXTnombreusuario.Text = Convert.ToString(DGVusuarios.CurrentRow.Cells[0].Value);
            TXTdocumento.Text = Convert.ToString(DGVusuarios.CurrentRow.Cells[1].Value);
            TXTcontraseña.Text = Convert.ToString(DGVusuarios.CurrentRow.Cells[2].Value);
            TXTcorreo.Text = Convert.ToString(DGVusuarios.CurrentRow.Cells[3].Value);
            CMBtipousuario.Text = Convert.ToString(DGVusuarios.CurrentRow.Cells[4].Value);
        }

        private void BTNatras_Click(object sender, EventArgs e)
        {
            FRMgestorregistro OBJgestorregistro = new FRMgestorregistro();
            OBJgestorregistro.Show();
            this.Hide();
        }

        private void BTNatras_MouseLeave(object sender, EventArgs e)
        {
            string ruta = @"\Imagenes2\Back.png";
            BTNatras.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + ruta);
        }

        private void BTNatras_MouseHover(object sender, EventArgs e)
        {
            string ruta = @"\Imagenes2\Backrojo.png";
            BTNatras.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + ruta);
        }
    }
}
