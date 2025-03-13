using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PAP.Mvc.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //    base.OnModelCreating(builder);


    //    var adminRoleId = Guid.NewGuid().ToString();
    //    var userRoleId = Guid.NewGuid().ToString();

    //    builder.Entity<IdentityRole>().HasData(
    //        new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
    //        new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" }
    //    );
    //}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Crear roles
        var adminRoleId = Guid.NewGuid().ToString();
        var userRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" }
        );

        // Crear usuario admin sin hashear la contraseña
        var adminUser = new IdentityUser
        {
            Id = Guid.NewGuid().ToString(), // Generar un ID único
            UserName = "admin@domain.com",
            Email = "admin@domain.com",
            NormalizedUserName = "ADMIN@DOMAIN.COM",
            NormalizedEmail = "ADMIN@DOMAIN.COM",
            EmailConfirmed = true
        };

        builder.Entity<IdentityUser>().HasData(adminUser);

        // Asignar el rol Admin al usuario admin
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = adminRoleId, UserId = adminUser.Id }
        );
    }

}
