using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace ProShape.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string connstring = "Server =localhost; Port =5434; User Id=postgres;Password=postgres;Database=Golf";
            // Making connection with Npgsql provider
            NpgsqlConnection conn = new NpgsqlConnection(connstring);

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(
                "SELECT * FROM simple_table;", conn);

            NpgsqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetInt32(0).ToString());
                    list.Add(reader.GetString(1));
                }
            }

            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
