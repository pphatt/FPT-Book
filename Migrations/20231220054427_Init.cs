using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPTBook.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Author__70DAFC1447AB37A9", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Category__19093A2B992D5C08", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Publishe__4C657E4B96BF25A1", x => x.PublisherID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UserFullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserPassword = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserImage = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UserAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserPhone = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    UserBirthday = table.Column<DateOnly>(type: "date", nullable: true),
                    UserSex = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UserSection = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCAC58826B6C", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BookPrice = table.Column<int>(type: "int", nullable: false, defaultValue: 10),
                    BookNumber = table.Column<int>(type: "int", nullable: false),
                    BookDetails = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PublisherID = table.Column<int>(type: "int", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Books__3DE0C227BEC38ADA", x => x.BookID);
                    table.ForeignKey(
                        name: "fk_Book_Author",
                        column: x => x.AuthorID,
                        principalTable: "Author",
                        principalColumn: "AuthorID");
                    table.ForeignKey(
                        name: "fk_Book_Publisher",
                        column: x => x.PublisherID,
                        principalTable: "Publisher",
                        principalColumn: "PublisherID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__C3905BAF452D5DC4", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK__Orders__UserID__3E52440B",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cart__51BCD797ACF314C8", x => x.CartID);
                    table.ForeignKey(
                        name: "fk_Cart_Book",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID");
                    table.ForeignKey(
                        name: "fk_Cart_User",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Category_Book",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Category__7AD73609D8112139", x => new { x.CategoryID, x.BookID });
                    table.ForeignKey(
                        name: "fk_Book_Category",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID");
                    table.ForeignKey(
                        name: "fk_Category_Book",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "ImageBooks",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookImage = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ImageBoo__7516F4EC1DB0430A", x => x.ImageID);
                    table.ForeignKey(
                        name: "fk_Book_Image",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderDet__D3B9D30C72E11231", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK__OrderDeta__BookI__4222D4EF",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID");
                    table.ForeignKey(
                        name: "FK__OrderDeta__Order__412EB0B6",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_BookID",
                table: "Cart",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserID",
                table: "Cart",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Book_BookID",
                table: "Category_Book",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_ImageBooks_BookID",
                table: "ImageBooks",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookID",
                table: "OrderDetails",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__08638DF8B890279A",
                table: "Users",
                column: "UserEmail",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Category_Book");

            migrationBuilder.DropTable(
                name: "ImageBooks");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
