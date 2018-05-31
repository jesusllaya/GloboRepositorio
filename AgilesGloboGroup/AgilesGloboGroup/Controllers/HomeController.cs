using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgilesGloboGroup.Services;
using AgilesGloboGroup.Models;

namespace AgilesGloboGroup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//representa una pagina dentro del navegador
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

        /*public ActionResult Tareas()
        {
            var tareasService = new TareasService();
            var model = tareasService
           
            return View();
        }*/


        //[HttpGet]
        public ActionResult TareasXTipoDeProyecto()
        {
            var tareasXtipoProyectoService = new TareasXtipoProyectoService();
            var model = tareasXtipoProyectoService.ObtenerListadoTipoProyectos();

            List<SelectListItem> lst = new List<SelectListItem>();
            foreach (TipoProyectoService tipo in model)
            {
                lst.Add(new SelectListItem() {Text = tipo.nombre, Value = Convert.ToString(tipo.id_tipoProyecto) });
            }


            ViewBag.Opciones = lst;


            return View();
        }



    }
}