﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorpeAdatok.Data;

#nullable disable

namespace TorpeAdatok.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TorpeAdatok.Models.KiHolDolgozott", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KitermeltMennyiseg")
                        .HasColumnType("int");

                    b.Property<int>("TarnakId")
                        .HasColumnType("int");

                    b.Property<int>("TorpekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KiHolDolgozott");
                });
#pragma warning restore 612, 618
        }
    }
}