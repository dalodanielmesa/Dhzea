using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PSaics.Datos
{
    class CLconexion
    {
        SqlConnection OBJconexion = null;
        SqlCommand OBJcomando = null;
        SqlDataAdapter OBJadaptador = null;
        DataTable OBJtabla = null;
        public string consulta { get; set; }

        public CLconexion()
        {
            try
            {
                OBJconexion = new SqlConnection("Data Source=DESKTOP-3GFOLVP;Initial Catalog=BdpSaics;Integrated Security=True");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la comunicacion con la base de datos");
            }

        }
        public DataTable MTDcd()
        {
            OBJtabla = new DataTable();
            try
            {
                OBJadaptador = new SqlDataAdapter(consulta, OBJconexion);
                OBJconexion.Open();
                OBJadaptador.Fill(OBJtabla);
                OBJconexion.Close();
                return OBJtabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la comunicacion");
                OBJconexion.Close();
                return OBJtabla;
            }
        }
        public int MTDcc()
        {
            int r = 999;
            try
            {
                OBJcomando = new SqlCommand(consulta, OBJconexion);
                OBJconexion.Open();
                r = OBJcomando.ExecuteNonQuery();
                OBJconexion.Close();
                return r;
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
                OBJconexion.Close();
                return r;
            }
        }
    }
}
