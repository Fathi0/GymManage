using GymManage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManage.Configurations
{
    public class MemberConfigurations :GymUserConfigurations<Member>,IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(M => M.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
