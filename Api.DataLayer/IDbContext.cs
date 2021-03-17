using Microsoft.EntityFrameworkCore;
using Api.Model;

namespace Api.DataLayer
{
    public interface IDbContext
    {
        DbSet<UserModel> Users { get; set; }
    }
}
