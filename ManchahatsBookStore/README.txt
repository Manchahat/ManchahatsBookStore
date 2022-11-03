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