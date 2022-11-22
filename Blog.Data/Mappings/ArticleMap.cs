using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.DeletedBy).IsRequired(false);
            builder.Property(x => x.ModifiedBy).IsRequired(false);


            builder.HasData(
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp Net deneme makalesi",
                    Content = "Test içerik",
                    ViewCount = 15,

                    CategoryId = Guid.Parse("82E5F947-A236-4DAA-B802-9EAFEA013177"),
                    ImageId = Guid.Parse("08C81641-4DAC-4C9C-B243-A81968017166"),
                    CreateBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    DeletedBy = "",
                },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Visual Studio deneme makalesi",
                    Content = "Test içerik visual studio",
                    ViewCount = 15,
                   
                    CategoryId = Guid.Parse("82E5F947-A236-4DAA-B802-9EAFEA013177"),
                    ImageId = Guid.Parse("08C81641-4DAC-4C9C-B243-A81968017166"),
                    CreateBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    DeletedBy = "",
                },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "c# makalesi",
                    Content = "Test içerik c#",
                    ViewCount = 15,

                    CategoryId = Guid.Parse("1ACAC552-C55F-4B07-89A6-A9D799F12F5F"),
                    ImageId = Guid.Parse("D7559693-6702-4950-A2BF-152FCDB8700D"),
                    CreateBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    DeletedBy = "",
                }
            );

            //builder.Property(x=>x.Title).HasMaxLength(150);
            //builder.Property(x => x.Title).IsRequired(false);
        }
    }
}
