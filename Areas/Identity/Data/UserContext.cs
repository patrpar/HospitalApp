﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    public class UserContext : IdentityDbContext<IdentityUser>
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            /*this.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole()
            {
                Name = "PATIENT"
            });
            this.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole()
            {
                Name = "DOCTOR"
            });
            this.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole()
            {
                Name = "ADMIN"
            });
            this.SaveChanges();
            */


        }
    }
}
