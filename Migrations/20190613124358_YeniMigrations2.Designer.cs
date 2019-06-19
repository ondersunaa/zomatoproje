﻿// <auto-generated />
using System;
using ETicaret.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ETicaret.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190613124358_YeniMigrations2")]
    partial class YeniMigrations2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ETicaret.Models.Ilceler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IlID");

                    b.Property<string>("Ilismi");

                    b.HasKey("ID");

                    b.ToTable("Ilcelers");
                });

            modelBuilder.Entity("ETicaret.Models.Iller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ilismi");

                    b.HasKey("ID");

                    b.ToTable("Illers");
                });

            modelBuilder.Entity("ETicaret.Models.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tur");

                    b.HasKey("ID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("ETicaret.Models.Magaza", b =>
                {
                    b.Property<int>("MagazaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcikAlan");

                    b.Property<bool>("Alkol");

                    b.Property<string>("FavoriFoto");

                    b.Property<int>("FavoriID");

                    b.Property<string>("FotoGenel");

                    b.Property<string>("FotoGenel2");

                    b.Property<int>("IlID");

                    b.Property<int>("IlceID");

                    b.Property<int>("Kapasite");

                    b.Property<bool>("Kart");

                    b.Property<bool>("MacYayini");

                    b.Property<string>("MagazaAdi");

                    b.Property<string>("MagazaAdres");

                    b.Property<string>("MagazaMail");

                    b.Property<string>("MagazaTanitim");

                    b.Property<string>("MagazaTel");

                    b.Property<int>("MagazaTur");

                    b.Property<bool>("Otopark");

                    b.Property<bool>("Oyun");

                    b.Property<bool>("Wifi");

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

            modelBuilder.Entity("ETicaret.Models.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .IsRequired();

                    b.Property<int>("MagazaId");

                    b.Property<double>("Puan");

                    b.Property<string>("YorumIcerik")
                        .IsRequired();

                    b.Property<string>("userId");

                    b.HasKey("YorumID");

                    b.HasIndex("userId");

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("ETicaret.Models.Yorumcular", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Isim");

                    b.Property<string>("Sifre");

                    b.Property<string>("Soyisim");

                    b.HasKey("ID");

                    b.ToTable("Yorumculars");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("ETicaret.Models.Yorum", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}
