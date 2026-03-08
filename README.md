```markdown
# 📚 Simple Library Management System

[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)](https://dotnet.microsoft.com/)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-purple)](https://docs.microsoft.com/ef/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red)](https://www.microsoft.com/sql-server)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

A **simple library management web application** built with **ASP.NET Core MVC** and **Entity Framework Core**. This project was created for **educational purposes** to demonstrate basic CRUD operations, database relationships, and the MVC pattern.

> ⚠️ **Note**: This is an **old educational project**. It may contain bugs, outdated practices, or incomplete features. Use it as a **learning reference** only, not for production.

---

## ✨ Features

- ✅ View list of books with their categories
- ✅ Add a new book (with client‑side validation)
- ✅ Edit existing book details
- ✅ Delete a book with confirmation
- ✅ Search books by title, author, or ISBN
- ✅ Basic navigation bar and responsive design (Bootstrap 5)

---

## 🛠️ Technologies Used

- **Backend:** ASP.NET Core 8.0 MVC, Entity Framework Core 8.0 (Code First)
- **Database:** SQL Server / LocalDB
- **Frontend:** Bootstrap 5, jQuery, jQuery Validation, Toastr.js, Bootstrap Icons

---

## 🚧 Known Issues / Limitations

- The category dropdown may have **color contrast issues** (text invisible on white background) – a quick CSS fix is included in the views.
- Some validation messages are a mix of English and Arabic.
- **No authentication/authorization** – anyone can modify data.
- Business logic is inside controllers (no separate service layer).
- No unit tests.
- The codebase is **not optimized** for performance or security.

---

## 🚀 How to Run Locally

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or LocalDB included with Visual Studio)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or any code editor with C# support)

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/mohamedkhamisdev/SimpleLibraryApp.git
   cd SimpleLibraryApp
   ```

2. **Update the database connection string**  
   Open `appsettings.json` and adjust `DefaultConnection` to match your SQL Server instance:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=LibraryDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

3. **Apply migrations to create the database**
   ```bash
   dotnet ef database update
   ```
   *(If the `ef` tool is not installed, run `dotnet tool install --global dotnet-ef` first.)*

4. **Run the application**
   ```bash
   dotnet run
   ```
   Open your browser and navigate to `https://localhost:5001` (or the URL shown in the terminal).

---

## 📁 Project Structure

```
SimpleLibraryApp/
├── Controllers/        # MVC Controllers (Home, Book)
├── Data/               # ApplicationDbContext
├── Models/             # Entity models (Book, Category, ErrorViewModel)
├── Views/              # Razor views
│   ├── Home/
│   ├── Book/
│   └── Shared/
├── Migrations/         # EF Core migration files
├── wwwroot/            # Static files (CSS, JS, libraries)
├── appsettings.json    # Configuration (connection strings, etc.)
└── Program.cs          # Application entry point
```

---

## 📄 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

*Happy learning! This code is intentionally kept simple for educational purposes.* 
```
