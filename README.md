# **Driving License Management Desktop App**

## **Project Overview**

The **Driving License Management Desktop App** is a **C#-based desktop application** designed to streamline the management of driving licenses, including applications, approvals, tracking, and test scheduling. The system ensures efficient record-keeping, user authentication, and compliance with licensing regulations. It integrates a **business logic layer** and **database support** for secure and scalable operation.

## **Key Features**

### **1. License Application & Issuance**

- Supports **local** and **international** driving license applications.
- Processes and verifies submitted applications.
- Manages different **license classes** and **license types**.

### **2. Driver & License Management**

- Stores and retrieves **driver information** including personal details and driving history.
- Tracks **issued licenses**, ensuring validity and renewals.
- Handles **detained and revoked licenses**.

### **3. Driving Test Scheduling & Management**

- **clsTest.cs** – Manages test records for license applicants.
- **clsTestAppointment.cs** – Handles test scheduling and appointments.
- **clsTestType.cs** – Differentiates test types (e.g., written test, driving test).
- Users can **schedule tests** and track results within the system.

### **4. Role-Based Access Control**

- **Administrators** can approve/reject applications and schedule tests.
- **Applicants** can submit applications, schedule tests, and track progress.
- **Secure authentication** for user access.

### **5. User Management**

- **clsUser.cs** – Manages user authentication and access roles.
- Supports **multi-user access** with different privilege levels.

### **6. Database Integration**

- Uses a **structured relational database** (SQL Server) for secure data storage.
- Implements **CRUD operations** for efficient license and user management.

### **7. Graphical User Interface (GUI)**

- Developed using **WinForms** or **WPF** for an interactive desktop experience.
- Provides an intuitive interface for both **applicants** and **administrators**.

---

## **Project Structure**

The project is organized into multiple layers with Database for maintainability and scalability.

### **1. Database Design**

![Database Design](https://github.com/AhmedEmadh/Driving-License-Management-Desktop-App/blob/main/Database-Design/DrivingLicenseManagementDatabase.drawio.png)

### **2. Data Access Layer**

- Implements structured **SQL database tables**.
- Ensures **data security** and **efficient retrieval**.

### **3. Business Logic Layer (`Driving-License-Management-BusinessLogic`)**

Contains classes for managing core functionalities:

- `clsApplication.cs` – Handles license applications.
- `clsApplicationType.cs` – Defines application types.
- `clsCountry.cs` – Stores country details for international licenses.
- `clsDetainedLicense.cs` – Tracks revoked or detained licenses.
- `clsDriver.cs` – Manages driver information.
- `clsInternationalLicense.cs` – Handles international driving licenses.
- `clsLicense.cs` – Core class for managing licenses.
- `clsLicenseClass.cs` – Manages different classes of licenses.
- `clsLocalDrivingLicenseApplication.cs` – Manages local applications.
- `clsPerson.cs` – Stores applicant information.
- `clsTest.cs` – Manages test details.
- `clsTestAppointment.cs` – Handles test scheduling.
- `clsTestType.cs` – Differentiates test categories.
- `clsUser.cs` – Manages authentication and user roles.

### **4. User Interface Layer**

- Provides **separate UI components** for applicants and administrators.
- Includes interactive forms for **applications, approvals, and test scheduling**.

## **Installation & Setup**

### **Requirements**

- **Windows OS**
- **.NET Framework**
- **SQL Server**
- **Visual Studio**

### **Steps to Run the Application**

1. Clone or download the project.
2. Open the solution (`.sln`) in **Visual Studio**.
3. Configure the **database connection**.
4. Build and run the application.

## **Future Enhancements**

- Add **online test result tracking**.
- Introduce **automated email/SMS notifications**.
- Expand to a **web-based platform**.


