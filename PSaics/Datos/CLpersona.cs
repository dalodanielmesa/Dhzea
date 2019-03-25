using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PSaics.Datos
{
    class CLpersona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string eescuela { get; set; }
        public string estudiante { get; set; }
        public string nacudiente { get; set; }
        public string tacudiente { get; set; }
        public string contraseña { get; set; }
        public int rol { get; set; }
        public string cortesiasancion { get; set; }
        public int escuela { get; set; }
        public int est { get; set; }
        public string dbusqueda { get; set; }
        CLconexion OBJconexion = new CLconexion();
        DataTable OBJtabla = null;
        public int MTDregistro()
        {
            string consulta = "";
            if (est == 1)
            {
                consulta = "INSERT INTO Persona(Nombre,Apellido,Documento,Telefono,Correo,Eescuela,Estudiante,Nacudiente,Tacudiente,Contraseña,IdRol,IdEscuela)VALUES('" + nombre + "','" + apellido + "','" + documento + "','" + telefono + "','" + correo + "','" + eescuela + "','" + estudiante + "','" + nacudiente + "','" + tacudiente + "','" + contraseña + "','" + rol + "','" + escuela + "')";
            }
            else if (est == 0)
            {
                consulta = "INSERT INTO Persona(Nombre,Apellido,Documento,Telefono,Correo,Eescuela,Estudiante,Contraseña,IdRol)VALUES('" + nombre + "','" + apellido + "','" + documento + "','" + telefono + "','" + correo + "','" + eescuela + "','" + estudiante + "','" + contraseña + "','" + rol + "')";
            }

            OBJconexion.consulta = consulta;
            int r = OBJconexion.MTDcc();
            return r;

        }
        public int MTDactualizar()
        {
            string consulta = "UPDATE Persona SET Nombre='"+nombre+"',Apellido='"+apellido+"',Documento='"+documento+ "',Telefono='" + telefono+ "',Correo='" + correo+ "',Eescuela='" + eescuela+ "',Estudiante='" + estudiante+ "',Contraseña='" + contraseña+ "',IdRol='" + rol+"' WHERE Documento='" + documento + "'";
            OBJconexion.consulta = consulta;
            int r = OBJconexion.MTDcc();
            return r;
        }
        public DataTable MTDbuscar()
        {
            OBJtabla = new DataTable();
            string consulta="";
            if (dbusqueda=="")
            {
                consulta = "SELECT IdPersona,Nombre,Apellido,Documento,Telefono,Correo,Eescuela,Estudiante,Nacudiente,Tacudiente,Contraseña,Rol,Escuela FROM Persona LEFT JOIN Rol ON (Rol.IdRol=Persona.IdRol) LEFT JOIN Escuela ON(Escuela.IdEscuela=Persona.IdEscuela)"; 
            }
            else
            {
                consulta = "SELECT IdPersona,Nombre,Apellido,Documento,Telefono,Correo,Eescuela,Estudiante,Nacudiente,Tacudiente,Contraseña,Rol,Escuela FROM Persona LEFT JOIN Rol ON (Rol.IdRol=Persona.IdRol) LEFT JOIN Escuela ON(Escuela.IdEscuela=Persona.IdEscuela) WHERE Documento='" + dbusqueda + "'";
            }            
            OBJconexion.consulta = consulta;
            OBJtabla = OBJconexion.MTDcd();
            return OBJtabla;
        }
        public int MTDeliminar()
        {
            string consulta = "DELETE Persona WHERE Documento='"+documento+"'";            
            OBJconexion.consulta = consulta;
            int r = OBJconexion.MTDcc();
            return r;
        }






    }
}
