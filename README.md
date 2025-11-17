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

## **Screenshots**
<img width="514" height="297" alt="image" src="https://github.com/user-attachments/assets/d57b816a-299a-4d07-a8c7-1aa740bc0ac6" />
<img width="913" height="591" alt="image" src="https://github.com/user-attachments/assets/6c2ca640-716c-40fe-93c9-91b1a525d2bd" />
<img width="666" height="423" alt="image" src="https://github.com/user-attachments/assets/602751b7-82bc-4495-8694-17de81eb928f" />
<img width="839" height="401" alt="image" src="https://github.com/user-attachments/assets/827271c3-a209-41e1-9f6a-faf5f6261b3c" />
<img width="671" height="490" alt="image" src="https://github.com/user-attachments/assets/158c6db2-19d9-4ccc-9222-33cbae3ac64c" />
<img width="926" height="755" alt="image" src="https://github.com/user-attachments/assets/72f8dcbe-0b7b-44d5-9477-3ded3f7d40b3" />
<img width="805" height="470" alt="image" src="https://github.com/user-attachments/assets/fa8a33a3-68ab-43e3-9ab4-2400e9c4bb21" />
<img width="1080" height="770" alt="image" src="https://github.com/user-attachments/assets/9a5a5cc7-c9c6-4d75-8556-bea2343c1b11" />
<img width="1521" height="780" alt="image" src="https://github.com/user-attachments/assets/48b669d1-f7b2-4457-bb0c-5e5b47a7a500" />
<img width="839" height="401" alt="image" src="https://github.com/user-attachments/assets/2c2abb17-4011-4e76-8c91-f053bf6ab5ee" />
<img width="839" height="401" alt="image" src="https://github.com/user-attachments/assets/0032db1f-fbbd-4d25-aad4-3d2304d95eb8" />
<img width="1521" height="780" alt="image" src="https://github.com/user-attachments/assets/e5d7020f-915e-4342-ad37-2413cc7b550c" />
<img width="913" height="591" alt="image" src="https://github.com/user-attachments/assets/6a7cd775-2885-4641-8cc9-a540ffbeb23f" />
<img width="680" height="504" alt="image" src="https://github.com/user-attachments/assets/804959c9-e41f-464e-846e-b6668ce4717c" />
<img width="680" height="504" alt="image" src="https://github.com/user-attachments/assets/b83b3494-d1b5-420a-a9df-bf0bb80da11c" />
<img width="797" height="627" alt="image" src="https://github.com/user-attachments/assets/871682e7-19cc-443c-9835-cf24e6e916a0" />
<img width="801" height="770" alt="image" src="https://github.com/user-attachments/assets/b580191c-6d22-45ad-a724-7df3b9f15e11" />
<img width="798" height="543" alt="image" src="https://github.com/user-attachments/assets/45e8a386-8673-41be-8f20-305cbba36510" />
<img width="801" height="630" alt="image" src="https://github.com/user-attachments/assets/8b0c2c28-b64f-49f8-be3b-6c56e41f4d3d" />
<img width="1419" height="760" alt="image" src="https://github.com/user-attachments/assets/a453e50e-842b-4ec5-ae32-165c66c76f48" />
<img width="1493" height="768" alt="image" src="https://github.com/user-attachments/assets/b1ca08b5-7ca9-4b74-a777-bed9185c4164" />
<img width="1495" height="762" alt="image" src="https://github.com/user-attachments/assets/b044bfda-0f97-42d4-a552-cdbb9c0e432e" />
<img width="801" height="608" alt="image" src="https://github.com/user-attachments/assets/987fff68-f17c-4fae-89f3-bb9e367a6d7b" />
<img width="801" height="630" alt="image" src="https://github.com/user-attachments/assets/6008ce76-6d26-4b5e-a1dd-a434801e1dd0" />
<img width="599" height="760" alt="image" src="https://github.com/user-attachments/assets/9d6266c3-f561-4360-9205-4641f0021654" />
<img width="780" height="760" alt="image" src="https://github.com/user-attachments/assets/92acf774-4ee2-4207-a071-699a713a1f1f" />
<img width="1521" height="780" alt="image" src="https://github.com/user-attachments/assets/ff28040b-2c32-4320-b7e8-78ed365c1756" />
<img width="1080" height="770" alt="image" src="https://github.com/user-attachments/assets/3eb3d9a1-9234-4bfe-8983-73d6c4a822b2" />
<img width="1419" height="760" alt="image" src="https://github.com/user-attachments/assets/ee1756ae-6030-4b40-a892-b28394d5f34d" />
<img width="927" height="756" alt="image" src="https://github.com/user-attachments/assets/5ba8789d-0cb3-4b36-935d-90f7f5ba1504" />



























