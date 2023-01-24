Imports System.Data
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.Migrations

Namespace Migrations
    Partial Public Class Initial
        Inherits Migration

        Protected Overrides Sub Up(migrationBuilder As MigrationBuilder)
            migrationBuilder.CreateTable(
            name:="Book",
            columns:=
            Function(table)
                Return New With {
                    .Id = table.Column(Of Integer)(type:="int", nullable:=False) _
                        .Annotation("SqlServer:Identity", "1, 1"),
                    .Title = table.Column(Of String)(type:="nvarchar(max)", nullable:=False),
                    .Author = table.Column(Of String)(type:="nvarchar(max)", nullable:=False),
                    .Price = table.Column(Of Integer)(type:="int", nullable:=False)
                }
            End Function,
            constraints:=
            Function(table)
                Return table.PrimaryKey("PK_Book", Function(x) x.Id)
            End Function
        )
        End Sub

        Protected Overrides Sub Down(migrationBuilder As MigrationBuilder)
            migrationBuilder.DropTable(name:="Book")
        End Sub
    End Class



    <DbContext(GetType(DatabaseContext))>
    <Migration("202211032142_Initial")>
    Public Class Initial

        Protected Overrides Sub BuildTargetModel(modelBuilder As ModelBuilder)
            modelBuilder _
            .HasAnnotation("Relational:MaxIdentifierLength", 128) _
            .HasAnnotation("ProductVersion", "5.0.10") _
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)

            modelBuilder.Entity("db332.Book",
            Sub(b)
                b.Property(Of Integer)("Id") _
                    .ValueGeneratedOnAdd() _
                    .HasColumnType("int") _
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                b.Property(Of String)("Author") _
                    .IsRequired() _
                    .HasColumnType("nvarchar(max)")
                b.Property(Of Integer)("Price") _
                    .HasColumnType("int")
                b.Property(Of String)("Title") _
                    .IsRequired() _
                    .HasColumnType("nvarchar(max)")
                b.HasKey("Id")
                b.ToTable("Book")
            End Sub)
        End Sub
    End Class




End Namespace

