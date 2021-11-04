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
- Included an Admin folder inside Areas

- Finished Assignment 2 part 1 on 11/02/2021