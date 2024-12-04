# Apartment Management System - Windows Forms Application

## Overview
The **Apartment Management System (AMS)** is a Windows Forms application designed to help property managers efficiently manage tenant profiles, rent payments, maintenance requests, and leases for apartment complexes. The application provides a user-friendly interface that simplifies administrative tasks and ensures smooth operations for property managers.

---

## Features
- **Tenant Profile Management**:
  - Add, edit, and delete tenant information, including personal details, contact information, and apartment assignment.
- **Rent Payment Management**:
  - Record rent payments, track outstanding balances, and generate payment history.
  - Option to mark payments as received and generate payment receipts.
- **Lease Management**:
  - Manage lease agreements by recording start and end dates, rental amounts, and lease renewal information.
  - Track lease expiration dates and send reminders for renewals.
- **Maintenance Request Tracking**:
  - Tenants can submit maintenance requests, which can be tracked and managed by property managers.
  - Set request statuses (e.g., Pending, In Progress, Completed).
- **Reports**:
  - Generate reports for payments, tenant balances, maintenance requests, and lease renewals.
- **User Authentication**:
  - Admin login to access the system, ensuring that only authorized users can manage tenant data and payments.

---

## Prerequisites

Before running the application, ensure you have the following software installed:

- **Microsoft Visual Studio 2019** or later.
- **.NET Framework 4.8** or later.
- **SQL Server** (or SQL Server Express) for database storage.

---

## Installation

### 1. Clone or Download the Repository
Clone the repository using Git or download the ZIP file:

```bash
git clone https://github.com/yourusername/ApartmentManagementSystem.git
```

2. Open the Project in Visual Studio
Open Visual Studio.
Select Open Project from the Start page or navigate to File > Open > Project/Solution.
Open the ApartmentManagementSystem.sln file from the project folder.
3. Set Up the Database
Open the App.config file located in the root of the project.
Modify the connectionString to reflect your local SQL Server settings:
Example:

xml
Copy code
<connectionStrings>
    <add name="ApartmentManagementSystemContext" 
         connectionString="Data Source=localhost;Initial Catalog=ApartmentDB;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
Create the database schema by running the SQL scripts provided in the Database folder (if available) or allow the application to generate the schema on the first run.
4. Build and Run the Application
Press Ctrl + Shift + B to build the solution.
Press F5 or click the Start button to run the application.
Usage
Once the application is running, you can manage tenants, payments, leases, and maintenance requests through the following features:

1. Manage Tenant Profiles
Go to the Tenant Management section to add, update, or remove tenant information.
Add details such as name, contact information, assigned apartment, and lease duration.
2. Track Rent Payments
Record and track rent payments under the Payment Management tab.
View outstanding balances and payment history for each tenant.
Mark rent payments as completed and issue receipts when needed.
3. Lease Management
Under Lease Management, you can view and manage lease agreements.
Track lease start and end dates and mark leases for renewal.
Get notifications for upcoming lease expirations.
4. Maintenance Requests
Tenants can submit maintenance requests through the Maintenance Requests tab.
Property managers can view, prioritize, and track the status of each request (e.g., Pending, In Progress, Completed).
5. Reports
Generate detailed reports on rent payments, pending maintenance requests, and lease expirations.
Reports can be exported for further analysis or record-keeping.
Technologies Used
C#: Programming language for the application.
Windows Forms: For creating the user interface.
SQL Server: Database management system.
Entity Framework: Object-Relational Mapper (ORM) for database operations.
Crystal Reports (Optional): For advanced reporting features (if integrated).

Known Issues
Database Configuration: Ensure that the database connection string is correct; otherwise, the app may fail to connect to the database.
User Roles: At this stage, the system supports only admin authentication. Tenant access can be considered for future versions.
Real-time Updates: Maintenance request status updates may require a page refresh.
Future Enhancements
Tenant Portal: Allow tenants to log in and view their rent payments, maintenance requests, and lease information.
Notifications: Send email or SMS reminders for rent payments and lease renewals.
Mobile App: Develop a mobile version for property managers to access and manage tenant data on the go.
Multiple User Roles: Introduce more user roles, such as property managers, maintenance staff, and tenants.

Contact
For issues, feature requests, or contributions, please open an issue on the GitHub repository or contact us at dharmendrasoni2005@gmail.com.

Acknowledgements
Microsoft for providing the development tools (Visual Studio, SQL Server, .NET Framework).
Stack Overflow and the GitHub community for their support and contributions during development.
