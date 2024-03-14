using Microsoft.EntityFrameworkCore;
using RepositoryPractice3.Models;

namespace RepositoryPractice3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblCustomer> tblCustomer { get; set; }
        public DbSet<tblIssue> tblIssue { get; set; }
        public DbSet<VewTblCustomerWithIssue> VewTblCustomerWithIssue { get; set}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VewTblCustomerWithIssue>(Entity =>
            {
                Entity.HasNoKey().ToView("VewTblCustomerWithIssue");
                Entity.Property(e => e.CustomerId).HasColumnName("CustomerId");
                Entity.Property(e => e.CustomerName).HasMaxLength(50).HasColumnName("CustomerName");
                Entity.Property(e => e.IssueId).HasColumnName("IssueId");
                Entity.Property(e => e.Problem).HasColumnName("Problem");
                Entity.Property(e => e.PaymentStatus).HasColumnName("PaymentStatus");
                Entity.Property(e => e.WorkStatus).HasColumnName("WorkStatus");
            }); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
