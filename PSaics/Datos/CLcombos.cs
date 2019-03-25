using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PSaics.Datos
{
    class CLcombos
    {
        CLconexion OBJconexion = new CLconexion();
        DataTable OBJtabla = null;
        public DataTable MTDrol()
        {
            OBJtabla = new DataTable();
            string consulta = "SELECT * FROM Rol";
            OBJconexion.consulta = consulta;
            OBJtabla = OBJconexion.MTDcd();
            return OBJtabla;
        }
        public DataTable MTDescuela()
        {            
            OBJtabla = new DataTable();
            string consulta = "SELECT * FROM Escuela";
            OBJconexion.consulta = consulta;
            OBJtabla = OBJconexion.MTDcd();
            return OBJtabla;
        }




    }
}
