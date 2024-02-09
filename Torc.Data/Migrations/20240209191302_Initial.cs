using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torc.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCopies = table.Column<int>(type: "int", nullable: false),
                    CopiesInUse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
            
            migrationBuilder.Sql(@"INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'Pride and Prejudice', 'Jane', 'Austen', 100, 80, 'Hardcover', '1234567891', 'Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'To Kill a Mockingbird', 'Harper', 'Lee', 75, 65, 'Paperback', '1234567892', 'Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Catcher in the Rye', 'J.D.', 'Salinger', 50, 45, 'Hardcover', '1234567893', 'Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Great Gatsby', 'F. Scott', 'Fitzgerald', 50, 22, 'Hardcover', '1234567894', 'Non-Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Alchemist', 'Paulo', 'Coelho', 50, 35, 'Hardcover', '1234567895', 'Biography');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Book Thief', 'Markus', 'Zusak', 75, 11, 'Hardcover', '1234567896', 'Mystery');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Chronicles of Narnia', 'C.S.', 'Lewis', 100, 14, 'Paperback', '1234567897', 'Sci-Fi');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Da Vinci Code', 'Dan', 'Brown', 50, 40, 'Paperback', '1234567898', 'Sci-Fi');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Grapes of Wrath', 'John', 'Steinbeck', 50, 35, 'Hardcover', '1234567899', 'Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Hitchhiker''s Guide to the Galaxy', 'Douglas', 'Adams', 50, 35, 'Paperback',
        '1234567900', 'Non-Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'Moby-Dick', 'Herman', 'Melville', 30, 8, 'Hardcover', '8901234567', 'Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'To Kill a Mockingbird', 'Harper', 'Lee', 20, 0, 'Paperback', '9012345678', 'Non-Fiction');
INSERT INTO books (Publisher, Title, FirstName, LastName, TotalCopies, CopiesInUse, Type, isbn, category)
VALUES ('SOME PUBLISHER', 'The Catcher in the Rye', 'J.D.', 'Salinger', 10, 1, 'Hardcover', '0123456789', 'Non-Fiction')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
