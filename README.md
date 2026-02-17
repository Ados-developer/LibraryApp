# LibraryApp
This Windows Forms application is designed as a simple library management system. The application allows users to browse available books and manage borrowing activities.

Registered users can borrow and return books through an easy-to-use interface. The system keeps track of book availability and user actions to ensure proper management of the library resources.

Administrators have extended permissions and can manage both books and users. Admin features include adding new books or users, editing existing records, and removing items from the system when necessary.

The application focuses on providing a clear and intuitive user experience while maintaining efficient control over library operations.


## Technologies
  - .NET 10 / C# / Windows Forms
  - Entity Framework Core + SQLite
  - Microsoft.Extensions.Hosting for DI
  - Visual Studio Community 2026

## Login Information
  - The login credentials are stored in the database at Data/LibraryAppDbContext.

## 🚀 How to Run the Project
  1. Clone the repository
  ```bash
  git clone https://github.com/Ados-developer/LibraryApp.git
  cd LibraryApp
  ```

  2.Restore NuGet packages
  - In Visual Studio: Tools → NuGet Package Manager → Restore Packages

  3.Build the project
  - Open LibraryApp.sln in Visual Studio → Rebuild Solution

  4.Run the application
  - Login screen appears first.
  - Use credentials stored in Data/LibraryAppDbContext (or add new users via seed/migrations).
  - After login, the main LibraryApp interface opens.
