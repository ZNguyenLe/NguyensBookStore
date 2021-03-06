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

11/22/2021 1:55PM
- continued assignment 2 part 2 to apply code to activate the edit, delete, and create buttons
- created Upsert.cshtml RAZOR view and edited the html form inside it
- Created the _CreateAndBackToListButton.cshtml file in the general views folder.
- Created another partial view named _EditAndBackToListButton.cshtml file
- updated and modified the Upsert.cshtml file with the @model statement

11/23/2021 3:00PM
- had a visual issue where the bottom border box closed at the wrong spot
- updated the upsert.cshtml
- added another @section scripts in upsert.cshtml
- added more code to the category.js file
- there was an issue with my delete button and could not function, the btn-danger wasnt showing
- solve the issue where spacing mattered. the delete button works now.
- completed the edit/add category/delete sections

11/23/2021 10:20PM
- started assignment 2 part 3 
- ran the application at home to test if the delete function is working after updating database (which is successful)
- Created a new Model named CoverTypel.cs with the ID and Name credentials and included it as a public class.
- updated and added new files named CoverTypeRepository.cs class file & ICoverTypeRepository.cs Interface file.
- included CoverType to IUnityOfWork & UnitOfWork
- Created a new migration named AddDefaultIdentityMigration2 with the filename as 
	20211124041134_AddDefaultIdentityMigration2.cs (timestamp is included) inside the DataAccess project.
	but this is supposedly my AddCoverTypeToDb.cs table kinda
- added the covertype stuff into the UnitOfWork.cs and IUnitOfWork.cs to make the covertype accessible
- Created a new Folder named CoverType with the new View of Index.cshtml inside the public view directory.
- Created and edited the code inside the Index.cshtml of CoverType
- saved everything and tested code 
- tried navigating to the CoverType tab and it didnt work
- the admin area was not specified in the CoverTypeController.cs
- implemented the admin area fix and now the page loads.
- added buttons to the form to test if it will display.
- Created an Upsert cshtml. while in the process of creating the functioning buttons.
- My buttons are working but cannot add a covertype, but the alert for the requirement shows if textbox is empty
- created a new JS file for CoverType. included the function and tried to get the stuff working
- receieved an exception error when trying to create through the edit covertype section
- ran the application, tested the CoverType functions to add but i still cannot delete
- there was a typo on my delete function inside my covertype.js file and now resolved. I can now delete the new datatables.
- saved everything and pushed to github 

(completed Assignment 2 part 1 at 4:14PM on 11/24/2021)

continued assignment 2 but now part 3 section 1 second slide ish on 11/24/2021 at 4:30PM
- created a new class named Product.cs in Models
- added the get set methods within product.cs
- added reference to the new products piece to the database in the ApplicationDbContext.cs File
- added a new migration file named with the timestamp here as 20211124213838_addProductToDb.cs
- viewed the table from within the SQL Server Object Explorer
- updated the producted class so that Title, ISBN and Author are required
- created another migration named 20211124214320_addValidationToProduct.cs (timestamp included)
- stopped assignment but pushed everything to github.

continued assignment 2 part 3 at 7:25PM on 11/24/2021
- created a new class and interface for product
- added a product controler to Areas > Admin > Controllers
- created a ProductController and added content inside it.
- had to install the Microsoft.AspNetCore.Mvc.ViewFeatures while modifying the ProductVM
- Created an Upsert method for the Product Controller.
- commented out the Upser methoed and added the API CALLS with the GetAll() & Delete Methods
- created a new JS file and took the content from category.js and pasted it over and modified it
- ran the application, and did get an exception and clicked 'continue'

- created upsert.cshtml within the product directory of Areas/Admin/Views/Product
- trying to add a rich textbox to the textarea with tiny.cloud using the API key
- Manually typed in the commented code from the slides because there was nothing about the Upsert Post Action method on blackboard.
- Every time I run the application, the exception will trigger every time. but everything works after clicking 'continue'
- Completed Assignment 2 part 3(Section 3) on 2021-11-24 at 9:32PM

2021/11/25
- found out why my table was looking so ugly. changed the style classes and now it is readable. :)
- having an issue where nothing was being displayed on the page upon submittion with products