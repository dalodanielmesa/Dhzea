using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSaics.Datos;

namespace PSaics.Vista
{
    public partial class FRMbusactper : Form
    {
        public FRMbusactper()
        {
            InitializeComponent();
        }
        public string dbusqueda { get; set; }
        CLpersona OBJpersona = new CLpersona();

        public void MTDcargardgv()
        {

        }
        private void FRMbusactper_Load(object sender, EventArgs e)
        {
            OBJpersona.dbusqueda = dbusqueda;
            DGVpersona.DataSource = OBJpersona.MTDbuscar();
        }
        private void DGVpersona_DoubleClick(object sender, EventArgs e)
        {
            FRMregistrop OBJrpersona = new FRMregistrop();
            OBJrpersona.nombre = Convert.ToString(DGVpersona.CurrentRow.Cells[1].Value);
            OBJrpersona.apellido = Convert.ToString(DGVpersona.CurrentRow.Cells[2].Value);
            OBJrpersona.documento = Convert.ToString(DGVpersona.CurrentRow.Cells[3].Value);
            OBJrpersona.telefono = Convert.ToString(DGVpersona.CurrentRow.Cells[4].Value);
            OBJrpersona.correo = Convert.ToString(DGVpersona.CurrentRow.Cells[5].Value);
            OBJrpersona.encargadodeescuela = Convert.ToString(DGVpersona.CurrentRow.Cells[6].Value);
            OBJrpersona.estudiante = Convert.ToString(DGVpersona.CurrentRow.Cells[7].Value);
            OBJrpersona.ncacudiente = Convert.ToString(DGVpersona.CurrentRow.Cells[8].Value);
            OBJrpersona.tacudiente = Convert.ToString(DGVpersona.CurrentRow.Cells[9].Value);
            OBJrpersona.contraseña = Convert.ToString(DGVpersona.CurrentRow.Cells[10].Value);            
            OBJrpersona.rol = Convert.ToString(DGVpersona.CurrentRow.Cells[11].Value);           
            OBJrpersona.escuela = Convert.ToString(DGVpersona.CurrentRow.Cells[12].Value);
            OBJrpersona.MTDeditar();
            OBJrpersona.Show();
            this.Hide();

        }
    }
}
