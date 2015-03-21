using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoresProject.Models
{
    public class Chores
    {
        public int ID { get; set; }
        public string Chore { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime ChoreAssigned { get; set; }
    }
}