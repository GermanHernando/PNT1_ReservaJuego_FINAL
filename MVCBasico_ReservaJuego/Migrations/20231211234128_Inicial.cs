using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCBasico_ReservaJuego.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    IdJuego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreJuego = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EdadJugadores = table.Column<int>(type: "int", nullable: false),
                    CantJugadoresMin = table.Column<int>(type: "int", nullable: false),
                    CantJugadoresMax = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Dificultad = table.Column<int>(type: "int", nullable: false),
                    CantFichas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.IdJuego);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJuego = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false)


                    /*IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJuego = table.Column<int>(type: "int", nullable: false),
                    //JuegoId = table.Column<int>(type: "int", nullable: true),ANTES
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    //ClienteId = table.Column<int>(type: "int", nullable: true) ANTES
                   */
                },
                constraints: table =>
                {
                    /*  table.PrimaryKey("PK_Reservas", x => x.IdReserva);
                      table.ForeignKey(
                          name: "FK_Reservas_Clientes_ClienteId",
                          column: x => x.ClienteIdCliente,
                          principalTable: "Clientes",
                          principalColumn: "ClienteIdCliente");//antes IdCliente
                      table.ForeignKey(
                          name: "FK_Reservas_Juegos_JuegoId",
                          column: x => x.JuegoIdJuego,
                          principalTable: "Juegos",
                          principalColumn: "JuegoIdJuego");//antes IdJuego
                    */

                    table.PrimaryKey("PK_Reservas", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Juegos_IdJuego",
                        column: x => x.IdJuego,
                        principalTable: "Juegos",
                        principalColumn: "IdJuego",
                        onDelete: ReferentialAction.Cascade);


                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdCliente", //Antes ClienteId
                table: "Reservas",
                column: "IdCliente"); 

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdJuego", //Antes JuegoId
                table: "Reservas",
                column: "IdJuego"); 
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Juegos");
        }
    }
}
