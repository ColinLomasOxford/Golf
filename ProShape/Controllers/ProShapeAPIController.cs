using System.Web.Http;
using ProShapeAPI.Models;

namespace ProShapeAPI.Controllers
{
    public class ProShapeAPIController : ApiController
    {
        private ProShapeAPIContext db = new ProShapeAPIContext();

        /*// GET: api/ProShapeAPI
        public IQueryable<TeeShots> GetClubs()
        {
            return db.SessionTeeShots;
        }

        // GET: api/ProShapeAPI/5
        [ResponseType(typeof(TeeShots))]
        public IHttpActionResult GetShot(int id)
        {
            TeeShots shot = db.SessionTeeShots.Find(id);
            if (shot == null)
            {
                return NotFound();
            }

            return Ok(shot);
        }

        // POST: api/ProShapeAPI
        [ResponseType(typeof(Club))]
        public IHttpActionResult PostShot(TeeShots teeShots)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SessionTeeShots.Add(teeShots);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = teeShots.Id }, teeShots);
        }

        // PUT: api/ProShapeAPI/5
        /*[ResponseType(typeof(void))]
        public IHttpActionResult PutClub(int id, Club club)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != club.Id)
            {
                return BadRequest();
            }

            db.Entry(club).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClubExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }*/



        /*// DELETE: api/ProShapeAPI/5
        [ResponseType(typeof(Club))]
        public IHttpActionResult DeleteClub(int id)
        {
            Club club = db.Clubs.Find(id);
            if (club == null)
            {
                return NotFound();
            }

            db.Clubs.Remove(club);
            db.SaveChanges();

            return Ok(club);
        }*/

        /*protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClubExists(int id)
        {
            return db.Clubs.Count(e => e.Id == id) > 0;
        }*/
    }
}