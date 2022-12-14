// <auto-generated />
using System;
using EfcDbInit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IDKyet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221029095028_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfcDbInit.Models.Champions", b =>
                {
                    b.Property<int>("ChampionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChampionsId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int?>("SummsId")
                        .HasColumnType("int");

                    b.HasKey("ChampionsId");

                    b.HasIndex("RoleID");

                    b.HasIndex("SummsId");

                    b.ToTable("Champions");

                    b.HasData(
                        new
                        {
                            ChampionsId = 1,
                            Name = "Aatrox",
                            RoleID = 1
                        });
                });

            modelBuilder.Entity("EfcDbInit.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            RoleName = "Top"
                        });
                });

            modelBuilder.Entity("EfcDbInit.Models.Summs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Server")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Summs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "KarelFrederick",
                            Password = "Karlík1234",
                            Server = 0
                        });
                });

            modelBuilder.Entity("EfcDbInit.Models.Champions", b =>
                {
                    b.HasOne("EfcDbInit.Models.Role", "Role")
                        .WithMany("Champions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfcDbInit.Models.Summs", null)
                        .WithMany("Champions")
                        .HasForeignKey("SummsId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EfcDbInit.Models.Role", b =>
                {
                    b.Navigation("Champions");
                });

            modelBuilder.Entity("EfcDbInit.Models.Summs", b =>
                {
                    b.Navigation("Champions");
                });
#pragma warning restore 612, 618
        }
    }
}
