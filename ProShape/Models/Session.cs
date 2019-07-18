using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProShapeAPI.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}