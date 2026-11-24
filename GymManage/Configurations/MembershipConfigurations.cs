using GymManage.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManage.Configurations
{
    public class MembershipConfigurations : IEntityTypeConfiguration<Membership>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Membership> builder)
        {
            builder.Property(M => M.CreatedAt).HasDefaultValueSql("GetDate()");
        }
    }
}
