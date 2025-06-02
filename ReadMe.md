# Konservatiff Management

## Overview

**Konservatiff Management** is a time-tracking application developed using **Visual Basic** for the user interface and **Microsoft Access** as the back-end database. Designed for educational purposes, this project demonstrates practical implementation of employee time logging, administrative role management, and database-driven reporting.

## Features

- **Employee Clock In/Out**  
  Enables employees to log their working hours through a user-friendly interface.

- **Time Record Management**  
  Provides functionality to view, edit, and manage individual clock-in/out entries.

- **Role-Based Access Control**  
  Administrative page visibility is dynamically controlled based on user roles, ensuring secure and appropriate access to system features.

- **Automated Reporting**  
  Generate detailed reports for attendance tracking and payroll processing.

## Technologies Used

- **Visual Basic (.NET Framework)**
- **Microsoft Access**
- **OleDB** (for database connectivity)

## Getting Started
To get started with Konservatiff Management, simply clone this repository:

```bash
git clone https://github.com/oogx/Konservatiff-Management.git
```

To run the application locally:

1. Open the project in **Visual Studio**.
2. Ensure that **Microsoft Access** is installed on your machine.
3. Build and run the solution.
4. *(Optional)* If you wish to use custom login credentials, modify the `.accdb` database file located in the project's `/bin` directory.

> 💡 *Note: Update the database connection string in the code if the file path (Bin Folder) or Access version differs.*

## Default Credentials

Use the following test accounts to log into the system:

- **Administrator Account**  
  - **MemberID**: `1`  
  - **Password**: `AdminTest`

- **Regular Member Account**  
  - **MemberID**: `2`  
  - **Password**: `RegTest`

## Credits

Project developed by:

- [Joe (Myself)](https://github.com/oogx)  
- [Kieran](https://github.com/Vex1on)  
- [Jacob](https://github.com/Kingy2327)

---

© 2025 Konservatiff Management. All rights reserved. This project is for academic demonstration only.