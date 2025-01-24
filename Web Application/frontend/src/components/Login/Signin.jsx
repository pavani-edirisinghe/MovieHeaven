import React, { useState } from "react";
import { Link } from "react-router-dom";
import "./Login.css";

const SigninForm = () => {
  const [formData, setFormData] = useState({
    username: "",
    password: "",
    email: "",
  });

  const handleChange = (event) => {
    setFormData({ ...formData, [event.target.name]: event.target.value });
  };

  const handleSubmit = async (event) => {
    event.preventDefault(); 

    try {
      const response = await fetch("http://localhost:5148/signup", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(formData),
      });

      if (response.ok) {
        const data = await response.json();
        alert("Sign-up successful!");
        console.log(data);
      } else {
        alert("Sign-up failed. Please try again.");
      }
    } catch (error) {
      console.error("Error:", error);
      alert("An error occurred. Please try again.");
    }
  };

  return (
    <div className="login-page">
      <div className="wrapper">
        <form onSubmit={handleSubmit}>
          <h1>Sign Up</h1>
          <div className="input-box">
            <span className="icon">&#128100;</span>
            <input
              type="text"
              name="username"
              placeholder="  Username"
              value={formData.username}
              onChange={handleChange}
              required
            />
          </div>
          <div className="input-box">
            <span className="icon">&#128274;</span>
            <input
              type="password"
              name="password"
              placeholder="  Password"
              value={formData.password}
              onChange={handleChange}
              required
            />
          </div>
          <div className="input-box">
            <span className="icon">&#x2709;</span>
            <input
              type="email"
              name="email"
              placeholder="  Email"
              value={formData.email}
              onChange={handleChange}
              required
            />
          </div>
          <button type="submit">Sign Up</button>
          <div className="register-link">
            <p>
              Already have an account?{" "}
              <Link to="/login">Login Here</Link>
            </p>
          </div>
        </form>
      </div>
    </div>
  );
};

export default SigninForm;
