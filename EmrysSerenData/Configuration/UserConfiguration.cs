using EmrysSerenShared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmrysSerenData.Configuration
{ 
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
    public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    UserId = 1,
                    UserName = "Emrys Seren",
                    UserEmail = "serenityaithne@gmail.com"
                },
    
                new User
                {
                    UserId = 2,
                    UserName = "Cosmic Ides",
                    UserEmail = "brandi.hornbuckle@gmail.com"
                },
                new User
                {
                    UserId = 3,
                    UserName = "Calliope Woods",
                    UserEmail = "calliopewoods@gmail.com"
                }
            );
        }
    }
}
