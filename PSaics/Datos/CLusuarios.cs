using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PSaics.Datos
{
    class CLusuarios
    {
        public string NombreUsuario { get; set; }
        public string Documento { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string TipoUsuario { get; set; }
        CLconexion OBJconexion = new CLconexion();
        public void MTDregistrar()
        {
            string consulta = "INSERT INTO Usuario(Documento,TipoUsuario,NombreUsuario,Correo,Contraseña)VALUES('" + Documento + "','" + TipoUsuario + "','" + NombreUsuario + "','" + Correo + "','" + Contraseña + "')";
            OBJconexion.consulta = consulta;
            OBJconexion.MTDcc();
        }
        public void MTDactualizar()
        {
            string consulta = "UPDATE Usuario SET NombreUsuario='" + NombreUsuario + "',Documento='" + Documento + "',Contraseña='" + Contraseña + "',Correo='" + Correo + "',TipoUsuario='" + TipoUsuario + "' WHERE Documento='" + Documento + "'";
            OBJconexion.consulta = consulta;
            OBJconexion.MTDcc();
        }
        public void MTDeliminar()
        {
            string consulta = "DELETE Usuario WHERE Documento='" + Documento + "'";
            OBJconexion.consulta = consulta;
            OBJconexion.MTDcc();
        }
        public List<CLusuarios> MTDbuscar()
        {
            DataTable OBJtabla = new DataTable();
            List<CLusuarios> OBJlista = new List<CLusuarios>();
            string consulta = "";
            if (Documento == "")
            {
                consulta = "SELECT * FROM Usuario";
            }
            else
            {
                consulta = "SELECT * FROM Usuario Where Documento='" + Documento + "'";
            }
            OBJconexion.consulta = consulta;
            OBJtabla = OBJconexion.MTDcd();
            for (int i = 0; i < OBJtabla.Rows.Count; i++)
            {
                CLusuarios OBJusuarios = new CLusuarios();
                OBJusuarios.NombreUsuario = OBJtabla.Rows[i]["NombreUsuario"].ToString();
                OBJusuarios.Documento = OBJtabla.Rows[i]["Documento"].ToString();
                OBJusuarios.Contraseña = OBJtabla.Rows[i]["Contraseña"].ToString();
                OBJusuarios.Correo = OBJtabla.Rows[i]["Correo"].ToString();
                OBJusuarios.TipoUsuario = OBJtabla.Rows[i]["TipoUsuario"].ToString();
                OBJlista.Add(OBJusuarios);
            }
            return OBJlista;
        }



    }
}
