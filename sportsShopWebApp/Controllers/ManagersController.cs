using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sportsShopWebApp.Controllers
{
    public class ManagersController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        public ActionResult Managers()
        {
            ViewBag.ShoesList = SportsShopDB.Shoes.ToList();
            return View();
        }

        public ActionResult GetAllShoes()
        {
            return View(SportsShopDB.Shoes.ToList());
        }

        public ActionResult GetAllShirt()
        {
            return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt").ToList());
        }
        public ActionResult GetAllPants()
        {
            return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant").ToList());
        }
        public ActionResult GetAllSportsEquipment()
        {
            return View(SportsShopDB.sportsEquipments.ToList());
        }

    }
}
