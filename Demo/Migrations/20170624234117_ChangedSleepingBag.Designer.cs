using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Demo;

namespace Demo.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20170624234117_ChangedSleepingBag")]
    partial class ChangedSleepingBag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Models.BackPack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName");

                    b.Property<decimal>("CargoSize");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("BackPacks");
                });

            modelBuilder.Entity("Demo.Models.SleepingBag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName");

                    b.Property<int>("MaximumTem");

                    b.Property<int>("MinimumTemp");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("SalePrice");

                    b.HasKey("Id");

                    b.ToTable("SleepingBags");
                });

            modelBuilder.Entity("Demo.Models.Tent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName");

                    b.Property<int>("PeopleItHolds");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Tents");
                });
        }
    }
}
