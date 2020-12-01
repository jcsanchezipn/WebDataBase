using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDataBase.Models;

namespace WebDataBase.Data
{
    public class WebDataBaseContext : DbContext
    {
        public WebDataBaseContext (DbContextOptions<WebDataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<WebDataBase.Models.Clientes> Clientes { get; set; }

        public DbSet<WebDataBase.Models.Personal> Personal { get; set; }
    }
}
