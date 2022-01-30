using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sportsShopWebApp.Controllers
{
    public class SportsEquipmentController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        // GET: SportsEquipment
        public ActionResult AllSportsEquipment(string selectedType)
        {
            switch (selectedType)
            {
                case "SoccerEquipment":
                    return View(SportsShopDB.sportsEquipments.Where(item => item.category == "soccer").ToList());

                case "BasketballEquipment":
                    return View(SportsShopDB.sportsEquipments.Where(item => item.category == "basketball").ToList());

                case "SortedByASCOrder":
                    return View(SportsShopDB.sportsEquipments.OrderBy(item => item.price).ToList());

                case "SortedByDESOrder":
                    return View(SportsShopDB.sportsEquipments.OrderByDescending(price => price.price).ToList());
            }
            return View(SportsShopDB.sportsEquipments.ToList());
        }
    }
}