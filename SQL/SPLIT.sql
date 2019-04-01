DECLARE @list varchar(8000)
DECLARE @pos INT
DECLARE @len INT
DECLARE @value varchar(8000)
DECLARE @status int

SET @list = 'Australia,Belgium,Canad,France'

set @pos = 0
set @len = 0

WHILE CHARINDEX(',', @list, @pos+1)>0
BEGIN
    set @len = CHARINDEX(',', @list, @pos+1) - @pos
    set @value = SUBSTRING(@list, @pos, @len)
            
     IF EXISTS(SELECT * FROM COUNTRIES WHERE COUNTRY_NAME=@value) 
     
     SELECT  @status=1
     else
     SELECT @status=0 
     BREAK 
    
    --PRINT @value -- for debug porpose   
    
    --DO YOUR MAGIC HERE

    set @pos = CHARINDEX(',', @list, @pos+@len) +1
END
PRINT @STATUS
