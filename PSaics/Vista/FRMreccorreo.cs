using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using PSaics.Datos;

namespace PSaics.Vista
{
    public partial class FRMreccorreo : Form
    {
        public FRMreccorreo()
        {
            InitializeComponent();
        }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        CLconexion OBJconexion = new CLconexion();
        private void BTNrecuperar_Click(object sender, EventArgs e)
        {
            DataTable OBJtabla = new DataTable();
            List<string> OBJlista = new List<string>();
            if (TXTdocumento.Text != "")
            {
                string consulta = "SELECT * FROM Usuario WHERE Documento='" + TXTdocumento.Text + "'";
                OBJconexion.consulta = consulta;
                OBJtabla = OBJconexion.MTDcd();
                for (int i = 0; i < OBJtabla.Rows.Count; i++)
                {
                    FRMreccorreo OBJrecorreo = new FRMreccorreo();
                    OBJlista.Add(OBJtabla.Rows[i]["NombreUsuario"].ToString());
                    OBJlista.Add(OBJtabla.Rows[i]["Contraseña"].ToString());
                    OBJlista.Add(OBJtabla.Rows[i]["correo"].ToString());
                }
                usuario = OBJlista[0];
                contraseña = OBJlista[1];
                correo = OBJlista[2];

                MTDenviar();
            }

            else
            {
                MessageBox.Show("Documento es invalido");
            }
        }

        public void MTDenviar()
        {

            MailMessage OBJmensaje = new MailMessage();
            OBJmensaje.To.Add(correo);
            OBJmensaje.From = new MailAddress("juanfed2000@gmail.com", "Canchas Sinteticas La Maxima-Sogamoso", System.Text.Encoding.UTF8);
            OBJmensaje.Subject = "Recuperacion De Contraseña" ;
            OBJmensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            OBJmensaje.Body = "La contraseña del usuario " + usuario + " correspondiente al correo " + correo + " es " + contraseña;
            OBJmensaje.BodyEncoding = System.Text.Encoding.UTF8;
            OBJmensaje.IsBodyHtml = false;


            SmtpClient OBJcliente = new SmtpClient();
            OBJcliente.Credentials = new NetworkCredential("juanfed2000@gmail.com", "1007343153");
            OBJcliente.Port = 587;
            OBJcliente.Host = "smtp.gmail.com";
            OBJcliente.EnableSsl = true;
            try
            {
                OBJcliente.Send(OBJmensaje);
                FRMlogin OBJlogin = new FRMlogin();
                MessageBox.Show("Hemos enviado la contraseña a tu correo "+correo+", por favor verificalo!");
                OBJlogin.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar el correo");
            }
        }

        private void BTNatras_Click(object sender, EventArgs e)
        {
            FRMlogin OBJlogin = new FRMlogin();
            OBJlogin.Show();
            this.Hide();
        }
    }
}




