DECLARE @json NVARCHAR(MAX)

 SELECT @JSON = BulkColumn
FROM OPENROWSET (BULK 'D:\Projects\Dreamlines -V2\UsefullRepo\Dreamlines-V2\JsonFilesDB\TrialDayData.JSON', SINGLE_CLOB) as j 
 
 
INSERT INTO Bookings  
SELECT * FROM  
 OPENJSON ( @json , N'lax $.bookings')  
  WITH (   
              id       int             '$.id' , 
			  shipId  int     '$.shipId', 
              bookingDate     varchar(max)     N'lax $.bookingDate',
	          price float  '$.price'
               )

 