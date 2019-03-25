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
    public partial class FRMbusqueda : Form
    {
        public FRMbusqueda()
        {
            InitializeComponent();
        }
        
        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            FRMbusactper OBJbusactper = new FRMbusactper();
            OBJbusactper.dbusqueda = TXTbusqueda.Text;
            TXTbusqueda.Clear();
            OBJbusactper.Show();
            this.Hide();
        }
    }
}
