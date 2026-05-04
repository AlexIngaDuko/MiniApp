using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniApp.Migrations
{
    /// <inheritdoc />
    public partial class AddEpicrisisWithExamenesAuxiliares : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epicrisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaClinicaNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroSIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Procedencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngresoINSN = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaIngresoServicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaIngresoOtrosServicios = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadiaTotalDias = table.Column<int>(type: "int", nullable: true),
                    Antecedentes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnfermedadActualResumen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamenFisico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvolucionTratamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemperaturaIngreso = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PresionArterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pulso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: true),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: true),
                    DiagnosticoIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cie10Ingreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosticoNutricional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterconsultaFecha1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InterconsultaEspecialidad1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterconsultaConclusion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterconsultaFecha2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InterconsultaEspecialidad2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterconsultaConclusion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterconsultaFecha3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InterconsultaEspecialidad3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterconsultaConclusion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicamento1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosisMgKg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Via1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiempoAdministracion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicamento2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosisMgKg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Via2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiempoAdministracion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicamento3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosisMgKg3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Via3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiempoAdministracion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcedimientoTerapeutico1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoProcedimiento1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcedimientoTerapeutico2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoProcedimiento2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcedimientoTerapeutico3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoProcedimiento3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosticoAlta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cie10Alta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nutricional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InmunizacionCompleta = table.Column<bool>(type: "bit", nullable: false),
                    InmunizacionIncompleta = table.Column<bool>(type: "bit", nullable: false),
                    CondicionCurado = table.Column<bool>(type: "bit", nullable: false),
                    CondicionMejorado = table.Column<bool>(type: "bit", nullable: false),
                    CondicionEmpeorado = table.Column<bool>(type: "bit", nullable: false),
                    CondicionEstacionario = table.Column<bool>(type: "bit", nullable: false),
                    CondicionFallecido = table.Column<bool>(type: "bit", nullable: false),
                    TipoAltaMedica = table.Column<bool>(type: "bit", nullable: false),
                    TipoAltaVoluntaria = table.Column<bool>(type: "bit", nullable: false),
                    TipoAltaTransferencia = table.Column<bool>(type: "bit", nullable: false),
                    TipoAltaFallecido = table.Column<bool>(type: "bit", nullable: false),
                    NecropsiaSi = table.Column<bool>(type: "bit", nullable: false),
                    NecropsiaNo = table.Column<bool>(type: "bit", nullable: false),
                    Pronostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pendiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicacionesAlta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreFirmaInterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreFirmaMedicoResidente1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreFirmaMedicoTratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreFirmaMedicoResidente2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epicrisis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamenesAuxiliares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpicrisisId = table.Column<int>(type: "int", nullable: false),
                    NombreExamen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenesAuxiliares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamenesAuxiliares_Epicrisis_EpicrisisId",
                        column: x => x.EpicrisisId,
                        principalTable: "Epicrisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamenesAuxiliares_EpicrisisId",
                table: "ExamenesAuxiliares",
                column: "EpicrisisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamenesAuxiliares");

            migrationBuilder.DropTable(
                name: "Epicrisis");
        }
    }
}
