using GymManage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManage.Configurations
{
    public class TrainerConfigurations: GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(T => T.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
