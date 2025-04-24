markdown
# Category Management System - ASP.NET Razor Pages

[![.NET](https://img.shields.io/badge/.NET-6.0-%23512BD4)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-7.0-green)](https://learn.microsoft.com/en-us/ef/core/)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-5.2-blueviolet)](https://getbootstrap.com/)

A robust category management system implementing CRUD operations with modern architecture and UI components.

## Key Features

- 🚀 Complete Category CRUD Operations
- 📁 N-Layer Architecture Implementation
- 🎯 Repository Pattern & Dependency Injection
- 📱 Responsive Bootstrap 5 Design
- 📢 Toastr Notifications for User Feedback
- 🗄️ SQL Server Database Integration
- 📦 Entity Framework Core 7 Data Access

## Project Structure
RazorPagesApp/
├── Data/ # Database context and configurations
├── Models/ # Domain entities and DTOs
├── Pages/ # Razor Pages and page models
│ └── Categories/ # Category-related pages
├── Services/ # Business logic layer
├── wwwroot/ # Static assets
│ ├── css/ # Custom styles
│ ├── js/ # JavaScript files
│ └── lib/ # Third-party libraries
├── appsettings.json # Configuration settings
└── Program.cs # Startup configuration


## Getting Started

### Prerequisites

- .NET 6 SDK
- SQL Server (LocalDB included with Visual Studio)
- Visual Studio 2022+ or VS Code

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/M0hammedHashem/RazorPagesApp.git
   cd RazorPagesApp
Configure the database:

Update connection string in appsettings.json:

json
"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CategoryDB;Trusted_Connection=True;"
Apply migrations:

bash
dotnet ef database update
Run the application:

bash
dotnet run
Key Implementation Details
Dependency Injection Setup
csharp
// Program.cs
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICategoryService, CategoryService>();
Repository Pattern Implementation
csharp
// Services/CategoryService.cs
public class CategoryService : ICategoryService
{
    private readonly ApplicationDbContext _db;

    public CategoryService(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task CreateCategory(Category category)
    {
        await _db.Categories.AddAsync(category);
        await _db.SaveChangesAsync();
    }
    // Other CRUD methods...
}
Toastr Notification Integration
javascript
// wwwroot/js/notification.js
function showNotification(message, type) {
    toastr.options = {
        positionClass: "toast-bottom-right",
        preventDuplicates: true
    };
    toastr[type](message);
}
