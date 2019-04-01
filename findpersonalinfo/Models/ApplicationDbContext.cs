using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace findpersonalinfo.Models
{

    public interface IApplicationDbContext
    {
        IDbSet<FoundInformation> FoundInformation { get; set; }
        int SaveChanges();
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<FoundInformation> FoundInformation { get; set; }
    }

    public class FakeApplicationDbContext : IApplicationDbContext
    {
        public IDbSet<FoundInformation> FoundInformation { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}