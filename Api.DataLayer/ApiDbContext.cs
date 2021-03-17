using System;
using Microsoft.EntityFrameworkCore;
using Api.Model;

namespace Api.DataLayer
{
    public class ApiDbContext: DbContext, IDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
