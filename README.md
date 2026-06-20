# 🚀 TECHHUB: IT Asset Management & Helpdesk

A comprehensive and streamlined internal IT management dashboard designed to efficiently track hardware inventory, monitor software license expirations, and manage support tickets. Built with a focus on a seamless user experience, the application utilizes asynchronous operations to provide a Single-Page Application (SPA) feel without full page reloads.

> **Note:** This application was developed as the 5th project for the **SoftITo Backend Face-to-Face Training Program**.

---

## 🛠️ Technology Stack & Architecture

* **Backend Framework:** C# / ASP.NET Core MVC
* **Architecture:** N-Tier Architecture principles
* **Database:** MS SQL Server
* **ORM:** Entity Framework Core (Code-First Approach)
* **Frontend:** HTML5, CSS3, Bootstrap 5.3
* **Interactivity:** JavaScript, jQuery, AJAX (for dynamic DOM manipulation and seamless CRUD)
* **Components:** Simple-DataTables (for client-side sorting and pagination), Chart.js 

---

## ✨ Key Features

* **Real-Time Dashboard:** A high-level overview of IT operations, featuring calculated metrics like open ticket counts, urgent issues, total hardware tracked, and licenses expiring within 30 days.
* **Hardware Inventory:** Complete Admin CRUD capabilities to track company devices, serial numbers, purchase dates, and auto-calculated warranty statuses.
* **Software Licenses:** Centralized tracking for software seats and license keys. Features dynamic visual indicators for upcoming renewal dates to prevent expiration.
* **Support Tickets:** An integrated helpdesk module for reporting, tracking, and resolving user issues with urgency level indicators.
* **SPA-Like Experience:** All Create, Read, Update, and Delete (CRUD) operations are handled via asynchronous jQuery AJAX calls and Bootstrap Modals, ensuring the user never loses their place or context.

---

## 📸 Screenshots

### Dashboard Overview
<img width="3069" height="1917" alt="1" src="https://github.com/user-attachments/assets/19498b4d-767b-4dbc-a4f2-24fdf460f06f" />


### Hardware Inventory Management
<img width="3069" height="1917" alt="2" src="https://github.com/user-attachments/assets/6c5836cb-c60d-4e3d-aa45-1e669d902dc1" />


### Interactive CRUD Modals (Software Licenses)
<img width="3069" height="1917" alt="3" src="https://github.com/user-attachments/assets/819b8797-c866-41e3-a5a0-06ca6b088191" />


### Support Tickets Helpdesk
<img width="3069" height="1917" alt="4" src="https://github.com/user-attachments/assets/1679bd9a-9db0-4823-a1be-bf0d9f51550c" />


---

## 🗺️ Roadmap & Upcoming Features

The following features are planned for the next iteration of the project to enhance security and reporting capabilities:

* **Authentication & Authorization:** Integration of ASP.NET Core Identity for secure Login and Sign-up flows.
* **Role-Based Access Control (RBAC):** Defining specific permissions for System Administrators versus Standard Users.
* **Data Export:** Functionality to download table data (hardware, licenses, and tickets) into PDF and Excel formats for external reporting.

---

## 💻 Installation & Setup

1. Clone the repository to your local machine.
2. Open the solution file (`TECHHUB.sln`) in Visual Studio.
3. Open the `appsettings.json` file and verify your MS SQL Server connection string.
4. Open the Package Manager Console (PMC) and run the following command to generate the database schema via Code-First migrations:
   ```bash
   Update-Database
