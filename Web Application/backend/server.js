const express = require("express");
const mysql = require("mysql");
const cors = require("cors");
const multer = require("multer");
const path = require("path");
const fs = require("fs");

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

const uploadDir = path.join(__dirname, "uploads");
if (!fs.existsSync(uploadDir)) {
  fs.mkdirSync(uploadDir);
}


const storage = multer.diskStorage({
  destination: function (req, file, cb) {
    cb(null, "uploads/"); 
  },
  filename: function (req, file, cb) {
    cb(null, Date.now() + path.extname(file.originalname)); 
  },
});

const upload = multer({ storage: storage });

app.post('/signup', upload.single('picture'), (req, res) => {
  const { username, email, password } = req.body;
  const picture = req.file ? `http://localhost:5148/uploads/${req.file.filename}` : null;

  const sql = "INSERT INTO login (username, email, password, picture) VALUES (?, ?, ?, ?)";
  db.query(sql, [username, email, password, picture], (err, result) => {
    if (err) {
      console.error(err);
      return res.status(500).json({ message: "Database error" });
    }
    return res.status(201).json({ message: "User created successfully", userId: result.insertId });
  });
});

app.use('/uploads', express.static(path.join(__dirname, 'uploads')));

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
        return res
          .status(200)
          .json({ message: "Login successful", user: data[0] });
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

app.get("/api/booked-seats", (req, res) => {
  const { movieTitle, showtime, selectedDate } = req.query;

  const sql = `
    SELECT seats 
    FROM movie_booking.bookings 
    WHERE movie_title = ? 
      AND showtime = ? 
      AND selected_date = ? 
      AND payment_status = 'paid'
  `;
  db.query(sql, [movieTitle, showtime, selectedDate], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).json({ message: "Database error" });
    }

    const bookedSeats = results.flatMap(booking => JSON.parse(booking.seats));
    return res.status(200).json({ bookedSeats });
  });
});

app.post("/api/bookings", (req, res) => {
  const { movieTitle, showtime, selectedDate, seats, totalPrice } = req.body;

  console.log("Received Date (Backend):", selectedDate);

  const dateRegex = /^\d{4}-\d{2}-\d{2}$/;
  if (!dateRegex.test(selectedDate)) {
    return res.status(400).json({ message: "Invalid date format. Use YYYY-MM-DD." });
  }

  const sql = `
    INSERT INTO movie_booking.bookings 
      (movie_title, showtime, selected_date, seats, total_price, payment_status) 
    VALUES (?, ?, ?, ?, ?, 'paid')
  `;
  const values = [movieTitle, showtime, selectedDate, JSON.stringify(seats), totalPrice];

  db.query(sql, values, (err, result) => {
    if (err) {
      console.error(err);
      return res.status(500).json({ message: "Database error" });
    }
    return res.status(201).json({ message: "Booking created successfully", bookingId: result.insertId });
  });
});

app.listen(5148, () => {
  console.log("Server is running on port 5148");
});