﻿using System;
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
                string.Format("select row_to_json(t) from( select * from Club where {0}) t; " + id), conn);

            NpgsqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    conn.Close();
                    return (reader.GetString(0).ToString());
                }
            }

            conn.Close();
            return "{}";
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
