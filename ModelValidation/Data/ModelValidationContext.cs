using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelValidation.Models;

namespace ModelValidation.Data
{
    public class ModelValidationContext : DbContext
    {
        public ModelValidationContext (DbContextOptions<ModelValidationContext> options)
            : base(options)
        {
        }

        public DbSet<ModelValidation.Models.Person> Person { get; set; }
    }
}
