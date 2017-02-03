using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using apiAnimal.Models;
using System.Web.Http.Cors;



namespace apiAnimal.Controllers.v1
{
    public class AnimalDatasController : BaseController
    {
        
        /// <summary>
        /// 取得所有動物資料
        /// </summary>
        /// <returns>IQueryable &lt; Animal&gt;.</returns>
        ///GET: api/v1/AnimalDatas
       [EnableCors(origins: "*", headers: "*", methods: "*")]
       [Queryable]
       public IQueryable<animalData>GetanimalData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var animal = db.animalData.Include(p => p.animalData_Pic)
                                     .Include(c=>c.animalData_Condition)
                                     .AsQueryable();

            return animal;
        }

        /// <summary>
        /// 取得單筆動物資料
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>IHttpActionResult.</returns>
        //GET: api/v1/AnimalDatas/5
        [ResponseType(typeof(animalData))]
        public IHttpActionResult GetanimalData(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            //animalData animalData = db.animalData.Find(id);

            var animal = db.animalData.Include(p => p.animalData_Pic)
                                      .Include(c => c.animalData_Condition)
                                      .AsQueryable().FirstOrDefault(r=>r.animalID==id);

            if (animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }



        /// <summary>
        /// 修改單筆動物資料
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <param name="animalData">The AnimalDatas</param>
        /// <returns>IHttpActionResult.</returns>
        // PUT: api/v1/AnimalDatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutanimalData(int id, animalData animalData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != animalData.animalID)
            {
                return BadRequest();
            }

            db.Entry(animalData).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!animalDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);

        }
        /// <summary>
        /// 新增動物資料
        /// </summary>
        /// <param name="animalData">The AnimalDatas</param>
        /// <returns>IHttpActionResult.</returns>
        // POST: api/v1/AnimalDatas
        [ResponseType(typeof(animalData))]
        public IHttpActionResult PostanimalData(animalData animalData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.animalData.Add(animalData);
          
            db.SaveChanges();

            return CreatedAtRoute("Apiv1", new { id = animalData.animalID }, animalData);
        }
        /// <summary>
        /// 刪除單筆動物資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IHttpActionResult.</returns>
        // DELETE: api/v1/AnimalDatas/5
        [ResponseType(typeof(animalData))]
        public IHttpActionResult DeleteanimalData(int id)
        {
            animalData animalData = db.animalData.Find(id);
            if (animalData == null)
            {
                return NotFound();
            }

            db.animalData.Remove(animalData);
            db.SaveChanges();

            return Ok(animalData);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private bool animalDataExists(int id)
        {
            return db.animalData.Count(e => e.animalID == id) > 0;
        }
    }
}