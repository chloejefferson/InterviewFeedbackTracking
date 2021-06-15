using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InterviewFeedbackTracking.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser // Reference to add properties to applicationuser https://stackoverflow.com/questions/40532987/how-to-extend-identityuser-with-custom-property/40579369
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public IndustryEnum Industry { get; set; }
        public string About { get; set; }

        public virtual List<Interview> Interviews { get; set; } = new List<Interview>();
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<InterviewProfile> InterviewProfiles {get;set;}

        public DbSet<InterviewProfileStep> InterviewProfileSteps { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

        modelBuilder
            .Configurations
            .Add(new IdentityUserLoginConfiguration())
            .Add(new IdentityUserRoleConfiguration());
    }
}

public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
{
    public IdentityUserLoginConfiguration()
    {
        HasKey(iul => iul.UserId);
    }
}

public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
{
    public IdentityUserRoleConfiguration()
    {
        HasKey(iur => iur.UserId);
    }
}
}