const express = require("express");
const mysql = require("mysql");
const cors = require("cors");

const app = express();
app.use(cors());
app.use(express.json()); 

const db = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "signup", 
});

db.connect((err) => {
  if (err) {
    console.error("Error connecting to database:", err);
    process.exit(1);
  }
  console.log("Database connected successfully!");
});

app.post("/signup", (req, res) => {
  const { username, password, email } = req.body;

  const sql = "INSERT INTO login (username, password, email) VALUES (?, ?, ?)";
  const values = [username, password, email]; 

  db.query(sql, values, (err, data) => {
    if (err) {
      console.error(err);
      return res.status(500).json({ message: "Database error" });
    }
    return res.status(201).json({ message: "User created successfully", data });
  });
});

app.post("/login", (req, res) => {
  const { username, password } = req.body;

  const sql = "SELECT * FROM login WHERE username = ?";
  db.query(sql, [username], (err, data) => {
    if (err) {
      console.error(err);
      return res.status(500).json({ message: "Database error" });
    }

    if (data.length > 0) {
      if (data[0].password === password) { 
        return res.status(200).json({ message: "Login successful", user: data[0] });
      } else {
        return res.status(401).json({ message: "Invalid username or password" });
      }
    } else {
      return res.status(401).json({ message: "Invalid username or password" });
    }
  });
});

app.post("/api/reset-password", (req, res) => {
  const { username, newPassword } = req.body;

  const userQuery = "SELECT * FROM login WHERE username = ?";
  db.query(userQuery, [username], (err, result) => {
    if (err) return res.status(500).json({ message: "Database error" });
    if (result.length === 0)
      return res.status(404).json({ message: "Username not found" });

    const updateQuery = "UPDATE login SET password = ? WHERE username = ?";
    db.query(updateQuery, [newPassword, username], (err, result) => {
      if (err) return res.status(500).json({ message: "Database error" });
      return res.status(200).json({ message: "Password reset successfully" });
    });
  });
});

app.use('/api/booking', bookingRoutes);

// Start the server
app.listen(5148, () => {
  console.log("Server is running on port 5148");
});
