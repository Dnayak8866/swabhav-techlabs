--exec uspGetRptDepartmentLabourApprovalDetails 31,10,12,2018,2018  
Alter PROCEDURE uspGetRptDepartmentLabourApprovalDetails    
(    
 @Projects varchar(max),    
 @FromMonth int,    
 @ToMonth int,    
 @Year int  ,  
 @TOYear int  
)    
as    
begin    
    
  declare @FromDate date =null, @ToDate date =null  
  set @FromDate=DATEFROMPARTS(@Year,@FromMonth,1)  
  set @ToDate=DATEFROMPARTS(@TOYear,@ToMonth,dbo.fnGetMonthDaysByMonthNo(@ToMonth,@TOYear))  
  print '@FromDate'  
  print @FromDate  
  print '@@ToDate'  
  print @ToDate  
  
  
create table #TempProjects(ProjectID int)    
if(@Projects is not null)            
 Begin            
  insert into #TempProjects             
  select item  from dbo.fnSplit(@Projects,'-')            
 END            
 ELSe            
 BEgin            
  insert into #TempProjects             
  select ID from Projects where IsActive=1            
 END         
  
  
select ProjectName,LabourCategoryType,TypeofLabour , sum(NoOfLabours) as 'NoOfLabours',sum(Approvedhours) as 'Approvedhours' , sum(TotalApprovedHours) as 'TotalApprovedHours'  
 , sum(DLSLabourCount) as 'DLSLabourCount',sum(DLSHours) as 'DLSHours',Month,  
 Convert(decimal(18,2),case when sum(TotalApprovedHours) >0 then  (sum(DLSHours)/sum(TotalApprovedHours)) else 0 end) as '%Exhaust' From (  
 
 select p.ProjectName,case when lct.LabourCategoryTypeID =0 then 'UnSkilled' when lct.LabourCategoryTypeID =1 then 'Skilled'  
 when lct.LabourCategoryTypeID =2 then 'Mat'  end as LabourCategoryType,    
lct.LabourCategoryShortName as 'TypeofLabour',dlad.NoOfLabours ,dlad.TotalManHours as 'Approvedhours' ,    
(dlad.NoOfLabours * dlad.TotalManHours) as 'TotalApprovedHours', 0 as 'DLSLabourCount',    
 0 as 'DLSHours',SUBSTRING( m.Name,0,4) + '-'+CONVERT(varchar,dla.FromYear) as 'Month'    
 from DepartmentalLabourApproval dla    
  inner join Projects p  on dla.ProjectID= p.ID    
 inner join DepartmentalLabourApprovalDetails dlad on dlad.DepartmentalLabourApprovalID=dla.ID    
 inner  join LabourCategoryType lct on lct.ID = dlad.LabourCategoryID    
  inner join Months m on dla.FromMonth=m.ID    
  where (DATEFROMPARTS(dla.FromYear,dla.FromMonth,1) between @FromDate and @ToDate) and p.ID in (select projectid from #TempProjects) and dla.IsActive=1    
  
  union  
  
  select p.ProjectName,case when lct.LabourCategoryTypeID =0 then 'UnSkilled' when lct.LabourCategoryTypeID =1 then 'Skilled'  
   when lct.LabourCategoryTypeID =2 then 'Mat'   end as LabourCategoryType,  
  lct.LabourCategoryShortName as 'Type of Labour',0,0,0,   
  SUM(ISNULL(ddlsd.NumOfLabour,0)) as 'DLSLabourCount',     
 Sum(ISNULL( ddlsd.WorkingHours,0) + ISNULL(ddlsd.LunchHour,0)) as 'DLS_Hours',SUBSTRING( m.Name,0,4) + '-'+CONVERT(varchar, Year(ddls.SlipDate)) as 'Month'    
 from DailyDepartmentalLabourSlip ddls    
 inner join DailyDepartmentalLabourSlipDetails ddlsd on ddls.ID = ddlsd.DDLSlipID   
  inner  join LabourCategoryType lct on lct.ID = ddlsd.LabourCategoryTypeID    
  inner join Months m on Month(ddls.SlipDate)=m.ID     
   inner join Projects p  on ddls.ProjectID= p.ID   
  where  (ddls.SlipDate) between (@FromDate) and (@ToDate)  and ddls.ProjectID in (select projectid from #TempProjects)  and ddls.IsActive=1    
 group by lct.LabourCategoryTypeID,p.ProjectName,lct.LabourCategoryShortName, Year(ddls.SlipDate),m.Name  
 ) as tm group by  ProjectName,LabourCategoryType,TypeofLabour,Month   
 order by MONTH  desc
   
end 