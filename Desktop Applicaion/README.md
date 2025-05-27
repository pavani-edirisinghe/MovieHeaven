# 💻 MovieHeaven – Desktop Application

This is the **desktop interface** of the MovieHeaven Movie Ticket Management System. Built with **C# and WPF**, it is primarily designed for **theater staff**, including **admins** and **cashiers**, to manage daily operations such as movie schedules, seat bookings, ticket issuing, and staff records.

---

## 🧩 Features

### 🔐 Authentication
- **Admin Login** – Secure login for administrators.
- **Cashier Registration & Login** – Cashiers can register and log in to manage ticketing.

### 🧑‍💼 Admin Panel
- **Staff Management (CRUD)** – Admins can create, read, update, and delete cashier/staff accounts.
- **Movie Management (CRUD)** – Admins can add, edit, view, and delete movie details and schedules.

### 🎟️ Cashier Panel
- **Seat Booking** – Cashiers can view showtimes, select available seats, and book them for customers.
- **Ticket Issuing** – Automatically generate and issue tickets after successful bookings.

---

## 🛠 Tech Stack

- **Language**: C#
- **UI Framework**: WPF (.NET Core / .NET Framework)
- **Database**: SQLite
- **IDE**: Visual Studio

---

## 📁 Folder Structure

Desktop Application/<br>
├── README.md<br>
├──  📁 screenshots/<br>
│   ├── admin-login.png<br>
│   ├── buy-tickets.png<br>
│   ├── issue-ticket.png<br>
│   ├── movie-management.png<br>
│   ├── signin.png<br>
│   ├── staff-management.png<br>
├──  📁 Desktop Application/<br>
│   ├──  📁 Assets<br>
│   ├──  📁 bin<br>
│   ├──  📁 Movie_Directory<br>
│   ├──  📁 obj<br>
│   ├──  📁 Properties<br>
│   ├──  📁 Resources<br>
│   ├──  📄 AddMovieForm.cs<br>
│   ├──  📄 AddMovieForm.Designer.cs<br>
│   ├──  📄 AddMovieForm.resx<br>
│   ├──  📄 AddStaffForm.cs<br>
│   ├──  📄 AddStaffForm.Designer.cs<br>
│   ├──  📄 AddStaffForm.resx<br>
│   ├──  📄 AdminForm.cs<br>
│   ├──  📄 AdminForm.Designer.cs<br>
│   ├──  📄 AdminForm.resx<br>
│   ├──  📄 buyTicketForm.cs<br>
│   ├──  📄 buyTicketForm.Designer.cs<br>
│   ├──  📄 dashboardForm.cs<br>
│   ├──  📄 dashboardForm.Designer.cs<br>
│   ├──  📄 dashboardForm.resx<br>
│   ├──  📄 SQLQuery1.sql<br>
│   ├──  📄 SQLQuery1.1.sql<br>
│   ├──  📄 SQLQuery1.2.sql<br>
│   ├──  📄 SQLQuery1.3.sql<br>

---

## ▶️ Run the Application

 1. Clone the repository
git clone https://github.com/pavani-edirisinghe/MovieHeaven.git

2. Navigate to the Desktop Application directory
cd MovieHeaven/"Desktop Application"

3. (Optional) Restore dependencies (if using .NET Core)
dotnet restore

4. Build the project
dotnet build

5. Run the application (only works for .NET Core WPF apps)
dotnet run

 OR

 If targeting .NET Framework, open the solution in Visual Studio:
 start ../MovieHeaven.sln

 Then:
- Set "Desktop Application" as the startup project
- Press F5 or click "Start" to launch


---

## ▶️ Run the Application
- A local SQLite database **(movieheaven.db)** is created automatically on first run.

- Admin credentials must be manually added or seeded initially if none exist.

- Cashiers must register using the desktop app before logging in.

---
## 📸 Screenshots

### 🔐 Signin
![signin](screenshots/signin.png)

### 🔐 Admin Login
![Admin Login](screenshots/admin-login.png)

### 👥 Staff Management
![Staff Management](screenshots/staff-management.png)

### 👥 Movie Management
![Movie Management](screenshots/movie-management.png)

### 👥 Buy Tickets
![Staff Management](screenshots/buy-tickets.png)

### 🎟️ Issue Ticket
![Seat Booking](screenshots/issue-ticket.png)

---

## 📄 License

- This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).  
- You are free to use, modify, and distribute this software with proper attribution.
---


