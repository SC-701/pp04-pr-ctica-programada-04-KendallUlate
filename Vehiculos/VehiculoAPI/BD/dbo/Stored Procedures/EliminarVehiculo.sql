-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE EliminarVehiculo
@Id uniqueidentifier
AS
BEGIN
    SET NOCOUNT ON;
    
    begin transaction
   Delete
    FROM Vehiculo
    where(Vehiculo.Id = @Id)
    select @Id
    commit transaction
END