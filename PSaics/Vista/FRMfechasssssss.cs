using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSaics.Datos;
using PSaics.Properties;
using System.IO;

namespace PSaics.Vista
{
    public partial class FRMfechasssssss : Form
    {
        public FRMfechasssssss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string f = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            // string h = dateTimePicker2.Value.ToString("HH:mm");
            //string fechas = f + " " + h;

            string fechaparalareserva = string.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value) + " " + dateTimePicker2.Value.ToString("HH:mm");
            //DateTime algo = DateTime.Now;

            CLconexion Oc = new CLconexion();

            //dateTimePicker1.Value = DateTime.Parse(fechas);
            //MessageBox.Show(f+" "+h);
            //MessageBox.Show(fechas);
            //textBox1.Text = fechas;

            string consulta = "UPDATE Reserva SET SfechaHora='" + fechaparalareserva + "' WHERE Duracion =10";
            Oc.consulta = consulta;
            //textBox1.Text = consulta;
            Oc.MTDcc();
        }



        private void FRMfechasssssss_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "uno")
            {
                MessageBox.Show("uno");
            }
            else
            {
                MessageBox.Show("dos");
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            string ruta = @"nombreimagen";
            button1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory()+ruta);
        }
    }
}
