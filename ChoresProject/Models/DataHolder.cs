using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoresProject.Models
{
    public static class DataHolder
    {        
        public static List<Chores> GetChores()
        {
            List<Chores> cList = new List<Chores>()
            {
                new Chores(){ID=100, Chore="Kitchen Clean Table", ChoreAssigned=DateTime.Now.AddDays(-7), IsCompleted = false},
                new Chores(){ID=101, Chore="Kitchen Wash Dishes", ChoreAssigned=DateTime.Now.AddDays(-6), IsCompleted = false},
                new Chores(){ID=102, Chore="Kitchen Sweep Floor", ChoreAssigned=DateTime.Now.AddDays(-3), IsCompleted = false},
                new Chores(){ID=103, Chore="Kitchen Clean Stove", ChoreAssigned=DateTime.Now.AddDays(-2), IsCompleted = false},
                new Chores(){ID=104, Chore="Kitchen Clean Refrigerator", ChoreAssigned=DateTime.Now.AddDays(-4), IsCompleted = false},
                new Chores(){ID=105, Chore="Kitchen Paint Walls Blue", ChoreAssigned=DateTime.Now.AddDays(-1), IsCompleted = false},
                new Chores(){ID=106, Chore="Bedroom Vacuum Floors", ChoreAssigned=DateTime.Now.AddDays(-9), IsCompleted = false},
                new Chores(){ID=107, Chore="Bedroom Wash Sheets", ChoreAssigned=DateTime.Now.AddDays(-10), IsCompleted = false},
                new Chores(){ID=108, Chore="Bedroom Paint Room Green", ChoreAssigned=DateTime.Now.AddDays(-9), IsCompleted = false},
                new Chores(){ID=109, Chore="Bedroom Wash Windows", ChoreAssigned=DateTime.Now.AddDays(-11), IsCompleted = false},
                new Chores(){ID=110, Chore="Bedroom Clean Mirrors", ChoreAssigned=DateTime.Now.AddDays(-8), IsCompleted = false},
            };
            return cList;
        
        }
    }
}