﻿// <auto-generated />
using ETicaret.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ETicaret.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190524161625_iller")]
    partial class iller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ETicaret.Models.Iller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ilismi");

                    b.HasKey("ID");

                    b.ToTable("Illers");
                });

            modelBuilder.Entity("ETicaret.Models.Magaza", b =>
                {
                    b.Property<int>("MagazaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FavoriFoto");

                    b.Property<int>("FavoriID");

                    b.Property<string>("FotoGenel");

                    b.Property<string>("FotoGenel2");

                    b.Property<int>("IlID");

                    b.Property<int>("IlceID");

                    b.Property<int>("Kapasite");

                    b.Property<string>("MagazaAdi");

                    b.Property<string>("MagazaMail");

                    b.Property<string>("MagazaTanitim");

                    b.Property<string>("MagazaTel");

                    b.Property<int>("MagazaTur");

                    b.HasKey("MagazaId");

                    b.ToTable("Magazas");
                });

            modelBuilder.Entity("ETicaret.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<int>("Stok");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
