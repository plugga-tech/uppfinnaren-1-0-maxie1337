﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using uppfinnaren_1_0_maxie1337.Models;

#nullable disable

namespace uppfinnaren_1_0_maxie1337.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241220111714_MigrationOne")]
    partial class MigrationOne
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("uppfinnaren_1_0_maxie1337.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Trä",
                            Description = "Ett torn karvat in i ett träd.",
                            ImgUrl = "/Images/CTorn.jpg",
                            Name = "Torn"
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Trä",
                            Description = "Ett bord gjort utav en stubbe.",
                            ImgUrl = "/Images/Ctables.jpg",
                            Name = "Bord"
                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Trä",
                            Description = "En konstig stol.",
                            ImgUrl = "/Images/Cchair.jpg",
                            Name = "Stol"
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Trä",
                            Description = "En lurig tomte nu i juletider.",
                            ImgUrl = "/Images/CTomte.jpg",
                            Name = "Tomte"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
