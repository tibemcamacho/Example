using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnlineStore_Models
{
    public partial class StoreDbConn : DbContext
    {
        public StoreDbConn(DbContextOptions<StoreDbConn> options) : base(options)
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Store>().HasData(
                new Store { StoreId = 1, Branch = "Tienda 1", Address = "Domicilio conocido 1" });

            string description = "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz";

            string descriptionHardDisk = "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.";
            modelBuilder.Entity<Article>().HasData(
                new Article { ArticleId = 1, StoreId = 1, Code = "Dell XPS 13 9310", Description = description, Price = 5000, Image = "../assets/images/products/1.jpg", Stock = 50 },
                new Article { ArticleId = 2, StoreId = 1, Code = "Apple MacBook Pro 16 M1 Max", Description = description, Price = 5500, Image = "../assets/images/products/2.jpg", Stock = 50 },
                new Article { ArticleId = 3, StoreId = 1, Code = "HP Spectre x360 14", Description = description, Price = 6000, Image = "../assets/images/products/3.jpg", Stock = 50 },
                new Article { ArticleId = 4, StoreId = 1, Code = "Microsoft Surface Pro 8-13", Description = description, Price = 6500, Image = "../assets/images/products/4.jpg", Stock = 50 },
                new Article { ArticleId = 5, StoreId = 1, Code = "Platform Core™ i7-16GB Memory - 512GB SSD", Description = description, Price = 7000, Image = "../assets/images/products/5.jpg", Stock = 50 },
                new Article { ArticleId = 6, StoreId = 1, Code = "Asus ZenBook 13 OLED.", Description = description, Price = 7500, Image = "../assets/images/products/6.jpg", Stock = 50 },
                new Article { ArticleId = 7, StoreId = 1, Code = "Razer Blade 14.", Description = description, Price = 8000, Image = "../assets/images/products/7.jpg", Stock = 50 },
                new Article { ArticleId = 8, StoreId = 1, Code = "Lenovo ThinkPad X1 Carbon Gen 9", Description = description, Price = 8500, Image = "../assets/images/products/8.jpg", Stock = 50 },
                new Article { ArticleId = 9, StoreId = 1, Code = "Acer Swift 5 Intel EVO Thin", Description = description, Price = 9000, Image = "../assets/images/products/9.jpg", Stock = 50 },
                new Article { ArticleId = 10, StoreId = 1, Code = "Hard Disk Seagate BarraCuda PRO", Description = descriptionHardDisk, Price = 1500, Image = "../assets/images/products/10.jpg", Stock = 50 },
                new Article { ArticleId = 11, StoreId = 1, Code = "Hard Disk Seagate FireCuda", Description = descriptionHardDisk, Price = 3000, Image = "../assets/images/products/11.jpeg", Stock = 50 },
                new Article { ArticleId = 12, StoreId = 1, Code = "Hard Disk WD Blue", Description = descriptionHardDisk, Price = 3500, Image = "../assets/images/products/12.jpeg", Stock = 50 },
                new Article { ArticleId = 13, StoreId = 1, Code = "Hard Disk WD Black", Description = descriptionHardDisk, Price = 4000, Image = "../assets/images/products/13.jpg", Stock = 50 }
                );

        }
    }
}
