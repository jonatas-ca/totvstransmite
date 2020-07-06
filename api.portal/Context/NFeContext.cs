using Microsoft.EntityFrameworkCore; 
using api.portal.models;
using System.Collections.Generic;

namespace api.portal.Context
{
    public class NFeContext: DbContext
    {
        public NFeContext(DbContextOptions<NFeContext> options): base(options){
        }

        public DbSet<NFe> NFes { get; set; }
        
    }
}