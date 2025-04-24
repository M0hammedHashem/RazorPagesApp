# Category Management System - ASP.NET Razor Pages

![.NET](https://img.shields.io/badge/.NET-6.0-%23512BD4)
![EF Core](https://img.shields.io/badge/EF%20Core-7.0-green)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.2-blueviolet)

A robust category management system implementing CRUD operations with modern architecture and UI components.

![Category Management Interface](screenshots/screenshot.png)

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
