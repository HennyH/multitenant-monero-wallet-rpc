﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneroPay.Database;

namespace database.Migrations
{
    [DbContext(typeof(MoneroPayContext))]
    [Migration("20210510112649_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("MoneroPay.Database.Entities.WalletRpcDaemon", b =>
                {
                    b.Property<string>("WalletName")
                        .HasColumnType("TEXT")
                        .HasColumnName("walletname");

                    b.Property<string>("Hostname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("hostname");

                    b.Property<int?>("Port")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("port");

                    b.Property<DateTime?>("SpwanedDate")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("spwaneddate");

                    b.HasKey("WalletName")
                        .HasName("pk_walletrpcdaemons");

                    b.ToTable("walletrpcdaemons");
                });
#pragma warning restore 612, 618
        }
    }
}
