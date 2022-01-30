using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sportsShopWebApp.Controllers.API
{
    public class ShoesController : ApiController
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        // GET: api/Shoes
        public IHttpActionResult Get()
        {
            return Ok(SportsShopDB.Shoes.ToList());
        }


        // GET: api/Shoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Shoe Shoe = SportsShopDB.Shoes.First(item => item.shoesId == id);

                if (Shoe != null)
                {
                    return Ok(Shoe);
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }


        // POST: api/Shoes
        public IHttpActionResult Post([FromBody] Shoe shoe)
        {
            try
            {
                if (shoe != null)
                {
                    SportsShopDB.Shoes.InsertOnSubmit(shoe);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Shoe Was Added Successfully ");
                }
                return BadRequest();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }

        }

        // PUT: api/Shoes/5
        public IHttpActionResult Put(int id, [FromBody] Shoe shoe)
        {
            try
            {
                Shoe shoeToEdit = SportsShopDB.Shoes.First(item => item.shoesId == id);

                if (shoe != null)
                {
                    shoeToEdit.typeOfShoe = shoe.typeOfShoe;
                    shoeToEdit.company = shoe.company;
                    shoeToEdit.model = shoe.model;
                    shoeToEdit.price = shoe.price;
                    shoeToEdit.quantity = shoe.quantity;
                    shoeToEdit.haveDiscount = shoe.haveDiscount;
                    shoeToEdit.imageData = shoe.imageData;

                    SportsShopDB.SubmitChanges();
                    return Ok("The Shoe Was Edited Successfully ");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }

        }


        // DELETE: api/Shoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Shoe shoe = SportsShopDB.Shoes.First(item => item.shoesId == id);

                if (shoe != null)
                {
                    SportsShopDB.Shoes.DeleteOnSubmit(shoe);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Shoe Was Deleted");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }

    }
}
