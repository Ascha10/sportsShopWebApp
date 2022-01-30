using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sportsShopWebApp.Controllers
{
    public class ShoesController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        public ActionResult AllShoes(string option)
        {
            if (option == "Discount")
            {
                return View(SportsShopDB.Shoes.Where(item => item.haveDiscount == true).ToList());
            }
            else
            {
                return View(SportsShopDB.Shoes.ToList());
            }
        }
    }
}
