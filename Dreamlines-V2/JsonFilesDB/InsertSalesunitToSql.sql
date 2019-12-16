DECLARE @json NVARCHAR(MAX)

 SELECT @JSON = BulkColumn
FROM OPENROWSET (BULK 'D:\Projects\Dreamlines -V2\UsefullRepo\Dreamlines-V2\JsonFilesDB\TrialDayData.JSON', SINGLE_CLOB) as j 
 
 
 INSERT INTO Salesunits  
SELECT * FROM  
 OPENJSON ( @json , N'lax $.salesUnits')  
WITH (   
              id       int             '$.id' ,  
              name     varchar(max)     '$.name',  
              country  varchar(max)     '$.country',  
              currency varchar(max)      '$.currency'  
 ) 

 --SELECT * FROM OPENJSON (@JSON) 
--WITH(OrderID int,CustomerID int,OrderStatus char(1)) as Orders