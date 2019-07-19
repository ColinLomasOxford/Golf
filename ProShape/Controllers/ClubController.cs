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
    [Route("api/Club")]
    public class ClubController : Controller
    {
        string connstring = "Server =localhost; Port =5434; User Id=postgres;Password=postgres;Database=Golf";

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // Making connection with Npgsql provider
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                "select row_to_json(t) from( select * from Club) t; ", conn);

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

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                string.Format("select row_to_json(t) from( select * from Club where id = {0}) t; ", id), conn);

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

        // POST: api/Club
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Club/5
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
