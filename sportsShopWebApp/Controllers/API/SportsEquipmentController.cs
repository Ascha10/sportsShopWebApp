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
    public class SportsEquipmentController : ApiController
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        // GET: api/SportsEquipment
        public IHttpActionResult Get()
        {
            return Ok(SportsShopDB.sportsEquipments.ToList());
        }

        // GET: api/SportsEquipment/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                sportsEquipment equipment = SportsShopDB.sportsEquipments.First(item => item.sportsEquipmentId == id);

                if (equipment != null)
                {
                    return Ok(equipment);
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


        // POST: api/SportsEquipment
        public IHttpActionResult Post([FromBody]sportsEquipment equipment)
        {
            try
            {
                if (equipment != null)
                {
                    SportsShopDB.sportsEquipments.InsertOnSubmit(equipment);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Equipment Was Added Successfully ");
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

        // PUT: api/SportsEquipment/5
        public IHttpActionResult Put(int id, [FromBody] sportsEquipment equipment)
        {
            try
            {
                sportsEquipment equipmentToEdit = SportsShopDB.sportsEquipments.First(item => item.sportsEquipmentId == id);

                if (equipmentToEdit != null)
                {
                    equipmentToEdit.category = equipment.category;
                    equipmentToEdit.productName = equipment.productName;
                    equipmentToEdit.company = equipment.company;
                    equipmentToEdit.price = equipment.price;
                    equipmentToEdit.quantity = equipment.quantity;
                    equipmentToEdit.imageData = equipment.imageData;

                    SportsShopDB.SubmitChanges();
                    return Ok("The Equipment Was Edited Successfully ");
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


        // DELETE: api/SportsEquipment/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                sportsEquipment equipment = SportsShopDB.sportsEquipments.First(item => item.sportsEquipmentId == id);

                if (equipment != null)
                {
                    SportsShopDB.sportsEquipments.DeleteOnSubmit(equipment);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Equipment Was Deleted");
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
