﻿// <auto-generated />
using System;
using Dotawin.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Dotawin.Server.Migrations
{
    [DbContext(typeof(DotaContext))]
    partial class DotaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "item_type", new[] { "boots", "core", "neutral", "situational" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Dotawin.Server.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCarry")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Popularity")
                        .HasColumnType("integer");

                    b.Property<int>("UpdateId")
                        .HasColumnType("integer");

                    b.Property<double>("Winrate")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("UpdateId");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("Dotawin.Server.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("AddWinrate")
                        .HasColumnType("double precision");

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<int>("HeroId")
                        .HasColumnType("integer");

                    b.Property<int>("Matches")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<double>("Winrate")
                        .HasColumnType("double precision");

                    b.Property<int>("WinratePer1000Gold")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Dotawin.Server.Models.Update", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("Dotawin.Server.Models.Hero", b =>
                {
                    b.HasOne("Dotawin.Server.Models.Update", "Update")
                        .WithMany("Heroes")
                        .HasForeignKey("UpdateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Update");
                });

            modelBuilder.Entity("Dotawin.Server.Models.Item", b =>
                {
                    b.HasOne("Dotawin.Server.Models.Hero", "Hero")
                        .WithMany("Items")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");
                });

            modelBuilder.Entity("Dotawin.Server.Models.Hero", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Dotawin.Server.Models.Update", b =>
                {
                    b.Navigation("Heroes");
                });
#pragma warning restore 612, 618
        }
    }
}
