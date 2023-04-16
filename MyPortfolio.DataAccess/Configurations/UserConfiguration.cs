using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPortfolio.Core.Models;
using System.Runtime.CompilerServices;
using NpgsqlTypes;
using Npgsql.Schema;

namespace MyPortfolio.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public UserConfiguration() { }
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(entity => entity.Id).ValueGeneratedOnAdd();
            builder.Property(entity => entity.Id).UseIdentityColumn();
            builder.Property(entity => entity.Id).UseIdentityAlwaysColumn();

        }
    }
}
