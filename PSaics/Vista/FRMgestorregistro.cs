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

namespace PSaics.Vista
{
    public partial class FRMgestorregistro : Form
    {
        public FRMgestorregistro()
        {
            InitializeComponent();
        }
        
        private void BTNpersonas_Click(object sender, EventArgs e)
        {
            FRMregistrop OBJpersona = new FRMregistrop();
            OBJpersona.Show();
            this.Hide();
        }

        private void BTNusuario_Click(object sender, EventArgs e)
        {
            FRMcusuario OBJusuarios = new FRMcusuario();
            OBJusuarios.Show();
            this.Hide();
        }

        private void BTNatras_Click(object sender, EventArgs e)
        {
            FRMprincipal OBJprincipal = new FRMprincipal();
            OBJprincipal.Show();
            this.Hide();
        }

        private void BTNatras_MouseHover(object sender, EventArgs e)
        {
            string ruta = @"\Imagenes2\Backrojo.png";
            BTNatras.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + ruta);
        }

        private void BTNatras_MouseLeave(object sender, EventArgs e)
        {
            string ruta = @"\Imagenes2\Back.png";
            BTNatras.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + ruta);
        }
    }
}
