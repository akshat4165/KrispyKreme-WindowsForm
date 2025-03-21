# KrispyKreme

### Add MySQL Database in Visual Studio, follow these steps:

1. Click on Tools in the top menu > NuGet Package Manager > Manage NuGet Packages for Solution.
2. In the Browse tab, search for MySql.Data.
3. Click Install on the latest version of MySql.Data by Oracle.

### Change the uid and pwd in the DatabaseHelper.cs according to your database id and password.
```
private static string connectionString = "server=localhost;database=krispykreme;uid=root;pwd=1234;";
```
### Create Database and Tables in MySQL Database using the below commands:

```
CREATE DATABASE krispykreme;
USE krispykreme;
```

```
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL  -- Store hashed passwords for security
);

CREATE TABLE bills (
    id INT AUTO_INCREMENT PRIMARY KEY,
    customer_name VARCHAR(100) NOT NULL,
    phone_number VARCHAR(10) NOT NULL,
    items TEXT NOT NULL,
    total_price DECIMAL(10,2) NOT NULL,
    discount DECIMAL(10,2) NOT NULL,
    final_price DECIMAL(10,2) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
```
## Screenshots

![image_2025-03-14_032700866](https://github.com/user-attachments/assets/ab0f0d52-2cd4-4a6b-add7-f75fe070ed0e)

![image_2025-03-14_032851790](https://github.com/user-attachments/assets/09923365-f30e-404d-9363-17536bc753db)

![image_2025-03-14_033004364](https://github.com/user-attachments/assets/825e5e58-f657-4feb-b683-c868f13cb154)

![image_2025-03-14_033110481](https://github.com/user-attachments/assets/8bc18c9f-3445-40b1-aaa9-0c7cfc1e2b12)

