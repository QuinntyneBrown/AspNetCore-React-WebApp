﻿// <auto-generated />
using System;
using Microsoft.DSX.ProjectTemplate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microsoft.DSX.ProjectTemplate.Data.Migrations
{
    [DbContext(typeof(ProjectTemplateDbContext))]
    partial class ProjectTemplateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DefaultLibraryId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(Constants.MaximumLengths.StringColumn);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("DefaultLibraryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Surface",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "HoloLens",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Xbox",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(Constants.MaximumLengths.StringColumn);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(Constants.MaximumLengths.StringColumn);

                    b.Property<int?>("OwnerId");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("GroupId");

                    b.Property<string>("Name")
                        .HasMaxLength(Constants.MaximumLengths.StringColumn);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(Constants.MaximumLengths.StringColumn);

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Group", b =>
                {
                    b.HasOne("Microsoft.DSX.ProjectTemplate.Data.Models.Library", "DefaultLibrary")
                        .WithMany()
                        .HasForeignKey("DefaultLibraryId");
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Library", b =>
                {
                    b.OwnsOne("Microsoft.DSX.ProjectTemplate.Data.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("LibraryId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("LocationAddressLine1")
                                .HasMaxLength(Constants.MaximumLengths.StringColumn);

                            b1.Property<string>("LocationAddressLine2")
                                .HasMaxLength(Constants.MaximumLengths.StringColumn);

                            b1.Property<string>("LocationCity")
                                .HasMaxLength(Constants.MaximumLengths.StringColumn);

                            b1.Property<string>("LocationCountry")
                                .HasMaxLength(Constants.MaximumLengths.StringColumn);

                            b1.Property<string>("LocationStateProvince")
                                .HasMaxLength(Constants.MaximumLengths.StringColumn);

                            b1.Property<string>("LocationZipCode")
                                .HasMaxLength(Constants.MaximumLengths.StringColumn);

                            b1.HasKey("LibraryId");

                            b1.ToTable("Libraries");

                            b1.HasOne("Microsoft.DSX.ProjectTemplate.Data.Models.Library")
                                .WithOne("Address")
                                .HasForeignKey("Microsoft.DSX.ProjectTemplate.Data.Models.Address", "LibraryId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Project", b =>
                {
                    b.HasOne("Microsoft.DSX.ProjectTemplate.Data.Models.Group", "Group")
                        .WithMany("Projects")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.DSX.ProjectTemplate.Data.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Microsoft.DSX.ProjectTemplate.Data.Models.Team", b =>
                {
                    b.HasOne("Microsoft.DSX.ProjectTemplate.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}