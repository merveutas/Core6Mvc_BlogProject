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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x => x.DeletedBy).IsRequired(false);
            builder.Property(x => x.ModifiedBy).IsRequired(false);

            builder.HasData(
                 new Image { Id = Guid.Parse("08C81641-4DAC-4C9C-B243-A81968017166"), FileName = "images/testvisualimage", FileType = "png", CreateBy = "Admin Test", CreatedDate = DateTime.Now, IsDeleted = false },
                 new Image { Id = Guid.Parse("D7559693-6702-4950-A2BF-152FCDB8700D"), FileName = "images/testimage", FileType = "png", CreateBy = "Admin Test", CreatedDate = DateTime.Now, IsDeleted = false }
                    );
        }
    }
}
