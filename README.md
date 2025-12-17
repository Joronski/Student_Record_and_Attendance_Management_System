# Student Record and Attendance Management System

**ITP104 Final Project - Group 2**

## Project Information

**Submitted by:**
- Alvarez, Kian Clark
- Algara, Andrie
- Cantalejo, Bless Real
- Catchuela, John Eric
- Dela Cruz, Kim Francis
- Demonteverde, Francis
- Dela Torre, Markanthony
- Mateo, John Henrics
- Molinyawe, Russel
- Recio, Joaquin Aaron
- Rosario, Al-jay

**Submitted to:** Dr. Maria Crystal E. Orozco  
**Date:** December 7, 2025

---

## Introduction

The Student Record and Attendance Management System is an application that helps organize and manage student information in one centralized location. Built with C# and MySQL, it enables users to scan forms, check student programs, view scan history, and configure settings through an intuitive dashboard. This system streamlines student record management, reduces errors, and provides schools with an efficient data management solution.

---

## Features

### 1. Login Form
Secure authentication system for authorized access.

<img width="506" height="711" alt="image" src="https://github.com/user-attachments/assets/43dfbd2a-3d35-4114-8366-78649900715e" />

**How to use:**
1. Open the system
2. Enter username and password
3. Click Login

**Expected Result:** Dashboard opens after successful authentication.

---

### 2. Dashboard
Central hub providing quick access to all system modules.

<img width="940" height="490" alt="image" src="https://github.com/user-attachments/assets/a2438761-f989-4473-a8b7-3417b624864e" />

**Features:**
- Summary panels showing:
  - Today's Attendance
  - Total Users
  - Absent Today
- Sidebar navigation to:
  - Scan Form
  - Student Records
  - Scan History
  - Settings
- Data grid displaying detailed student records and recent attendance logs

---

### 3. Scan Screen
QR code scanning interface for attendance tracking.

**Purpose:** Scan QR codes to automatically mark student attendance.

**Components:**
- **QR Picture Box:** Displays scanned QR code image with centered, auto-adjusting layout
- **Attendance Button:** Processes QR code to record attendance (DeepSkyBlue styling)
- **Back Button:** Returns to previous screen (Gray styling)

**Usage Flow:**
1. Open the Scan Form
2. Scan QR code (displayed in picture box)
3. Click Attendance to record the scan
4. Click Back to return to previous form

<img width="602" height="422" alt="image" src="https://github.com/user-attachments/assets/d44f6ba9-5d36-4e40-b6e4-3bbf30956715" />
<img width="603" height="388" alt="image" src="https://github.com/user-attachments/assets/eed1b8f1-db7d-4d9a-bb36-fdf6a3084f90" />

---

### 4. Scan History Screen
View and manage historical attendance records.

**Purpose:** Access comprehensive logs of all attendance activities.

**Components:**
- **Data Table:** Read-only grid displaying all scanned attendance records
  - Auto-adjusting columns
  - Center-aligned rows
  - Cell click support for details
- **Refresh Button:** Reloads data from database
- **Back Button:** Returns to Dashboard

**Usage Flow:**
1. Open Scan History form
2. View all past scan records in the table
3. Use Refresh to load new entries
4. Click Back to return to dashboard

<img width="700" height="489" alt="image" src="https://github.com/user-attachments/assets/d422baaa-5483-4641-b8ff-38f310a6e1fb" />

---

### 5. Student Record Screen
Comprehensive student information management interface.

**Components:**

**Input Panel:**
- Input fields: Name, Student ID, Score, Grade
- Action buttons:
  - **Submit:** Saves student information
  - **Back:** Returns to previous menu
  - **View Record:** Opens table view
- LightSteelBlue background styling

**Table Panel:**
- Read-only DataGridView showing all student records
- **Return** button to switch back to input panel
- Initially hidden, activated via View Record button

**Usage Flow:**
1. Open Student Record Form
2. Enter student information in input fields
3. Click Submit to save data
4. Click View Record to see all students in table view
5. Click Return to go back to input form
6. Click Back to close or return to main menu

<img width="895" height="552" alt="image" src="https://github.com/user-attachments/assets/b52e0c14-1b71-42da-a254-5f59aa0290f9" />
<img width="808" height="500" alt="image" src="https://github.com/user-attachments/assets/f0064c79-8ec2-4c79-a384-7b4fa467e4c4" />

---

### 6. Settings Screen
Comprehensive application configuration interface.

**Purpose:** Customize and manage system settings.

**Navigation Categories:**
- System/General Settings
- Scan Settings
- Date and Records
- Notification
- Security and Privacy

**Action Buttons:**
- **System:** General system settings
- **Language:** Language configuration
- **Appearance:** Theme and UI settings
- **File Location:** Default file save locations
- **Date and Time:** System date/time configuration

**Layout:**
- Left panel (DimGray) for category navigation
- Top panel (ControlDark) with title and back button
- Right side action buttons with proper spacing

**Usage Flow:**
1. Open Settings Form
2. Select category from left panel
3. Modify settings using respective buttons
4. Click Back to return to previous menu

<img width="794" height="520" alt="image" src="https://github.com/user-attachments/assets/25c0f096-08aa-42ca-b5bb-040e300ad9f8" />

---

## System Requirements

### Software
- Visual Studio (with .NET Desktop Development)
- XAMPP
- MySQL

### Dependencies
- MySQL.Data
- .NET Framework

---

## Installation Guide

### Step-by-Step Setup

1. **Install Visual Studio**
   - Select .NET Desktop Development workload during installation

2. **Install XAMPP**
   - Start Apache and MySQL services

3. **Import Database**
   - Open phpMyAdmin
   - Import the database backup (.sql file)

4. **Open Project**
   - Launch Visual Studio
   - Open the solution file (.sln)

5. **Configure Database Connection**
   
   Update the connection string in the code:
   
   **For default users:**
   ```csharp
   con = "Server=localhost;Port=3306;Database=student_db;User=root;Password=;";
   ```
   
   **For custom port users:**
   ```csharp
   con = "Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;";
   ```

---

## Database Schema

### Final ERD

<img width="857" height="658" alt="image" src="https://github.com/user-attachments/assets/f2f6e5ea-4e7d-4a95-9a11-e1a8b9a08c9d" />

### Entities

#### 1. StudentsAccount
Stores student login credentials.
- `id` (Primary Key)
- `student_id`
- `password`
- `name`

#### 2. Students
Stores academic information.
- `student_number` (Primary Key)
- `name`
- `score`
- `grade`
- `student_id` (Foreign Key)

#### 3. ScanHistory
Logs student transactions/events.
- `history_id` (Primary Key)
- `datetime`
- `transaction`
- `student_id` (Foreign Key)

### Relationships

- **StudentsAccount to Students:** One-to-One (1:1) based on `student_id`
  - One account corresponds to one academic profile

- **StudentsAccount to ScanHistory:** One-to-Many (1:M) based on `student_id`
  - One student can have many scan records

---

## Support

For issues or questions, please contact the development team or your system administrator.

---

## License

This project is developed as part of the ITP104 course requirements.