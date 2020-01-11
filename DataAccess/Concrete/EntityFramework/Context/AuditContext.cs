using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
  public class AuditContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=AuditDb;Trusted_Connection=true");
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<TemplateSurveyMasters> TemplateSurveyMasters { get; set; }
        public DbSet<TemplateSurveyDetails> TemplateSurverDetails { get; set; }
        public DbSet<SurveyMasters> SurveyMasters { get; set; }
        public DbSet<SurveyDetails> SurveyDetails { get; set; }
        public DbSet<SurveyDetailImages> SurveyDetailImages { get; set; }


    }
}
