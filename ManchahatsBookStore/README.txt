Name- Manchahat Singh Bhangu
Student Number- 0802991


2022-10-27
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

2022-11-14
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

2022-11-15
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

9:58am
Build the and there were no errors


10:10am
created category folder 
and one views file name index.cshtml
and modified it 

did some change in starup .cs

2022-11-17
i don't know why my local host is not working fixed the errors but still its not working

11:45am

while starting the website the error 500 is coming which is the main issue 


2022-11-23
11:04 am

the error of local host which was showing 
i fixed the error because of database and there was an error with the viewimports.cshtml and viewsstart.cshtml
which is fixed and app is working for now.

11:21 am
changed the navigation and action replaced to Category
  <a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>

  the content of Category was displayed

  11:54am

  i created new js file name category.js in wwwroot and done the changes in that file 
  after that i added the  section call of category.js in index.cshtml file 
  and run the app the category list was working properly

  12:00pm

  I created Upsert file and modified it with the given code 
  and another partial view file name (_CreateAndBackToListButton.cshtml)

  12:10pm
 
 modified upsert.cshtml file after that i navigate to category

and in upsert.cshtml in changed the name from crate category to TITLE
and added the section call.

12:22pm
in caterory controllers i added the void Save() to interface Iunitwork which allow to save method

12:30pm
removed _db.Savechanges() method in categoryrepository.cs file 
the rebuild it and checked the errors wnd tested is and was working.


3:37pm
continue part3

5:26pm

created covertype.cs in modles folder with name and id 
after that i created clas and interface (Covertpyerepository and iCovertyperepository)
in repository folder

5:29pm
in covertyperepository the error is which s cofusing and i am trying to fix 

5:40pm
fixd the errors and created migration 20221115013858_AddCategoryToDb.cs
abd updated it

6:05pm
some of file were not updated so thats why i updated those files and the missing covertype  was created in sql server

6:46pm
i created product files in repostory foldaer
migrated it 20221123235909_AddProductToDb.cs
and created product database and added on sql server

7:14pm
created the file name(covertype.controller) in controller and done some changes.

7:30pm
created view file of cover type 
in which index.cshtml and upsert.cshtml file created 

9:01pm
created product controller 

11-30-2022
3:00pm

added using statement AspNetCore.Hosting for it to work and Created a View Model in the models folder

3:10pm
created the ProductVM file and Installed the Microsoft.AspNetCore.Mvc.ViewFeatures package

3:14pm
Modifed the ProductController
Commented the Upsert Post method then Added an index view file in the Areas/Admin/Views/Product folder

3:20pm
Created a new product.js file 
and then Copied the category.js file in the Product.js file and didi some changes

3:27pm
added new link to the Product in the DropDown in  _layout.cshtml

4:41pm
In Product.cs added three more properties
	[Required]
						[Range(1, 10000)]
						public double Price { get; set; }
						[Required]
						[Range(1, 10000)]
						public double Price50 { get; set; }
						[Required]
						[Range(1, 10000)]
						public double Price100 { get; set; }

4:42pm

Added migration and updated it
add-migration AddNewValidationToProduct

4:45pm
added new properties and validations to the Productrepository.cs
objFromDb.Price = product.Price;
objFromDb.Price50 = product.Price50;
objFromDb.Price100 = product.Price100;


4:48pm
in SD.cs file did some changes
public const string Proc_CoverType_Create = "usp_CreateCoverType";
public const string Proc_CoverType_Get = "usp_GetCoverType";
public const string Proc_CoverType_GetAll = "usp_GetCoverTypes";
public const string Proc_CoverType_Update = "usp_UpdateCoverType";
public const string Proc_CoverType_Delete = "usp_DeleteCoverType";


4:51pm

In Upsert.cshtml file  i modified it with this code
<div class="form-group row">
									<div class="col-4">
										<label asp-for="Product.Price"></label>
									</div>
									<div class="col-8">
										<input asp-for="Product.Price" class="form-control" />
										<span asp-validation-for="Product.Price" class="text-danger"></span>
									</div>
								</div>
								<div class="form-group row">
									<div class="col-4">
										<label asp-for="Product.Price50"></label>
									</div>
									<div class="col-8">
										<input asp-for="Product.Price50" class="form-control" />
										<span asp-validation-for="Product.Price50" class="text-danger"></span>
									</div>
								</div>
								<div class="form-group row">
									<div class="col-4">
										<label asp-for="Product.Price100"></label>
									</div>
									<div class="col-8">
										<input asp-for="Product.Price100" class="form-control" />
										<span asp-validation-for="Product.Price100" class="text-danger"></span>
									</div>
								</div>


5:05pm

In HomeController.cs file made some changes. 
and build the application with no errors 

5:09pm
In Index.cshtml file modified chnages to display product on the home page

5:13pm

the application is working perfectly and the content is showing oth the home page 
