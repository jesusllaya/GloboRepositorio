using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgilesGloboGroup.Models;
using AgilesGloboGroup.Services;
using System.Data;
using System.Data.SqlClient;

namespace AgilesGloboGroup.Services
{
    public class TareasXtipoProyectoService
    {
        public List<TipoProyectoService> ObtenerListadoTipoProyectos()
        {
            //try
            //{
                List<TipoProyectoService> listaTipoProyecto = new List<TipoProyectoService>();

                Conexion conexion = new Conexion();
                SqlConnection con = conexion.conexionBD();


                string consulta = "Select TP.id_tipoProyecto, TP.nombre from Tipo_Proyecto TP";
                SqlCommand cmd = new SqlCommand(consulta, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TipoProyectoService tipo = new TipoProyectoService();
                    tipo.id_tipoProyecto = Convert.ToInt32(dr["id_tipoProyecto"].ToString());
                    tipo.nombre = Convert.ToString(dr["nombre"].ToString());
                    listaTipoProyecto.Add(tipo);
                }

            con.Close();
            cmd.Dispose();
            dr.Close();

                return listaTipoProyecto;
           /* }
            catch (Exception ex)
            {
                
            }
            finally
            {
               //cerrar conexion y dispo
            }
            */

        }
    }
}