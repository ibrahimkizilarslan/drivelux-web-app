# DriveLux - Enterprise Car Rental Management System

DriveLux is a full-featured, enterprise-grade Car Rental Management System built with **ASP.NET Core 8.0** using **Onion Architecture**. Designed for scalability, maintainability, and high performance, it provides a seamless experience for both administrators and customers.

## 🚀 Key Features

### 🌐 Customer Portal
- **Advanced Search**: Filter vehicles by location, date, brand, and features.
- **Seamless Booking**: Real-time reservation system with instant confirmation.
- **Blog & News**: Stay updated with the latest car trends and company news.
- **Contact & Support**: Integrated communication system for customer inquiries.

### 🛠 Administrative Dashboard
- **Fleet Management**: Complete control over vehicle inventory, specifications, and pricing.
- **Brand Management**: Manage multiple car brands and their associated metadata.
- **Booking Insights**: Real-time statistics and reservation tracking.
- **Content Management (CMS)**: Full control over banners, testimonials, authors, and blog categories.
- **Dynamic Services**: Custom service management to highlight premium offerings.

## 🏗 Technical Stack & Architecture

This project follows **Onion Architecture** principles to ensure separation of concerns and testability.

- **Backend**: 
  - .NET 8.0 Web API
  - Entity Framework Core (SQL Server)
  - CQRS Pattern with MediatR
  - Repository & Unit of Work Patterns
  - FluentValidation for robust data integrity
- **Frontend**:
  - ASP.NET Core MVC (Razor Pages)
  - HTML5, CSS3, JavaScript
  - Bootstrap 5 for Responsive Design
  - Dynamic Partial Views & View Components
- **Tools**:
  - Swagger/OpenAPI for API Documentation
  - AutoMapper for DTO Mapping

## 📂 Project Structure

```
DriveLux
├── Core
│   ├── DriveLux.Domain        # Entities & Base Types
│   └── DriveLux.Application   # Business Logic, CQRS, Interfaces
├── Infrastructure
│   └── DriveLux.Persistence   # Data Access, Migrations, EfCore
├── Presentation
│   └── DriveLux.WebAPI        # REST API Endpoints
└── Frontends
    ├── DriveLux.WebUI         # MVC Web Application
    └── DriveLux.DTO           # Shared Data Transfer Objects
```

## ⚙️ Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/ibrahimkzilarslan/DriveLux.git
   ```
2. **Database Configuration**:
   - Update the connection string in `DriveLux.WebAPI/appsettings.json`.
   - Run migrations: `dotnet ef database update`
3. **Run the Application**:
   - Set `DriveLux.WebAPI` and `DriveLux.WebUI` as startup projects.
   - Press **F5** in Visual Studio or use `dotnet run`.

