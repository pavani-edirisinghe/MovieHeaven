import React from "react";
import { Link } from "react-router-dom"; 
import "./Login.css";

const SigninForm = () => {
  return (
    <div className="login-page">
      <div className="wrapper">
        <form action="">
          <h1>Sign Up</h1>
          <div className="input-box">
            <span className="icon">&#128100;</span>
            <input type="text" placeholder="  Username" required />
          </div>
          <div className="input-box">
            <span className="icon">&#128274;</span>
            <input type="password" placeholder="  Password" required />
          </div>
          <div className="input-box">
            <span className="icon">&#x2709;</span>
            <input type="email" placeholder="  Email" required />
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
