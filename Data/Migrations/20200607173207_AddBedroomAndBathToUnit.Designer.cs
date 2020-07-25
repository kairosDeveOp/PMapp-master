﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMApp.Data;

namespace PMApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200607173207_AddBedroomAndBathToUnit")]
    partial class AddBedroomAndBathToUnit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PMApp.Models.Building", b =>
                {
                    b.Property<long>("BuildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Org_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TPID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Unit_Count")
                        .HasColumnType("int");

                    b.Property<string>("Zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuildingId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("PMApp.Models.Checklist", b =>
                {
                    b.Property<int>("checklistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reminder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("checklistId");

                    b.ToTable("Checklist");
                });

            modelBuilder.Entity("PMApp.Models.Contractor", b =>
                {
                    b.Property<int>("CID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Repair_HistoryRHID")
                        .HasColumnType("int");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CID");

                    b.HasIndex("Repair_HistoryRHID");

                    b.ToTable("Contractor");
                });

            modelBuilder.Entity("PMApp.Models.Infractions", b =>
                {
                    b.Property<int>("IID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Day_closed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Day_opened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantTID")
                        .HasColumnType("int");

                    b.HasKey("IID");

                    b.HasIndex("TenantTID");

                    b.ToTable("Infractions");
                });

            modelBuilder.Entity("PMApp.Models.Move_in", b =>
                {
                    b.Property<int>("MIID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Appliances")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carpet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Nonrefundable_deposit")
                        .HasColumnType("real");

                    b.Property<float>("Pet_deposit")
                        .HasColumnType("real");

                    b.Property<float>("Refundable_deposit")
                        .HasColumnType("real");

                    b.Property<int>("TenantTID")
                        .HasColumnType("int");

                    b.Property<int>("UnitUID")
                        .HasColumnType("int");

                    b.Property<string>("Walls")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MIID");

                    b.HasIndex("TenantTID");

                    b.HasIndex("UnitUID");

                    b.ToTable("Move_in");
                });

            modelBuilder.Entity("PMApp.Models.Move_out", b =>
                {
                    b.Property<int>("MOID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Appliances")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carpet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Cleaning_fee")
                        .HasColumnType("real");

                    b.Property<float>("Damage_fee")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TenantTID")
                        .HasColumnType("int");

                    b.Property<int>("UnitUID")
                        .HasColumnType("int");

                    b.Property<string>("Walls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("fees_paid")
                        .HasColumnType("real");

                    b.HasKey("MOID");

                    b.HasIndex("TenantTID");

                    b.HasIndex("UnitUID");

                    b.ToTable("Move_out");
                });

            modelBuilder.Entity("PMApp.Models.Rent", b =>
                {
                    b.Property<int>("RID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount_paid")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date_due")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_paid")
                        .HasColumnType("datetime2");

                    b.Property<float>("Rent_amount")
                        .HasColumnType("real");

                    b.Property<int>("TenantTID")
                        .HasColumnType("int");

                    b.Property<int>("UnitUID")
                        .HasColumnType("int");

                    b.HasKey("RID");

                    b.HasIndex("TenantTID");

                    b.HasIndex("UnitUID");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("PMApp.Models.Repair_History", b =>
                {
                    b.Property<int>("RHID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractorCID")
                        .HasColumnType("int");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Ticket_closed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ticket_opened")
                        .HasColumnType("datetime2");

                    b.Property<int>("UnitUID")
                        .HasColumnType("int");

                    b.Property<string>("Work_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Work_ended")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Work_started")
                        .HasColumnType("datetime2");

                    b.HasKey("RHID");

                    b.HasIndex("ContractorCID");

                    b.HasIndex("UnitUID");

                    b.ToTable("Repair_History");
                });

            modelBuilder.Entity("PMApp.Models.Tax_Parcel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BuildingId")
                        .HasColumnType("bigint");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Tax_Parcels");
                });

            modelBuilder.Entity("PMApp.Models.Tenant", b =>
                {
                    b.Property<int>("TID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BuildingId")
                        .HasColumnType("bigint");

                    b.Property<string>("Current")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lease_end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Lease_start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("TID");

                    b.HasIndex("BuildingId");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("PMApp.Models.Unit", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("Bath")
                        .HasColumnType("real");

                    b.Property<int?>("Bedroom")
                        .HasColumnType("int");

                    b.Property<long>("BuildingId")
                        .HasColumnType("bigint");

                    b.Property<string>("Occupied")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ready_to_rent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rent_Amount")
                        .HasColumnType("real");

                    b.Property<int?>("Square_footage")
                        .HasColumnType("int");

                    b.Property<int>("Unit_Number")
                        .HasColumnType("int");

                    b.HasKey("UID");

                    b.HasIndex("BuildingId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("PMApp.Models.Vehicle", b =>
                {
                    b.Property<int>("VID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("License_plate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantTID")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("stall_number")
                        .HasColumnType("int");

                    b.HasKey("VID");

                    b.HasIndex("TenantTID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Contractor", b =>
                {
                    b.HasOne("PMApp.Models.Repair_History", null)
                        .WithMany("Contractors")
                        .HasForeignKey("Repair_HistoryRHID");
                });

            modelBuilder.Entity("PMApp.Models.Infractions", b =>
                {
                    b.HasOne("PMApp.Models.Tenant", "Tenant")
                        .WithMany("Infractions")
                        .HasForeignKey("TenantTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Move_in", b =>
                {
                    b.HasOne("PMApp.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMApp.Models.Unit", "Unit")
                        .WithMany("Move_Ins")
                        .HasForeignKey("UnitUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Move_out", b =>
                {
                    b.HasOne("PMApp.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMApp.Models.Unit", "Unit")
                        .WithMany("Move_Outs")
                        .HasForeignKey("UnitUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Rent", b =>
                {
                    b.HasOne("PMApp.Models.Tenant", "Tenant")
                        .WithMany("Rents")
                        .HasForeignKey("TenantTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMApp.Models.Unit", "Unit")
                        .WithMany("Rents")
                        .HasForeignKey("UnitUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Repair_History", b =>
                {
                    b.HasOne("PMApp.Models.Contractor", "Contractor")
                        .WithMany()
                        .HasForeignKey("ContractorCID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMApp.Models.Unit", "Unit")
                        .WithMany("Repair_Histories")
                        .HasForeignKey("UnitUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Tax_Parcel", b =>
                {
                    b.HasOne("PMApp.Models.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Tenant", b =>
                {
                    b.HasOne("PMApp.Models.Building", null)
                        .WithMany("Tenants")
                        .HasForeignKey("BuildingId");
                });

            modelBuilder.Entity("PMApp.Models.Unit", b =>
                {
                    b.HasOne("PMApp.Models.Building", "Building")
                        .WithMany("Units")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMApp.Models.Vehicle", b =>
                {
                    b.HasOne("PMApp.Models.Tenant", "Tenant")
                        .WithMany("Vehicles")
                        .HasForeignKey("TenantTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
