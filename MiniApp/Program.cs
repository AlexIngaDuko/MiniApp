using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MiniApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MiniApp API",
        Version = "v1"
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.Database.Migrate();

    db.Database.ExecuteSqlRaw(@"
    IF OBJECT_ID('Contrarreferencias', 'U') IS NULL
    CREATE TABLE Contrarreferencias (
        Id int IDENTITY(1,1) PRIMARY KEY,

        Fecha nvarchar(max) NULL,
        Hora nvarchar(max) NULL,
        NumeroContrarreferencia nvarchar(max) NULL,

        Asegurado nvarchar(max) NULL,

        EstablecimientoOrigen nvarchar(max) NULL,
        EstablecimientoDestino nvarchar(max) NULL,

        CodigoSis nvarchar(max) NULL,
        HistoriaClinica nvarchar(max) NULL,
        DniPaciente nvarchar(max) NULL,

        ApellidoPaterno nvarchar(max) NULL,
        ApellidoMaterno nvarchar(max) NULL,
        Nombres nvarchar(max) NULL,

        Sexo nvarchar(max) NULL,
        FechaNacimiento nvarchar(max) NULL,
        Edad nvarchar(max) NULL,
        Direccion nvarchar(max) NULL,

        FechaIngreso nvarchar(max) NULL,
        FechaEgreso nvarchar(max) NULL,

        DiagnosticoIngreso nvarchar(max) NULL,
        DiagnosticoEgreso nvarchar(max) NULL,
        TratamientoProcedimientos nvarchar(max) NULL,
        ReportesProcedimientos nvarchar(max) NULL,

        OrigenReferencia nvarchar(max) NULL,
        CalificacionReferencia nvarchar(max) NULL,
        UpsContrarreferencia nvarchar(max) NULL,
        Especialidad nvarchar(max) NULL,

        Recomendaciones nvarchar(max) NULL,

        CondicionUsuario nvarchar(max) NULL,
        NombreResponsable nvarchar(max) NULL,
        NumeroColegiatura nvarchar(max) NULL,

        FechaRegistro datetime2 NOT NULL DEFAULT GETDATE()
    );
");

    db.Database.ExecuteSqlRaw(@"
        IF COL_LENGTH('Epicrisis', 'NombresFinales') IS NULL
            ALTER TABLE Epicrisis ADD NombresFinales nvarchar(max) NULL;

        IF COL_LENGTH('Epicrisis', 'ApellidosFinales') IS NULL
            ALTER TABLE Epicrisis ADD ApellidosFinales nvarchar(max) NULL;

        IF COL_LENGTH('Epicrisis', 'HcFinal') IS NULL
            ALTER TABLE Epicrisis ADD HcFinal nvarchar(max) NULL;

        IF COL_LENGTH('Epicrisis', 'CamaFinal') IS NULL
            ALTER TABLE Epicrisis ADD CamaFinal nvarchar(max) NULL;
    ");

    db.Database.ExecuteSqlRaw(@"
        IF OBJECT_ID('ProcedimientosTerapeuticosEpicrisis', 'U') IS NULL
        CREATE TABLE ProcedimientosTerapeuticosEpicrisis (
            Id int IDENTITY(1,1) PRIMARY KEY,
            Procedimiento nvarchar(max) NULL,
            Codigo nvarchar(max) NULL,
            EpicrisisId int NOT NULL,
            CONSTRAINT FK_ProcedimientosTerapeuticosEpicrisis_Epicrisis
            FOREIGN KEY (EpicrisisId) REFERENCES Epicrisis(Id) ON DELETE CASCADE
        );
    ");

    db.Database.ExecuteSqlRaw(@"
        IF OBJECT_ID('InformesAlta', 'U') IS NULL
        CREATE TABLE InformesAlta (
            Id int IDENTITY(1,1) PRIMARY KEY,

            Servicio nvarchar(max) NULL,
            NumeroCama nvarchar(max) NULL,
            NumeroHistoriaClinica nvarchar(max) NULL,
            NumeroSIS nvarchar(max) NULL,
            Sala nvarchar(max) NULL,

            NombresApellidos nvarchar(max) NULL,
            Edad nvarchar(max) NULL,
            FechaNacimiento datetime2 NULL,
            Sexo nvarchar(max) NULL,
            Domicilio nvarchar(max) NULL,

            IngresoEmergencia bit NOT NULL DEFAULT 0,
            IngresoConsultaExterna bit NOT NULL DEFAULT 0,

            FechaIngresoEmergenciaTexto nvarchar(max) NULL,
            FechaIngresoServicioTexto nvarchar(max) NULL,
            FechaAltaServicioTexto nvarchar(max) NULL,

            DiagnosticoIngreso1 nvarchar(max) NULL,
            CieIngreso1 nvarchar(max) NULL,
            DiagnosticoIngreso2 nvarchar(max) NULL,
            CieIngreso2 nvarchar(max) NULL,
            DiagnosticoIngreso3 nvarchar(max) NULL,
            CieIngreso3 nvarchar(max) NULL,
            DiagnosticoIngreso4 nvarchar(max) NULL,
            CieIngreso4 nvarchar(max) NULL,

            DiagnosticoAlta1 nvarchar(max) NULL,
            CieAlta1 nvarchar(max) NULL,
            DiagnosticoAlta2 nvarchar(max) NULL,
            CieAlta2 nvarchar(max) NULL,
            DiagnosticoAlta3 nvarchar(max) NULL,
            CieAlta3 nvarchar(max) NULL,
            DiagnosticoAlta4 nvarchar(max) NULL,
            CieAlta4 nvarchar(max) NULL,

            ProcedimientosCirugia nvarchar(max) NULL,
            CodigoCpt nvarchar(max) NULL,

            ExamenesImagen nvarchar(max) NULL,
            ExamenesLaboratorio nvarchar(max) NULL,

            Farmaco1 nvarchar(max) NULL,
            DiasFarmaco1 nvarchar(max) NULL,
            Farmaco2 nvarchar(max) NULL,
            DiasFarmaco2 nvarchar(max) NULL,
            Farmaco3 nvarchar(max) NULL,
            DiasFarmaco3 nvarchar(max) NULL,

            RecomendacionesAlta nvarchar(max) NULL,
            OtrasIndicaciones nvarchar(max) NULL,
            Dieta nvarchar(max) NULL,
            CuidadosHigienicos nvarchar(max) NULL,
            Vacunas nvarchar(max) NULL,
            CuidadosTraslado nvarchar(max) NULL,

            MotivoAltaMedica bit NOT NULL DEFAULT 0,
            MotivoRetiroVoluntario bit NOT NULL DEFAULT 0,
            MotivoReferencia bit NOT NULL DEFAULT 0,
            MotivoContrarreferencia bit NOT NULL DEFAULT 0,
            MotivoFuga bit NOT NULL DEFAULT 0,
            MotivoFallecido bit NOT NULL DEFAULT 0,

            CondicionCurado bit NOT NULL DEFAULT 0,
            CondicionMejorado bit NOT NULL DEFAULT 0,
            CondicionEstacionario bit NOT NULL DEFAULT 0,
            CondicionEmpeorado bit NOT NULL DEFAULT 0,
            CondicionFallecido bit NOT NULL DEFAULT 0,

            PronosticoBueno bit NOT NULL DEFAULT 0,
            PronosticoReservado bit NOT NULL DEFAULT 0,

            CitaConsultorio1 nvarchar(max) NULL,
            FechaCita1 nvarchar(max) NULL,
            CitaConsultorio2 nvarchar(max) NULL,
            FechaCita2 nvarchar(max) NULL,
            CitaConsultorio3 nvarchar(max) NULL,
            FechaCita3 nvarchar(max) NULL,

            FirmaPadreApoderado nvarchar(max) NULL,
            DniApoderado nvarchar(max) NULL,
            Parentesco nvarchar(max) NULL,

            JefeServicio nvarchar(max) NULL,
            MedicoTratante nvarchar(max) NULL
        );
    ");

    db.Database.ExecuteSqlRaw(@"
        IF COL_LENGTH('InformesAlta', 'HuellaDigitalIletrado') IS NULL
        ALTER TABLE InformesAlta ADD HuellaDigitalIletrado nvarchar(max) NULL;
    ");
}
    

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiniApp API v1");
    });
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();