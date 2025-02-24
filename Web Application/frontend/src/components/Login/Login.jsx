import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "./Login.css";
import axios from "axios";
import { useAuth } from "../../context/AuthContext";

const LoginForm = () => {
  const [formData, setFormData] = useState({ username: '', password: '' });
  const [errorMessage, setErrorMessage] = useState('');
  const [successMessage, setSuccessMessage] = useState('');
  const { login } = useAuth(); // Use the login function from AuthContext
  const navigate = useNavigate();

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post('http://localhost:5148/login', formData);
      login(response.data.user); // Update the AuthContext with the logged-in user
      localStorage.setItem("isLoggedIn", "true"); // Store login status in localStorage
      setSuccessMessage(response.data.message);
      setErrorMessage('');
      navigate('/'); // Redirect to home page after successful login
    } catch (error) {
      setErrorMessage(error.response?.data?.message || 'Login failed');
      setSuccessMessage('');
    }
  };

  return (
    <div className="login-page">
      <div className="wrapper">
        <form onSubmit={handleSubmit}>
          <h1>Login</h1>
          <div className="input-box">
            <span className="icon">&#128100;</span>
            <input
              type="text"
              name="username"
              placeholder="Username"
              value={formData.username}
              onChange={handleInputChange}
              required
            />
          </div>
          <div className="input-box">
            <span className="icon">&#128274;</span>
            <input
              type="password"
              name="password"
              placeholder="Password"
              value={formData.password}
              onChange={handleInputChange}
              required
            />
          </div>
          <div className="remeber-forgot">
            <label>
              <input type="checkbox" /> Remember me
            </label>
            <Link to="/forgot-password">Forgot Password?</Link>
          </div>
          <button type="submit">Login</button>
          {errorMessage && <p className="error">{errorMessage}</p>}
          {successMessage && <p className="success">{successMessage}</p>}
          <div className="register-link">
            <p>
              Don't have an account?{" "}
              <Link to="/sign-up">Register Here</Link>
            </p>
          </div>
        </form>
      </div>
    </div>
  );
};

export default LoginForm;