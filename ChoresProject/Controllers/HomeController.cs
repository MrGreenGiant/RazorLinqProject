using ChoresProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoresProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Chores Page";

            ChoreViewModel viewModel = new ChoreViewModel();
            
            //Variable to grab List of Data
            var dataKitchen = DataHolder.GetChores();

            var Kdata2 = dataKitchen.Where(to => to.ID >= 100).ToList();

            viewModel.MyChores = Kdata2;

           return View(viewModel);
        }

        public ActionResult Kitchen()
        {
            ViewBag.Message = "Welcome to the Kitchen Page";

            /*
             * Variable to grab List of DataHolder Class
             */
            ChoreViewModel viewModel = new ChoreViewModel();
            /*
             Variable to grab List of DataHolder Class
             */
            var dataBedroom = DataHolder.GetChores();
            /*
             Create the LINQ calls to grab data from the DataHolder Class
             */
            var Kdata3 = dataBedroom.Where(to => to.ChoreAssigned < DateTime.Now.AddDays(-8)).ToList();
            var Kdata2 = dataBedroom.Where(to => to.ID >= 100).ToList();
            var Kdata = dataBedroom.Where(to => to.Chore.Contains("Kitchen")).ToList();
            /*
             Now grab the variable called Kdata that created the LINQ call.
             */ 
            viewModel.MyChores = Kdata;
            /*
             The viewMode was set via the ChoreViewModel class which created the List<>
             */
            return View(viewModel);
        }

        public ActionResult Bedroom()
        {
            ViewBag.Message = "Welcome to the Bedroom Page";
            //Chore List Bedroom
            ChoreViewModel viewModel2 = new ChoreViewModel();

            var dataBedroom = DataHolder.GetChores();

            var Bdata2 = dataBedroom.Where(to => to.ID == 100 || to.ID == 106).ToList();

            viewModel2.MyChores = Bdata2;
            
            return View(viewModel2);
        }
    }
}