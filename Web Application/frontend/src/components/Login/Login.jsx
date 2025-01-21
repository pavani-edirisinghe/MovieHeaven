import React from "react";
import { Link } from "react-router-dom"; 
import "./Login.css";

const LoginForm = () => {
  return (
    <div className="login-page">
      <div className="wrapper">
        <form action="">
          <h1>Login</h1>
          <div className="input-box">
            <span className="icon">&#128100;</span>
            <input type="text" placeholder="  Username" required />
          </div>
          <div className="input-box">
            <span className="icon">&#128274;</span>
            <input type="password" placeholder="  Password" required />
          </div>
          <div className="remeber-forgot">
              <label>
                <input type="checkbox" /> Remember me
             </label>
             <Link to="/forgot-password">Forgot Password?</Link> 
        </div>
          <button type="submit">Login</button>
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
