// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c329cae-bc38-4c09-827b-4ca5f647873b"),
                            CategoryId = new Guid("82e5f947-a236-4daa-b802-9eafea013177"),
                            Content = "Test içerik",
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(4611),
                            DeletedBy = "",
                            ImageId = new Guid("08c81641-4dac-4c9c-b243-a81968017166"),
                            IsDeleted = false,
                            Title = "Asp Net deneme makalesi",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("6dfd102f-348a-4d0a-84ba-72f00ba3f8ae"),
                            CategoryId = new Guid("82e5f947-a236-4daa-b802-9eafea013177"),
                            Content = "Test içerik visual studio",
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(4616),
                            DeletedBy = "",
                            ImageId = new Guid("08c81641-4dac-4c9c-b243-a81968017166"),
                            IsDeleted = false,
                            Title = "Visual Studio deneme makalesi",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("80a1afb9-98a0-46a5-ac8c-bafac1be8ca6"),
                            CategoryId = new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"),
                            Content = "Test içerik c#",
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(4621),
                            DeletedBy = "",
                            ImageId = new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"),
                            IsDeleted = false,
                            Title = "c# makalesi",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("82e5f947-a236-4daa-b802-9eafea013177"),
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(5190),
                            DeletedBy = "",
                            IsDeleted = false,
                            Name = "Visual Studio"
                        },
                        new
                        {
                            Id = new Guid("1acac552-c55f-4b07-89a6-a9d799f12f5f"),
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(5197),
                            DeletedBy = "",
                            IsDeleted = false,
                            Name = "c#"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08c81641-4dac-4c9c-b243-a81968017166"),
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(6112),
                            DeletedBy = "",
                            FileName = "images/testvisualimage",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("d7559693-6702-4950-a2bf-152fcdb8700d"),
                            CreateBy = "Admin Test",
                            CreatedDate = new DateTime(2022, 11, 22, 13, 18, 42, 729, DateTimeKind.Local).AddTicks(6116),
                            DeletedBy = "",
                            FileName = "images/testimage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
