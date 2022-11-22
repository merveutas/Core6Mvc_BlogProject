using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.DeletedBy).IsRequired(false);
            builder.Property(x => x.ModifiedBy).IsRequired(false);

            builder.HasData(
                 new Category { Id = Guid.Parse("82E5F947-A236-4DAA-B802-9EAFEA013177"), Name = "Visual Studio", CreateBy = "Admin Test", CreatedDate = DateTime.Now, IsDeleted = false },
                 new Category { Id = Guid.Parse("1ACAC552-C55F-4B07-89A6-A9D799F12F5F"), Name = "c#", CreateBy = "Admin Test", CreatedDate = DateTime.Now, IsDeleted = false }
                 );
        }
    }
}
