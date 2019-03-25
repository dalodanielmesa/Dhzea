using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace PSaics.Datos
{
    class CLlogin
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        CLconexion OBJconexion = new CLconexion();
        DataTable OBJtabla = null;
        public DataTable MTDusuarios(string nusuario)
        {
            OBJtabla = new DataTable();
            string consulta = "SELECT * FROM Usuario WHERE NombreUsuario='" + nusuario + "'";
            OBJconexion.consulta = consulta;
            OBJtabla = OBJconexion.MTDcd();
            return OBJtabla;
        }
        public DataTable MTDtusuario(string nusuario)
        {
            OBJtabla = new DataTable();
            string consulta = "SELECT TipoUsuario FROM Usuario WHERE NombreUsuario='" + nusuario + "'";
            OBJconexion.consulta = consulta;
            OBJtabla = OBJconexion.MTDcd();
            return OBJtabla;
        }
    }
}
