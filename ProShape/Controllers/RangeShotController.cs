using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace ProShape.Controllers
{
    [Produces("application/json")]
    [Route("api/RangeShot")]
    public class RangeShotController : Controller
    {
        string connstring = "Server =localhost; Port =5434; User Id=postgres;Password=postgres;Database=Golf";
        string rangeShotQuery = "select s3.id as sessionId, s3.name as sessionName, " +
                                    "c.id as clubId, c.name as ClubName, " +
                                    "i1.id as IntendedShapeId, i1.name as IntendedShapeName, " +
                                    "a1.id as ActualShapeId, a1.name as ActualShapeName, " +
                                    "s1.id as StrikeId, s1.name as StrikeName " +
                                "from rangeshots t " +
                                "inner join Sessions s3 on s3.id = t.sessionid " +
                                "inner join Club c on c.id = t.ClubId " +
                                "inner join IntendedShape i1 on i1.id = t.IntendedShapeId " +
                                "inner join ActualShape a1 on a1.id = t.ActualShapeId " +
                                "inner join Strike s1 on s1.id = t.StrikeId";
        // GET: api/RangeShot
        [HttpGet]
        public IEnumerable<string> Get()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                string.Format("select row_to_json(t) from( {0}) t; ", rangeShotQuery), conn);

            NpgsqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0).ToString());
                }
            }

            conn.Close();
            return list;
        }

        // GET: api/RangeShot/5
        [HttpGet("{id}", Name = "RangeShotGet")]
        public string Get(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                string.Format("select row_to_json(t) from( {0} where t.id = {1}) t; ", rangeShotQuery, id), conn);

            NpgsqlDataReader reader = command.ExecuteReader();

            string retValue = string.Empty;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    retValue = reader.GetString(0).ToString();
                }
            }

            conn.Close();
            return retValue;
        }
        
        // POST: api/RangeShot
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/RangeShot/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
