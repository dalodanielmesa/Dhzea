using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSaics.Vista;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using PSaics.Datos;
using System.Collections;


namespace PSaics
{
    public partial class FRMlogin : Form
    {
        public FRMlogin()
        {
            InitializeComponent();
        }
        FRMprincipal OBJprincipal = new FRMprincipal();
        CLlogin OBJlogin = new CLlogin();
        private void BTNiniciar_Click(object sender, EventArgs e)
        {

            string tusuario = "";
            ArrayList OBJlista2 = new ArrayList();
            List<string> OBJusuarios = new List<string>();
            DataTable OBJtabla = new DataTable();
            if (TXTusuario.Text == "" || TXTcontraseña.Text == "")
            {
                MessageBox.Show("Complete Los Campos ");
            }
            else
            {
                OBJtabla = OBJlogin.MTDusuarios(TXTusuario.Text);
                for (int i = 0; i < OBJtabla.Rows.Count; i++)
                {
                    OBJusuarios.Add(OBJtabla.Rows[i]["NombreUsuario"].ToString());
                    OBJusuarios.Add(OBJtabla.Rows[i]["Contraseña"].ToString());
                    OBJusuarios.Add(OBJtabla.Rows[i]["TipoUsuario"].ToString());
                }
                if (OBJusuarios.Count > 0 )
                {
                    if (OBJusuarios[0] == TXTusuario.Text && OBJusuarios[1] == TXTcontraseña.Text)
                    {
                        OBJprincipal.MTDtusuario(tusuario);
                        MessageBox.Show("Bienvenido " + TXTusuario.Text);
                        DataTable OBJtabla1 = new DataTable();
                        OBJtabla1 = OBJlogin.MTDtusuario(TXTusuario.Text);
                        tusuario = OBJtabla1.Rows[0]["TipoUsuario"].ToString();
                        OBJprincipal.MTDtusuario(tusuario);
                        OBJprincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                        LBLocontraseña.Visible = true;
                        LBLrecuperar.Visible = true;
                    }
                }
                
            }
        }

        private void LBLrecuperar_Click(object sender, EventArgs e)
        {
            FRMreccorreo OBJrecuperar = new FRMreccorreo();
            OBJrecuperar.Show();
            this.Hide();
        }
    }
}
