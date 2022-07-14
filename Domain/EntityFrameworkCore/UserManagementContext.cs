using Microsoft.EntityFrameworkCore;
using Domain.Models;
namespace Domain.EntityFrameworkCore
{
    public class UserManagementContext:DbContext
    {
        public UserManagementContext(DbContextOptions objContext):base(objContext)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMapper(modelBuilder.Entity<User>());
            new UserProfileMapper(modelBuilder.Entity<UserProfile>());
        }
        
    }
}