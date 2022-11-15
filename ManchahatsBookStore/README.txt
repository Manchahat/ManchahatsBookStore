Name- Manchahat Singh Bhangu
Student Number- 0802991

10:45
Created a new Project (ManchahatsBookStore)
changed the Authentication to Individual Account and enable razor runtime compilation

10:55
created a github file 

10:56
Updated the readme file on github

11:00
Did some changes in startup.cs file deleted the code which was given
Given- (services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true))
Changed-  services.AddDefaultIdentity<IdentityUser>()

11:15
in controller file i added two break points and run the program
and program started successfully

11:16
ManchahatBookstore page created 
moving ahead to download the bootstrap file from bootswatch.com

11:25
downloded the lux bootstrap file and replaced this file with existing file which was in wwwroot folder 
and changed bootstrap.min.css to bootstrap.css in _layout.cshtml
from-  <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
to -  <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />

11:29
in layout.cshtml i have changed navbar-light to navbar-dark and bg-white to bg-primary
in line 23 removed the given text-dark

11:35
made some changes in _loginpartial.cshtml file 
in line 9 i removed text-dark

9:14 
added the additional script in layout.cshtml 

9:44
added content management to nav bar in layout.cshtml 
but shows error in UI
somthing is wrong 

10:00
created three new projects 
Manchahatbooks.dataAccess
ManchahatBooks.Models
ManchahatBooks.Utility

after that i copied the data folder in .Dataaccess project and deleted original data file

14 november
10:40 am
i sovle the errors which were coming in the layout file and then i run the program and it started working properly

12:35pm
installed all three packages
Microsoft.EntityframeworkCore.Relational
core.SqlServer
Identity.EntityFrameworkCore
installed properly
After that i deleted migration folder

12:40 pm
corrected the namespace
from ManchahatBookStore.Data  
to ManchahatBookStore.DataAccess.Data
next deleted Class1.cs file from all three projects

12:50pm
model folder moved into ManchahatBooks.models project

12:58pm
added project refrence and rename models folder to ViewModels
after that rename the namespace 
from   ManchahatBookStore.Models
to     ManchahatBookStore.Models.ViewModels

1:18pm
did some changes in startup.cs file and run the application without any error

1:41 pm
added the ptoject refrence and did changes in utility file

4:40pm
added refrence of models and utility to ManchahatBooks.DataAccess
Created MVC areas with name customers in Areas folder

4:50pm
changed the location of homecontroller.cs file moved to areas-customer. nad deleted data and models folder
and modified home controller name space

5:00pm
added the new route for viewstart.cshtml which was copied to home file in views

7:01pm
added the new admin area in areas folder and deleted controller folder

7:16pm
modified the database name and used the nuget package manager console for adding the migration

7:40pm
run the package manager console 
by add-migration AddDefaultIdentityMigration
and run successfully by changing the default project manchahatBookStore.DataAccess

7:43pm
updated database
and it build successfully

8:10pm
added new class in models project by naming it category.cs
and added the migration by running the code add-migration AddCategoryToDb
done sone changes in addcategorytodb.cs

8:49pm
created new folder in ManchahatBooks.DataAccess
(Repository)
in Repository
i made the new folder and name it IRepository

9:20pm
i created new class (Repository)

9:40pm
done changes in repository.cs file 

9:47pm
created ICategoryrepository
and CategoryRepository

15november
8:06am
Done the changes in category and icategory class and fixed the errors 

8:27am
created new class name ISP_Call in irepository
and downloded dapper package
now errors are fixed

8:40am
created class name SP_Call.cs in repository
and updated the implement in SP_Call

9:00am
updated sp_call,cs

9:30am
creadted new interface  unitofwork.cs

9:55am
created another class in repository
and modified it 