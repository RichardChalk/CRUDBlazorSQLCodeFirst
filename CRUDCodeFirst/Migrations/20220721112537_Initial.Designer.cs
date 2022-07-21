﻿// <auto-generated />
using CRUDCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDCodeFirst.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220721112537_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRUDCodeFirst.Data.Champion", b =>
                {
                    b.Property<int>("ChampionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChampionId"), 1L, 1);

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("DamageType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartingAttackDamage")
                        .HasColumnType("int");

                    b.HasKey("ChampionId");

                    b.ToTable("Champions");
                });
#pragma warning restore 612, 618
        }
    }
}