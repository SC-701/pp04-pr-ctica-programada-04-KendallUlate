-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE AgregarVehiculo
    @Id UNIQUEIDENTIFIER,
    @IdModelo UNIQUEIDENTIFIER,
    @Placa VARCHAR(MAX),
    @Color VARCHAR(MAX),
    @Anio INT,
    @Precio DECIMAL(18,2),
    @CorreoPropietario VARCHAR(MAX),
    @TelefonoPropietario VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    --Insert statements for produce here :)
    BEGIN TRANSACTION
    INSERT INTO Vehiculo (
        Id,
        IdModelo,
        Placa,
        Color,
        Anio,
        Precio,
        CorreoPropietario,
        TelefonoPropietario
    )
    VALUES (
        @Id,
        @IdModelo,
        @Placa,
        @Color,
        @Anio,
        @Precio,
        @CorreoPropietario,
        @TelefonoPropietario
    );
    SELECT @Id
    COMMIT TRANSACTION   
END