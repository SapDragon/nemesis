﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Infrastructure.Data;

#nullable disable

namespace Server.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240423031321_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Server.Domain.Entities.HardwareInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BasicHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HardDiskSerials")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MotherboardSerialNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SystemUUID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("HardwareInfos");
                });

            modelBuilder.Entity("Server.Domain.Entities.SteamAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("SteamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SteamAccounts");
                });

            modelBuilder.Entity("Server.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BanReason")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasDefaultValue("");

                    b.Property<bool>("IsBanned")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Server.Domain.Entities.HardwareInfo", b =>
                {
                    b.HasOne("Server.Domain.Entities.User", "User")
                        .WithOne("hardwareInfo")
                        .HasForeignKey("Server.Domain.Entities.HardwareInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Domain.Entities.SteamAccount", b =>
                {
                    b.HasOne("Server.Domain.Entities.User", "User")
                        .WithMany("SteamAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Domain.Entities.User", b =>
                {
                    b.Navigation("SteamAccounts");

                    b.Navigation("hardwareInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
