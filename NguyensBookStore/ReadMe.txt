Nguyen Le's ReadMe

10/28/2021
started assignment 2
- Created a new project called NguyensBookStore.
- Removed the options code inside the Startup.cs file. 
- saved the existing css files inside boostrap.css / site.css as a backup.
- Updated css on both files to the Cyber theme found on bootswatch site

11/01/2021
continued assignment 2
- added a dropdown menu with 3 actions
- changed the dropdown text to Content Management.
- added 3 new projects called NguyensBooks.DataAccess, Models, and Utility.

- continued at home
- Updated a unique theme from bootswatch from Yeti demo'd in class to Cyborg Theme. 
- installed the packages of relational and sqlserver
- Modified the namespace in the ApplicationDbContext.cs file
- Moved Models into the NguyensBooks.Models project and deleted the original
- added a project reference with DataAccess & Models. 
- changed the namespace inside the ErrorViewModels.cs namespace to NguyensBookStore.Models.ViewModels
- adjusted the homecontroller to either change the errorView on line 35 in HomeController.cs or include the 'using NguyensBookStore.Models.ViewModels;'

- added a new class named SD.cs
- modified the class to a public static class
- added the project reference to the main project
- added project reference to the models and utility within the DataAccess project
- added a new area named customers
- added the {area=Customer} within line 67 in Startup.cs
- moved the HomeController.cs and deleted Models & Data folders in the Customer directory
- included the [Area("Customer")] that will explicitly define that the controller is in the customer area.
- Moved Home folder from Views/Shared to Areas/Views
- Included Area and Customer into the namespace in HomeController.cs
- Included an Admin folder inside Areas & deleted the data / models folders, and the contollers folder 
- commited & pushed to Github Repo

- Finished Assignment 2 part 1 on 11/02/2021

Continued Assignment 2 Part 2 on 11/08/2021 at 2:54 PM in class
- Opened & cloned the project repo from github
- Cleaned and built the solution confirm that everything is working okay.
- Copied the default connection & pasted as a comment to serve as a backup in appsetting.json
- Tried to add a migration to test if it would match the migrations assembly in the NuGet Package Manager Console
- Switched the Default Project to NguyensBooks.DataAccess and ran the same command.
- The Migration is created with the name of 20211108200425_AddDefaultIdentityMigration.cs
- reviewed the Migration.cs file created earlier in .DataAccess that contains SQL-like statemtns & syntax.
- successfully ran the update-database command in the .DataAccess project and has succeeded.
- found the table created in the SQL Server Object Explorer on the left side of the program window. 
- tested application after checking if no errors. 
- Created Category Class as Category.cs
- added the content along with the dataannotations. 
- added another migration as AddCategoryToDb in the DataAccess project and succeeded.
- tried to update the existing migration & recieved an error saying that "the name AddCategoryToDb is used by an existing migration."
- re added the new migration with the new file name as 20211108204250_AddCategoryToDb.cs

Continued Assignment 2 (part 2) on 11/11/2021 at 1:35PM
- had an issue pulling from github repo that the entityframeworkcore was in the previous version of 5.0.8 now to 5.0.11
- Created a Repository Directory inside the DataAccess project with a IRepository subfile.
- Created a Repository.cs file in the same folder directory as Repository. 
- Opened the repository.cs file from blackboard
- implemented the code from the provided file to my own repository.cs file.
- Created 2 more class files named CategoryRepository.cs & ICategoryRepository.cs within the Repository Folder.
- Modified the CategoryRepository.cs file

Continued Assignment 2 (part 2) on 11/11/2021 at 9:40PM
- Created ISP_Call.cs 
- created SP_Call.cs
- Created IUnitOfWork.cs (the typo mentioned from the slides)
- created the class UnitOfWork
- encountered the issue inside the Startup.cs file trying to implemennt the IUnitOfWork & UnitOfWork but it is saying that it is inaccessible due to its protection level and namespace is not
  able to be found.
- Might have found a solution where the public class inside the UnitOfWork.cs that the interface was not shown as per the screenshot provided in the slides. 
- and the public interface was not defined inside the UnitOfWork.cs file (was not shown in the slides. this might be the missing piece)
- In the screenshot from the assignment 2 slides. The Public Class UnitOfWork in the IUnitOfWork.cs File was missing the public Interface
- Hopefully solved the issue by declaring the interface inside the UnitOfWOrk.cs file
- and now the error from the Startup.cs file disappeared.
- updated as to 2021-11-13 at 12:10AM and pushed to github 
- double checked if there were any errors before pushing project to github.

Continuing Project on 2.3 Category CRUD at 2021-11-13 at 12:10AM
- Added a new Controllers folder (mine was not there apparently). 
- created a new controller.cs file named CategoryController.cs
- added the content that was required for the controller
- now creating a new folder named Category inside Areas/View directory
- created a new Index.cshtml template inside Areas/Views/Category 
- opened the Category Index View from blackboard provided inside the Assignment 2 - Files folder
- copied and pasted that provided code into index.cshtml.
- Saved and ran the application
- made sure to type the full link directory in the search box on the browser to the Category page.
- confirmed that it is working.
- Changed the nav-link code on _Layout.cshtml around line 30 to link towards the new Category section
- moved that entire line to the class="dropdown-menu".
- added another div that focuses on the trash-can and edit icon from the FontAwesome Website. 
- ran the application again and verified it is working.
- added a Javascript file named category.js
- blackboard was showing the code and could not download so had to manually create a new .js file and copy pasted code
- replaced the return statement in the js file from the one created in the Index.cshtml
- added the script section with the script source inside Index.cshtml
- ran and tested the application, it worked up to the point after a delay when visiting the category page.
- it froze a couple seconds later and gave me an error.
- the issue is supposedly saying there's something wrong with the GetAll method in the Repository.cs
- Failed to load resource: the server responded with a status of 500 (Internal Server Error) [http://localhost:2185/Admin/Category/GetAll?_=1636860169183]
- solved the issue where it's complicating things inside the appsetting.json file
- tried to see if the trash/edit icons would show but I have no records shown so it will not appear.
- completed Assignment 2 Part 2 on 2021-11-14 at 1:15PM

11/15/2021 
- had to update database in class before marking because the category form page kept crashing. with the error on the GetAll Method.