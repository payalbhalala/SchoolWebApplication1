﻿using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Organization", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrganizationId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("OrgName")
                    .IsRequired()
                    .HasColumnType("nvarchar(60)")
                    .HasMaxLength(60);

                b.HasKey("Id");

                b.ToTable("Organizations");

                b.HasData(
                    new
                    {
                        Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        OrgName = "xyz org"
                    },
                    new
                    {
                        Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                        OrgName = "lmnop org"
                    });
            });

            modelBuilder.Entity("Entities.Models.User", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UserId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("OrganizationId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("nvarchar(30)")
                    .HasMaxLength(30);

                b.HasKey("Id");

                b.HasIndex("OrganizationId");

                b.ToTable("Users");

                b.HasData(
                    new
                    {
                        Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                        OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        UserName = "kwilliams"
                    },
                    new
                    {
                        Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                        OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        UserName = "ka393939"
                    },
                    new
                    {
                        Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                        OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                        UserName = "kaw3939"
                    });
            });

            modelBuilder.Entity("Entities.Models.User", b =>
            {
                b.HasOne("Entities.Models.Organization", "Organization")
                    .WithMany("Users")
                    .HasForeignKey("OrganizationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}