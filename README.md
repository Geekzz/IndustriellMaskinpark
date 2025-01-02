# Övning 17 – Industriellmaskinpark Management System

## **Project Overview**
This project is a Blazor Web App designed to serve as a **Management System** for a fictional industrial machinery park. It is targeted toward **support technicians** who will use the system to administer and monitor the machinery. The application provides real-time data about the machines, enables machine control, and includes essential statistics.

---

## **Features**

### **Frontend (Blazor Web App)**
1. **DeviceList Component (list of machines)**:
   - Displays a list of all industrial machines.
   - Includes:
     - Machine ID (GUID)
     - Location
     - Last updated
     - Machine type
     - Current Status (Online/Offline)

2. **DailyStats Component**:
   - A constantly visible component that displays machine park statistics:
     - Total number of machines.
     - Number of online machines.
     - Information about the last edited machine.

3. **Navbar**:
   - Features a company logo.
   - Provides navigation links to the machine list.

---

### **Backend Functionality**
The system includes backend functionality to handle machine operations:
- **Fetch and Display Machines**: Retrieve all machines and their data.
- **Start/Stop Machines**: Control the operational status of individual machines.
- **Update Machine Data**: Simulate updating machine data.
- **Add/Remove Machines**: Manage the machine list by adding or deleting entries.

---
