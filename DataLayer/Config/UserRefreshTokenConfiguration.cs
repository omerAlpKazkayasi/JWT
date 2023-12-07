using CoreLayer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Config
{
	internal class UserRefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshToken>
	{
		public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
		{
			builder.HasKey(x => x.UserId);
			builder.Property(x => x.Code).IsRequired().HasMaxLength(200);
		}
	}
}
