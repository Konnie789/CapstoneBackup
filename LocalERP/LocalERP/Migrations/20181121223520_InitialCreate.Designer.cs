﻿// <auto-generated />
using System;
using LocalERP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalERP.Migrations
{
    [DbContext(typeof(WorkorderContext))]
    [Migration("20181121223520_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocalERP.Models.Workorder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorizedBy");

                    b.Property<string>("ClientEmail");

                    b.Property<string>("ClientName");

                    b.Property<string>("ClientPhoneNumber");

                    b.Property<DateTime>("DateCompleted");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DatePickedUp");

                    b.Property<DateTime>("DateRequiredBy");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EstDeliveryDate");

                    b.Property<decimal>("EstLabourCost");

                    b.Property<decimal>("EstMaterialCost");

                    b.Property<decimal>("EstOtherCost");

                    b.Property<decimal>("EstTotalCost");

                    b.Property<bool>("QuoteRequested");

                    b.Property<int?>("StatusID");

                    b.Property<decimal>("TotalCost");

                    b.Property<decimal>("TotalLabourCost");

                    b.Property<decimal>("TotalMaterialCost");

                    b.HasKey("ID");

                    b.HasIndex("StatusID");

                    b.ToTable("Workorders");
                });

            modelBuilder.Entity("LocalERP.Models.WorkorderStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("WorkorderStatus");
                });

            modelBuilder.Entity("LocalERP.Models.Workorder", b =>
                {
                    b.HasOne("LocalERP.Models.WorkorderStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID");
                });
#pragma warning restore 612, 618
        }
    }
}
