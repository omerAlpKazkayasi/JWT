using CoreLayer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Config
{
	public class UserAppConfiguration : IEntityTypeConfiguration<UserApp>
	{
		public void Configure(EntityTypeBuilder<UserApp> builder)
		{
			builder.Property(x => x.City).HasMaxLength(50);
		}
	}
}
