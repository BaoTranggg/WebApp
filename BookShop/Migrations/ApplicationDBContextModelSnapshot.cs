﻿// <auto-generated />
using BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Anne",
                            CategoryId = 1,
                            Description = "Hello",
                            Price = 10.0,
                            Title = "C# Programming"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jane",
                            CategoryId = 3,
                            Description = "Hello",
                            Price = 15.0,
                            Title = "Java Programming"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Billy",
                            CategoryId = 2,
                            Description = "Hello",
                            Price = 20.0,
                            Title = "Python Programming"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jessica",
                            CategoryId = 4,
                            Description = "Hello",
                            Price = 15.0,
                            Title = "C Programming"
                        });
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "So scary",
                            DisplayOrder = 2,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Description = "So cool",
                            DisplayOrder = 3,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Description = "So romance",
                            DisplayOrder = 1,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            Description = "So difficult",
                            DisplayOrder = 4,
                            Name = "Science"
                        });
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.HasOne("BookShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
