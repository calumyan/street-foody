﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using street_foody.Models;

namespace street_foody.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("street_foody.Models.Vendor", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("VendorDbSet");

                    b.HasData(
                        new
                        {
                            ID = "1",
                            Location = "123 Ly Thai To, Ward 12, District 10, HCMC",
                            Name = "Uncle Tu's Bahn Mi",
                            Phone = "84 9024728593"
                        },
                        new
                        {
                            ID = "2",
                            Location = "123 Ly Thai To, Ward 12, District 10, HCMC",
                            Name = "Uncle Tu's Bahn Mi",
                            Phone = "84 9024728593"
                        },
                        new
                        {
                            ID = "3",
                            Location = "123 Ly Thai To, Ward 12, District 10, HCMC",
                            Name = "Uncle Tu's Bahn Mi",
                            Phone = "84 9024728593"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
