# 🚀 TECHHUB: IT Asset Management & Helpdesk
A comprehensive and streamlined internal IT management dashboard designed to efficiently track hardware inventory, monitor software license expirations, and manage support tickets. Built with a focus on a seamless user experience, the application utilizes asynchronous operations to provide a Single-Page Application (SPA) feel without full page reloads. The dashboard is secured end-to-end with ASP.NET Core Identity — admin registration, login, and session management, an authenticated account area with in-session password change and email-inclusive profile editing, and a token-based forgot-password flow (no outbound email service — the reset token is displayed on-screen for demo purposes) — all implemented consistently with the app's existing AJAX-driven interaction style rather than as bolted-on traditional form posts.

Note: This application was developed as the 5th project for the SoftITo Backend Face-to-Face Training Program.

---

## 🛠️ Technology Stack & Architecture
* Backend Framework: C# / ASP.NET Core MVC
* Architecture: N-Tier Architecture principles
* Database: MS SQL Server
* ORM: Entity Framework Core (Code-First Approach)
* Authentication: ASP.NET Core Identity (EF Core store) — cookie-based authentication, account lockout policy, token-based password reset
* Frontend: HTML5, CSS3, Bootstrap 5.3
* Interactivity: JavaScript, jQuery, AJAX (for dynamic DOM manipulation and seamless CRUD)
* Components: Simple-DataTables (for client-side sorting and pagination), Chart.js

---

## ✨ Key Features

* **Real-Time Dashboard:** A high-level overview of IT operations, featuring calculated metrics like open ticket counts, urgent issues, total hardware tracked, and licenses expiring within 30 days.
* **Hardware Inventory:** Complete Admin CRUD capabilities to track company devices, serial numbers, purchase dates, and auto-calculated warranty statuses.
* **Software Licenses:** Centralized tracking for software seats and license keys. Features dynamic visual indicators for upcoming renewal dates to prevent expiration.
* **Support Tickets:** An integrated helpdesk module for reporting, tracking, and resolving user issues with urgency level indicators.
* **Secure Admin Access:** The entire dashboard is gated behind ASP.NET Core Identity. Covers registration, login, an authenticated password-change screen requiring the current password, a token-based forgot-password recovery path, and a profile page for updating name and email — with feedback for these flows handled inline via AJAX wherever it fits the app's existing interaction pattern.
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


### Identity/Auth Integration
<img width="3069" height="1917" alt="x" src="https://github.com/user-attachments/assets/903becf9-4f21-4287-8a08-8519cb4df2f4" />
<img width="3069" height="1460" alt="y" src="https://github.com/user-attachments/assets/3c08305d-2f7c-421b-af8c-233d0d1acd23" />



---


