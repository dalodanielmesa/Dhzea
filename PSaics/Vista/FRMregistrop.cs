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
    public partial class FRMregistrop : Form
    {
        public FRMregistrop()
        {
            InitializeComponent();
        }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string encargadodeescuela { get; set; }
        public string rol { get; set; }
        public string estudiante { get; set; }
        public string tacudiente { get; set; }
        public string ncacudiente { get; set; }
        public string escuela { get; set; }

        CLpersona OBJpersona = new CLpersona();
        CLcombos OBJcombos = new CLcombos();
        DataTable OBJtabla = new DataTable();
        DataTable OBJtabla1 = new DataTable();

        private void BTNregistrar_Click(object sender, EventArgs e)
        {
            MTDcargarp();
            int r = OBJpersona.MTDregistro();
            if (r != 999)
            {
                MessageBox.Show("Registro Exitoso");
            }
        }
        public void MTDcargarp()
        {
            string eescuela = "";
            string estudiante = "";
            int est = 0;
            if (CHKeescuela.Checked == true)
            {
                eescuela = "Si";
            }
            else
            {
                eescuela = "No";
            }
            if (CHKesestudiante.Checked == true)
            {
                estudiante = "Si";
                est = 1;
            }
            else
            {
                estudiante = "No";
            }
            OBJpersona.nombre = TXTnombre.Text;
            OBJpersona.apellido = TXTapellido.Text;
            OBJpersona.documento = TXTdocumento.Text;
            OBJpersona.telefono = TXTtelefono.Text;
            OBJpersona.correo = TXTcorreo.Text;
            OBJpersona.contraseña = TXTcontraseña.Text;
            OBJpersona.eescuela = eescuela;
            OBJpersona.rol = Convert.ToInt32(CMBrol.SelectedValue);
            OBJpersona.estudiante = estudiante;
            OBJpersona.escuela = Convert.ToInt32(CMBescuela.SelectedValue);
            OBJpersona.tacudiente = TXTtacudiente.Text;
            OBJpersona.nacudiente = TXTnacudiente.Text;
            OBJpersona.est = est;
        }
        public void MTDcargarcombo()
        {
            OBJtabla = OBJcombos.MTDrol();
            CMBrol.DataSource = OBJtabla;
            CMBrol.DisplayMember = "Rol";
            CMBrol.ValueMember = "IdRol";

            OBJtabla1 = OBJcombos.MTDescuela();
            CMBescuela.DataSource = OBJtabla1;
            CMBescuela.DisplayMember = "Escuela";
            CMBescuela.ValueMember = "IdEscuela";
        }
        private void FRMregistrop_Load(object sender, EventArgs e)
        {
            MTDcargarcombo();
        }

        private void CHKesestudiante_Click(object sender, EventArgs e)
        {
            if (CHKesestudiante.Checked == true)
            {
                TXTtacudiente.Visible = true;
                TXTnacudiente.Visible = true;
                LBLtacudiente.Visible = true;
                LBLnacudiente.Visible = true;
                LBLescuela.Visible = true;
                CMBescuela.Visible = true;
            }
            else
            {
                TXTtacudiente.Visible = false;
                TXTnacudiente.Visible = false;
                LBLtacudiente.Visible = false;
                LBLnacudiente.Visible = false;
                LBLescuela.Visible = false;
                CMBescuela.Visible = false;
            }
        }



        private void BTNatras_Click(object sender, EventArgs e)
        {
            FRMgestorregistro OBJgestorregistro = new FRMgestorregistro();
            OBJgestorregistro.Show();
            this.Hide();
        }

        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            FRMbusqueda OBJbusquedapersona = new FRMbusqueda();
            OBJbusquedapersona.Show();
            this.Hide();
        }

        private void CMBrol_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBrol.Text == "Cliente")
            {
                LBLestudiante.Visible = true;
                CHKesestudiante.Visible = true;
            }
            else
            {
                LBLestudiante.Visible = false;
                CHKesestudiante.Visible = false;
            }
        }
        public void MTDeditar()
        {
            string eescuela = encargadodeescuela;
            string eestudiante = estudiante;
            if (eescuela=="Si")
            {
                CHKeescuela.Checked = true;
            }
            if (eestudiante=="Si")
            {
                CHKesestudiante.Checked = true;
                CHKesestudiante.Visible = true;
                TXTnacudiente.Visible = true;
                TXTtacudiente.Visible = true;
                LBLestudiante.Visible = true;
                LBLnacudiente.Visible = true;
                LBLtacudiente.Visible = true;
                LBLescuela.Visible = true;
                CMBescuela.Visible = true;
            }
            TXTnombre.Text = nombre;
            TXTapellido.Text = apellido;
            TXTdocumento.Text = documento;
            TXTtelefono.Text = telefono;
            TXTcorreo.Text = correo;
            TXTcontraseña.Text = contraseña;
            CMBrol.SelectedValue = rol;            
            TXTtacudiente.Text = tacudiente;
            TXTnacudiente.Text = ncacudiente;
            CMBescuela.SelectedValue = escuela;
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            MTDcargarp();
           int v= OBJpersona.MTDeliminar();
            if (v== 999)
            {
                MessageBox.Show("Error al eliminar");
            }
            else
            {
                MessageBox.Show("Eliminado con exito");
            }
        }

        private void BTNmodificar_Click(object sender, EventArgs e)
        {
            MTDcargarp();
            int v = OBJpersona.MTDactualizar();
            if (v == 999)
            {
                MessageBox.Show("No se puedo actualizar");
            }
            else
            {
                MessageBox.Show("Actualizdado con exito");
            }
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
