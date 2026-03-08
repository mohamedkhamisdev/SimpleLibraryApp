# 📚 Simple Library Management System

<div align="center">

[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-7B68EE?style=for-the-badge&logo=databricks&logoColor=white)](https://docs.microsoft.com/ef/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![License](https://img.shields.io/badge/License-MIT-22C55E?style=for-the-badge)](LICENSE)

A simple library management web application built with **ASP.NET Core MVC** and **Entity Framework Core** — created for **educational purposes** to demonstrate CRUD operations, database relationships, and the MVC pattern.

> ⚠️ **Educational Project Only** — may contain bugs, outdated practices, or incomplete features. Not intended for production use.

</div>

---

## ✨ Features

| Feature | Status |
|---|---|
| View books with categories | ✅ |
| Add new book (with client-side validation) | ✅ |
| Edit existing book details | ✅ |
| Delete book with confirmation | ✅ |
| Search by title | ✅ |
| Responsive design with Bootstrap 5 | ✅ |

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| **Backend** | ASP.NET Core 8.0 MVC |
| **ORM** | Entity Framework Core 8.0 (Code First) |
| **Database** | SQL Server / LocalDB |
| **Frontend** | Bootstrap 5, jQuery, Toastr.js, Bootstrap Icons |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or LocalDB (included with Visual Studio)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or any C#-capable editor

### Installation

**1 — Clone the repository**
```bash
git clone https://github.com/mohamedkhamisdev/SimpleLibraryApp.git
cd SimpleLibraryApp
```

**2 — Configure the connection string**

Open `appsettings.json` and update `DefaultConnection`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=LibraryDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

**3 — Apply database migrations**
```bash
dotnet ef database update
```
> 💡 If `ef` tool is missing, install it first:
> ```bash
> dotnet tool install --global dotnet-ef
> ```

**4 — Run the app**
```bash
dotnet run
```
Then open `https://localhost:5001` (or the URL shown in the terminal).

---

## 📁 Project Structure
```
SimpleLibraryApp/
├── Controllers/        # MVC Controllers (Home, Book)
├── Data/               # ApplicationDbContext
├── Models/             # Entity models (Book, Category, ErrorViewModel)
├── Views/
│   ├── Home/
│   ├── Book/
│   └── Shared/
├── Migrations/         # EF Core migration files
├── wwwroot/            # Static files (CSS, JS, libraries)
├── appsettings.json    # App configuration
└── Program.cs          # Entry point
```

---

## 🚧 Known Limitations

> This project is intentionally simple. The following are known gaps — good starting points if you want to extend it!

- **No auth** — anyone can read or modify data
- **No service layer** — business logic lives directly in controllers
- **No unit tests**
- Some validation messages mix English and Arabic
- Category dropdown may have color contrast issues (a CSS fix is included in the views)
- Not optimized for performance or security

---

## 📄 License

This project is licensed under the **[MIT License](LICENSE)**.

---

<div align="center">

*Happy learning! This code is intentionally kept simple for educational purposes.* 

</div>
