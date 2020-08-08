CREATE PROCEDURE [dbo].[ITR_SP_GetUserProfile]  
 @CabId INT   
AS  
BEGIN  
	SELECT DriverName, ContactNumber, Gender, CabNumber, DriverLicense, Position, ArrivalTime 
	FROM DriverDetails DD INNER JOIN CabDetails CD
	ON DD.CabId = CD.CabId
	WHERE DD.CabId = @CabId
END