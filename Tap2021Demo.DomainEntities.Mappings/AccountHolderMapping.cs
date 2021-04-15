using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tap2021Demo.DomainEntities.Mappings
{
    internal class AccountHolderMapping : IEntityTypeConfiguration<AccountHolder>
    {
        public void Configure(EntityTypeBuilder<AccountHolder> builder)
        {
            builder.ToTable("AccountHolders")
                .HasKey(_ => _.Id);
        }
    }
}
