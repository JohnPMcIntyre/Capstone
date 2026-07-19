# McIntyre's Fitness App
### John McIntyre | Grand Canyon University | CST-451 / CST-452 Capstone Project

---

## Project Overview

McIntyre's Fitness App is a Windows Forms desktop application built in C# and MySQL. The app allows users to register accounts, log workouts, view their training history, track progress statistics, and visualize their progress over time through a line graph. The goal of the project was to build a practical, locally hosted fitness tracking tool that gives users full control of their data without requiring internet connectivity or a subscription.

---

## Background

This project was developed over two courses at Grand Canyon University as part of the Senior Capstone sequence (CST-451 and CST-452). Development followed an Agile Scrum methodology with iterative milestones, user stories, and continuous testing throughout both semesters.

---

## Features

- User registration with input validation
- Secure login with SHA256 password hashing
- Log workouts with exercise name, sets, reps, and weight
- View full workout history in a sortable grid
- Filter workout history by date range
- Edit and delete existing workouts with confirmation dialog
- Progress statistics screen showing total workouts, total weight lifted, heaviest lift, and favorite exercise
- Progress chart with line graph showing weight lifted over time
- Motivational messages displayed on the dashboard
- Logout with session clearing
- Consistent dark navy UI across all forms

---

## Technology Stack

- **Language:** C# (.NET 9)
- **UI Framework:** Windows Forms
- **Database:** MySQL (local)
- **IDE:** Visual Studio 2022
- **Security:** SHA256 password hashing, parameterized SQL queries
- **Charting:** System.Windows.Forms.DataVisualization
- **Version Control:** GitHub

---

## Architecture

The application uses a three-layer architecture:

- **Presentation Layer:** Windows Forms UI (LoginForm, DashboardForm, WorkoutForm, WorkoutHistoryForm, WorkoutEditForm, ProgressForm, WorkoutChartForm)
- **Business Logic Layer:** C# form logic handling validation and data flow
- **Data Layer:** MySQL database with DatabaseHelper.cs managing all queries

### Database Schema

**Users Table**
- UserID (Primary Key)
- Username (VarChar 50)
- PasswordHash (VarChar 255)

**Workouts Table**
- WorkoutID (Primary Key)
- UserID (Foreign Key)
- ExerciseName (VarChar 100)
- Sets (Integer)
- Reps (Integer)
- Weight (Decimal)
- WorkoutDate (DateTime)

---

## Code Snippet

Here is the core password hashing method used to secure user passwords before storing them in the database:

```csharp
private string HashPassword(string password)
{
    using (SHA256 sha256 = SHA256.Create())
    {
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }
}
```

Here is the database query used to retrieve workout data for the progress chart:

```csharp
public DataTable GetWorkoutsForChart(int userId)
{
    string query = @"SELECT WorkoutID, ExerciseName, Sets, Reps, Weight, WorkoutDate
                     FROM Workouts
                     WHERE UserID = @userId
                     ORDER BY WorkoutDate ASC";
}
```

---

## How to Run the Project

1. Install Visual Studio 2022 and MySQL
2. Clone the repository: `git clone https://github.com/JohnPMcIntyre/Capstone`
3. Open MySQL Workbench and create a database called `mcintyrefitness`
4. Create the Users and Workouts tables using the schema above
5. Open the solution in Visual Studio
6. Build and run the project

---

## GitHub Repository

[https://github.com/JohnPMcIntyre/Capstone](https://github.com/JohnPMcIntyre/Capstone)

---

## Project Demo

[Loom Video Demo 1](https://www.loom.com/share/a4320331fa7d431b912defde0fae3d03)
[Loom Video Demo 2](https://www.loom.com/share/f49a0c1e7e2b48808c1d3b3a49408032)

---

*Grand Canyon University | College of Engineering and Technology | 2026*
