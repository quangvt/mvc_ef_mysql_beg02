Overview:

- Sample for ASP.NET MVC with Entity Framework on MySQL Database

- Medium: have 2 tables and have foreign key

==============================================
Environment: 
- Visual Studio 2015 (Community Edition) 
	+ Select .Net version 4.5
- Setup MySQL for Visual Studio 1.2.7
	+ Ref link: http://dev.mysql.com/doc/visual-studio/en/visual-studio-install.html
- Setup by NuGET: 
	+ MySQL.Data: version 6.9.9 
	+ MySQL.Data.Entity: version 6.9.9
	+ Entity Framework: 6.1.3

==============================================
Troubleshooting 

1. Error when generate DBContext from Code First in the first time
- Note about MySQL bug: 79163
https://bugs.mysql.com/bug.php?id=79163
http://stackoverflow.com/questions/33575109/mysql-entity-the-value-for-column-isprimarykey-in-table-tabledetails-is

- Set global variable
set global optimizer_switch='derived_merge=off'; Or
set @@optimizer_switch='derived_merge=off';

- check xem set duoc bien toan cuc chua
select @@optimizer_switch;

=============================================
Step by step for creating project on Visual Studio

1. Create New Project
- create MVC project (blank) 
- not select authentication option

2. Setup packages by Nuget-solution 
	(tools=>NuGet Package Manager=>
    	Manage Nuget Packages for Solutions...). Using search for setup something below:
- EntityFramework: 6.1.3
- MySQL.Data (6.9.9) for .Net 4.5
- MySQL.Data.Entity (6.9.9) for .Net 4.5

3. Create database mapping between code and db
- right click on "Models" folder
- add new item => choose "Data" => ADO.NET Entity Data Model => Set Name: MyDBContext 
	=> Choose "Code First from database" => New COnnection => MySQL => Fill connection info
	=> Choose "Yes, include the sensitive data..." => Checkbox Tables (select all needed tables)
- add code to Controller to check.


99. [IMPORTANCE]
- delete database name in all model files.

=============================================
Others references: 
1. https://www.youtube.com/watch?v=EhiUHMOJ8nw

2. Header Sorting + Search + Paging
- https://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/sorting-filtering-and-paging-with-the-entity-framework-in-an-asp-net-mvc-application

