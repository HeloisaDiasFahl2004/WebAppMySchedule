using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMySchedule.Models;

namespace WebAppMySchedule.Data
{
    public class WebAppMyScheduleContext : DbContext
    {
        public WebAppMyScheduleContext (DbContextOptions<WebAppMyScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMySchedule.Models.Person> Person { get; set; }

        public DbSet<WebAppMySchedule.Models.Address> Address { get; set; }

        public DbSet<WebAppMySchedule.Models.Phone> Phone { get; set; }
    }
}
