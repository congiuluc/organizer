﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using EngagementOrganizer.API.Infrastructure;

namespace EngagementOrganizer.API.Migrations
{
    [DbContext(typeof(EngagementOrganizerContext))]
    [Migration("20190604124120_AddedTravelInformations")]
    partial class AddedTravelInformations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("EngagementOrganizer.API.Models.Appointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Confirmed");

                    b.Property<int?>("CustomerID");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Note");

                    b.Property<bool>("RequireTravel");

                    b.Property<DateTime>("StartDate");

                    b.Property<bool>("TravelBooked");

                    b.Property<int?>("TypeID");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TypeID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("EngagementOrganizer.API.Models.AppointmentType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Billable");

                    b.Property<string>("Description");

                    b.Property<bool>("RequireCustomer");

                    b.HasKey("ID");

                    b.ToTable("AppointmentType");
                });

            modelBuilder.Entity("EngagementOrganizer.API.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Color");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<string>("Referral");

                    b.Property<string>("ShortDescription");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EngagementOrganizer.API.Models.Appointment", b =>
                {
                    b.HasOne("EngagementOrganizer.API.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("EngagementOrganizer.API.Models.AppointmentType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");
                });
#pragma warning restore 612, 618
        }
    }
}
