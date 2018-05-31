using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AgilesGloboGroup.Models;

namespace AgilesGloboGroup.Services
{
    public class TareasService
    {
        public List<Tarea> ObtenerListadoTareas()
        {
            List<Tarea> listaTarea = new List<Tarea>();
            Conexion conexion = new Conexion();
            SqlConnection con = conexion.conexionBD();
            con.Open();
            string consulta = "SELECT T.id_tarea, T.NombreTarea FROM ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            return listaTarea;
        }
        
        
    }
}