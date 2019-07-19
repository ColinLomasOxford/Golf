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
    [Route("api/Shot")]
    public class ShotController : Controller
    {
        string connstring = "Server =localhost; Port =5434; User Id=postgres;Password=postgres;Database=Golf";
        string teeshotQuery = "select s3.id as sessionId, s3.name as sessionName, " +
                "c.id as clubId, c.name as ClubName, " +
                "i1.id as IntendedShapeId, i1.name as IntendedShapeName, " +
                "i2.id as IntendedTrajectoryId, i2.name as IntendedTrajectoryName, " +
                "i3.id as IntendedPowerId, i3.name as IntendedPowerName, " +
                "a1.id as ActualShapeId, a1.name as ActualShapeName, " +
                "s1.id as StrikeId, s1.name as StrikeName, " +
                "a2.Id as ActualTrajectoryId, a2.name as ActualTrajectoryName, " +
                "a3.Id as ActualPowerId, a3.name as ActualPowerName, " +
                "c1.Id as ConcentrationQualityId, c1.name as ConcentrationQualityName, " +
                "s2.Id as ShotTypeId, s2.name as ShotTypeName, " +
                "w1.Id as WindId, w1.name as WindName, " +
                "t1.Id as TeeShotResultId, t1.name as TeeShotResultName " +
                "from teeshots t " +
                "inner join Sessions s3 on s3.id = t.sessionid " +
                "inner join Club c on c.id = t.ClubId " +
                "inner join IntendedShape i1 on i1.id = t.IntendedShapeId " +
                "inner join IntendedTrajectory i2 on i2.id = t.IntendedTradjectoryId " +
                "inner join IntendedPower i3 on i3.id = t.IntendedPowerId " +
                "inner join ActualShape a1 on a1.id = t.ActualShapeId " +
                "inner join Strike s1 on s1.id = t.StrikeId " +
                "inner join ActualTrajectory a2 on a2.id = t.ActualTrajectoryId " +
                "inner join ActualPower a3 on a3.id = t.ActualPowerId " +
                "inner join ConcentrationQuality c1 on c1.id = t.ConcentrationQualityId " +
                "inner join ShotType s2 on s2.id = t.ShotTypeId " +
                "inner join Wind w1 on w1.id = t.WindId " +
                "inner join TeeShotResult t1 on t1.id = t.TeeShotOutCome";

        // GET: api/Shot
        [HttpGet]
        public IEnumerable<string> Get()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                string.Format("select row_to_json(t) from( {0}) t; ", teeshotQuery), conn);

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

        // GET: api/Shot/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                string.Format("select row_to_json(t) from( {0} where t.id = {1}) t; ", teeshotQuery, id), conn);

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
        
        // POST: api/Shot
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Shot/5
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
