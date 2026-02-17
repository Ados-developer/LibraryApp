using LibraryApp.Data;
using LibraryApp.Forms;
using LibraryApp.Helpers;
using LibraryApp.Interfaces;
using LibraryApp.Repositories;
using LibraryApp.UserControls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibraryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // C:\Users\<YourName>\AppData\Roaming\LibraryApp\database.db
            string? dbFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LibraryApp");
            Directory.CreateDirectory(dbFolder);
            string? dbPath = Path.Combine(dbFolder, "database.db");

            ApplicationConfiguration.Initialize();
            IHost? host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    //Database
                    services.AddDbContext<LibraryAppDbContext>(options =>
                        options.UseSqlite($"Data Source={dbPath}"));
                    //Repositories
                    services.AddScoped<ILibraryUserRepository, LibraryUserRepository>();
                    services.AddScoped<IBookRepository, BookRepository>();
                    services.AddScoped<ILoanRepository, LoanRepository>();
                    //Forms
                    services.AddTransient<LibraryAppForm>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<CreateEditUserForm>();
                    services.AddTransient<ChangePasswordForm>();
                    services.AddTransient<CreateEditBookForm>();
                    //UserControls
                    services.AddTransient<UsersCtrl>();
                    services.AddTransient<ProfileCtrl>();
                    services.AddTransient<BooksCtrl>();
                    services.AddTransient<LoansCtrl>();
                    services.AddTransient<ReturnsCtrl>();
                })
            .Build();

            var services = host.Services;
            Application.Run(new LibraryAppContext(services));
            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LibraryAppDbContext>();
                db.Database.Migrate();
            }

        }
    }
}