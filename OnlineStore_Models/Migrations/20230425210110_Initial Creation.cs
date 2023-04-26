using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineStore_Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Article_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "StoreId", "Address", "Branch" },
                values: new object[] { 1, "Domicilio conocido 1", "Tienda 1" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "ArticleId", "Code", "Description", "Image", "Price", "Stock", "StoreId" },
                values: new object[,]
                {
                    { 1, "Dell XPS 13 9310", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/1.jpg", 5000m, 50, 1 },
                    { 2, "Apple MacBook Pro 16 M1 Max", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/2.jpg", 5500m, 50, 1 },
                    { 3, "HP Spectre x360 14", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/3.jpg", 6000m, 50, 1 },
                    { 4, "Microsoft Surface Pro 8-13", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/4.jpg", 6500m, 50, 1 },
                    { 5, "Platform Core™ i7-16GB Memory - 512GB SSD", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/5.jpg", 7000m, 50, 1 },
                    { 6, "Asus ZenBook 13 OLED.", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/6.jpg", 7500m, 50, 1 },
                    { 7, "Razer Blade 14.", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/7.jpg", 8000m, 50, 1 },
                    { 8, "Lenovo ThinkPad X1 Carbon Gen 9", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/8.jpg", 8500m, 50, 1 },
                    { 9, "Acer Swift 5 Intel EVO Thin", "Dell XPS 13 9320 Plus 13.4 pulgadas (modelo 2022) Laptop Ultrabook Premium | Certificado Dell reacondicionado, incluye 1 año de garantía Intel Core i5-1240P de 12ª generación (caché de 12 MB, hasta 4.4 GHz, 12 núcleos) | SSD PCIe Gen 4 de 512 GB | RAM LPDDR5 de 16 GB 13.4 pulgadas, 3.5K 3456 x 2160, 60Hz, OLED, táctil, antirreflectante, 400 nit, InfinityEdge | Intel Killer Wi-Fi 6E 1675 (AX211) 2x2 + tarjeta inalámbrica Bluetooth 5.2 Windows 11 Pro | Teclado inglés retroiluminado con lector de huellas dactilares | 3 celdas, 55 Wh, integrado | Adaptador de CA de 60 W tipo C 2 x Thunderbolt 4 (USB tipo C con DisplayPort y suministro de energía) | 720p a 30 fps HD RGB cámara, 400p a 30 fps IR cámara, micrófonos de doble matriz", "../assets/images/products/9.jpg", 9000m, 50, 1 },
                    { 10, "Hard Disk Seagate BarraCuda PRO", "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.", "../assets/images/products/10.jpg", 1500m, 50, 1 },
                    { 11, "Hard Disk Seagate FireCuda", "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.", "../assets/images/products/11.jpeg", 3000m, 50, 1 },
                    { 12, "Hard Disk WD Blue", "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.", "../assets/images/products/12.jpeg", 3500m, 50, 1 },
                    { 13, "Hard Disk WD Black", "Seagate aporta más de 20 años de rendimiento y fiabilidad demostrados a las unidades de disco duro Seagate® BarraCuda. Las unidades de 2,5 pulgadas BarraCuda Pro, disponibles en 7200 r.p.m. y hasta 1 TB de almacenamiento, ofrecen la mayor producción sostenida y están respaldadas por una garantía limitada de cinco años.", "../assets/images/products/13.jpg", 4000m, 50, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_StoreId",
                table: "Article",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StoreId",
                table: "Customer",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
