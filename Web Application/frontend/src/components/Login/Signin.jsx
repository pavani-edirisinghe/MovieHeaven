import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "./Login.css";

const SigninForm = () => {
  const [formData, setFormData] = useState({
    username: "",
    password: "",
    email: "",
    picture: null,
  });

  const [isSubmitting, setIsSubmitting] = useState(false);
  const navigate = useNavigate();

  const handleChange = (event) => {
    if (event.target.name === "picture") {
      const file = event.target.files[0];
      if (file) {
        // Validate file type
        if (!file.type.startsWith("image/")) {
          alert("Please upload an image file.");
          return;
        }
        // Validate file size (e.g., 5MB limit)
        if (file.size > 5 * 1024 * 1024) {
          alert("File size must be less than 5MB.");
          return;
        }
        setFormData({ ...formData, picture: file });
      }
    } else {
      setFormData({ ...formData, [event.target.name]: event.target.value });
    }
  };

  const handleSubmit = async (event) => {
    event.preventDefault();
    setIsSubmitting(true);

    const formDataToSend = new FormData();
    formDataToSend.append("username", formData.username);
    formDataToSend.append("password", formData.password);
    formDataToSend.append("email", formData.email);
    formDataToSend.append("picture", formData.picture);

    try {
      const response = await fetch("http://localhost:5148/signup", {
        method: "POST",
        body: formDataToSend,
      });

      if (response.ok) {
        const data = await response.json();
        alert("Sign-up successful!");
        navigate("/login");
      } else {
        const errorData = await response.json();
        alert(`Sign-up failed: ${errorData.message || "Please try again."}`);
      }
    } catch (error) {
      console.error("Error:", error);
      alert("An error occurred. Please try again.");
    } finally {
      setIsSubmitting(false);
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
          <div className="input-box file-input">
            <span className="icon">&#128248;</span>
            <label htmlFor="picture" className="custom-file-input">
              Add Image
            </label>
            <input
              type="file"
              id="picture"
              name="picture"
              onChange={handleChange}
              required
            />
            <span>
              {formData.picture ? formData.picture.name : "\u00A0No file chosen\u00A0"}
            </span>
          </div>
          <button type="submit" disabled={isSubmitting}>
            {isSubmitting ? "Signing Up..." : "Sign Up"}
          </button>
          <div className="register-link">
            <p>
              Already have an account? <Link to="/login">Login Here</Link>
            </p>
          </div>
        </form>
      </div>
    </div>
  );
};

export default SigninForm;