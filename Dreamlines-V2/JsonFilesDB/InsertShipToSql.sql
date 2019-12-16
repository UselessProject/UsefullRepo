DECLARE @json NVARCHAR(MAX)

 SELECT @JSON = BulkColumn
FROM OPENROWSET (BULK 'D:\Projects\Dreamlines -V2\UsefullRepo\Dreamlines-V2\JsonFilesDB\TrialDayData.JSON', SINGLE_CLOB) as j 
 
 
INSERT INTO Ships  
SELECT * FROM  
 OPENJSON ( @json , N'lax $.ships')  
  WITH (   
              id       int             '$.id' , 
			  salesUnitId  int     '$.salesUnitId', 
              name     varchar(max)     N'lax $.name'
	          
               )

 