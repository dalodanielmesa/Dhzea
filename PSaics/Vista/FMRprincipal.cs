using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSaics.Vista
{
    public partial class FRMprincipal : Form
    {
        public FRMprincipal()
        {
            InitializeComponent();
        }
        static string  tusuario { get; set; }        
        FRMregistrop OBJpersona = new FRMregistrop();
        private void BTNpersonas_Click(object sender, EventArgs e)
        {
            OBJpersona.Show();
            this.Hide();
        }
        public void MTDrol()
        {
            if (tusuario == "Empleado")
            {
                BTNinventario.Visible = false;
                BTNadmincontable.Visible = false;

            }
            else if (tusuario == "Administrador")
            {

                BTNinventario.Visible = true;
                BTNadmincontable.Visible = true;
            }
        }
        private void FRMprincipal_Load(object sender, EventArgs e)
        {
            MTDrol();
        }
        public void MTDtusuario(string rol)
        {
            tusuario = rol;
        }

        private void BTNgestorregistro_Click(object sender, EventArgs e)
        {
            FRMgestorregistro OBJgestorregistro = new FRMgestorregistro();
            OBJgestorregistro.Show();
            this.Hide();
        }
    }
}
