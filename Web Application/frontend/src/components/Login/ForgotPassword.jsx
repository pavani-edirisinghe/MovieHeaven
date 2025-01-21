import React, { useState } from "react";
import { Link } from "react-router-dom";
import "./Login.css"; 

const ForgotPassword = () => {
  const [username, setUsername] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [errorMessage, setErrorMessage] = useState("");
  const [successMessage, setSuccessMessage] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();
    setErrorMessage(""); 

    if (newPassword !== confirmPassword) {
      setErrorMessage("Passwords do not match!");
      return;
    }

    try {
      const response = await fetch("/api/reset-password", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ username, newPassword }),
      });

      if (response.ok) {
        setSuccessMessage("Your password has been reset successfully.");
      } else {
        setErrorMessage("Failed to reset password. Please try again.");
      }
    } catch (error) {
      setErrorMessage("An error occurred. Please try again later.");
    }
  };

  return (
    <div className="login-page"> 
      <div className="wrapper"> 
        <form onSubmit={handleSubmit}>
          <h1>Reset Password</h1>
          <p>Enter your details to reset your password.</p>

          <div className="input-box">
            <span className="icon">&#128100;</span>
            <input
              type="text"
              placeholder="  Username"
              required
              value={username}
              onChange={(e) => setUsername(e.target.value)}
            />
          </div>

          <div className="input-box"> 
            <span className="icon">&#128274;</span>
            <input
              type="password"
              placeholder="  New Password"
              required
              value={newPassword}
              onChange={(e) => setNewPassword(e.target.value)}
            />
          </div>

          <div className="input-box"> 
            <span className="icon">&#128274;</span>
            <input
              type="password"
              placeholder="  Confirm Password"
              required
              value={confirmPassword}
              onChange={(e) => setConfirmPassword(e.target.value)}
            />
          </div>

          {errorMessage && <p className="error-message">{errorMessage}</p>} 

          {successMessage && <p className="success-message">{successMessage}</p>} 

          <button type="submit">Reset Password</button> 

          <div className="register-link"> 
            <p>
              Remember your password?{" "}
              <Link to="/login">Login Here</Link>
            </p>
          </div>
        </form>
      </div>
    </div>
  );
};

export default ForgotPassword;
