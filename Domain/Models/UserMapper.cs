using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Models
{
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.UserName).IsRequired();
            entityBuilder.Property(t => t.Password).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
        }
    }
}