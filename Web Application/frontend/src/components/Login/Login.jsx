import React from "react";
import "./Login.css";

const LoginForm = () => {
    return (
        <div className="login-page">
            <div className="wrapper">
                <form action="">
                    <h1>Login</h1>              

                <div class="input-box">
                     <span class="icon">&#128100;</span> 
                     <input type="text" placeholder="  Username" required />
                </div>

                <div class="input-box">
                    <span class="icon">&#128274;</span> 
                    <input type="password" placeholder="  Password" required />
                </div>

                    <div className="remeber-forgot">
                        <label>
                            <input type="checkbox" /> Remember me
                        </label>
                        <a href="#">Forgot Password?</a>
                    </div>
                    <button type="submit">Login</button>
                    <div className="register-link">
                        <p>
                            Don't have an account? <a href="#">Register</a>
                        </p>
                    </div>
                </form>
            </div>
        </div>
    );
};
export default LoginForm;
