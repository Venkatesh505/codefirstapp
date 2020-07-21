using codefirstapp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirstapp.Data
{
    public class PlayerContext:DbContext
    {
        public PlayerContext():base("DefaultConnection")
        {                
        }

        public DbSet<Players> Players { get; set; }
    }
}