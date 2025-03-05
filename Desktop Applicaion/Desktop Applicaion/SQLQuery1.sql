﻿DROP TABLE IF EXISTS users;

CREATE TABLE users
(
   id INT PRIMARY KEY IDENTITY(1,1),
   username VARCHAR(MAX) NULL,
   password VARCHAR(MAX) NULL,
   role VARCHAR(MAX) NULL,
   status VARCHAR(MAX) NULL,
   date_reg DATE NULL
);

SELECT * FROM users;
TRUNCATE TABLE users;

INSERT INTO users (username, password, role, status, date_reg) 
VALUES ('admin', 'admin123', 'Admin', 'Active', '2024-12-28');

SELECT * FROM users WHERE role = 'Staff'


