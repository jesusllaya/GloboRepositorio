using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgilesGloboGroup.Models
{
    public class TareasXTipoProyecto
    {
        public TipoProyecto tipoProyecto { get; set; }
        public List<Tarea> listaTareas { get; set; }
        public List<Int32> listaPreOrden { get; set; }
    }
}