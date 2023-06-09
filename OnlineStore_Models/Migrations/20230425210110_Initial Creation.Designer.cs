﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore_Models;

#nullable disable

namespace OnlineStore_Models.Migrations
{
    [DbContext(typeof(StoreDbConn))]
    [Migration("20230425210110_Initial Creation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineStore_Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId");

                    b.HasIndex("StoreId");

                    b.ToTable("Article");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            Code = "Dell XPS 13 9310",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/1.jpg",
                            Price = 5000m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 2,
                            Code = "Apple MacBook Pro 16 M1 Max",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/2.jpg",
                            Price = 5500m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 3,
                            Code = "HP Spectre x360 14",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/3.jpg",
                            Price = 6000m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 4,
                            Code = "Microsoft Surface Pro 8-13",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/4.jpg",
                            Price = 6500m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 5,
                            Code = "Platform Core™ i7-16GB Memory - 512GB SSD",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/5.jpg",
                            Price = 7000m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 6,
                            Code = "Asus ZenBook 13 OLED.",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/6.jpg",
                            Price = 7500m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 7,
                            Code = "Razer Blade 14.",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/7.jpg",
                            Price = 8000m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 8,
                            Code = "Lenovo ThinkPad X1 Carbon Gen 9",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/8.jpg",
                            Price = 8500m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 9,
                            Code = "Acer Swift 5 Intel EVO Thin",
                            Description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz",
                            Image = "../assets/images/products/9.jpg",
                            Price = 9000m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 10,
                            Code = "Hard Disk Seagate BarraCuda PRO",
                            Description = "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.",
                            Image = "../assets/images/products/10.jpg",
                            Price = 1500m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 11,
                            Code = "Hard Disk Seagate FireCuda",
                            Description = "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.",
                            Image = "../assets/images/products/11.jpeg",
                            Price = 3000m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 12,
                            Code = "Hard Disk WD Blue",
                            Description = "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.",
                            Image = "../assets/images/products/12.jpeg",
                            Price = 3500m,
                            Stock = 50,
                            StoreId = 1
                        },
                        new
                        {
                            ArticleId = 13,
                            Code = "Hard Disk WD Black",
                            Description = "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.",
                            Image = "../assets/images/products/13.jpg",
                            Price = 4000m,
                            Stock = 50,
                            StoreId = 1
                        });
                });

            modelBuilder.Entity("OnlineStore_Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("OnlineStore_Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("StoreId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OnlineStore_Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StoreId");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Address = "Domicilio conocido 1",
                            Branch = "Tienda 1"
                        });
                });

            modelBuilder.Entity("OnlineStore_Models.Article", b =>
                {
                    b.HasOne("OnlineStore_Models.Store", "Store")
                        .WithMany("Articles")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("OnlineStore_Models.Customer", b =>
                {
                    b.HasOne("OnlineStore_Models.Store", "Store")
                        .WithMany("Customer")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("OnlineStore_Models.Store", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
