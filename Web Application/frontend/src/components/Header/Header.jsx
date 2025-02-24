import React from 'react';
import { NavLink } from 'react-router-dom';
import { useAuth } from "../../context/AuthContext";
import "./Header.css";

function Header() {
  const { user, logout } = useAuth();

  // Debugging: Log the user object and profile picture
  console.log("User Object:", user);
  console.log("Profile Picture Path:", user?.picture);

  return (
    <header id="header" className="fixed-top header-inner-pages">
      <div className="container d-flex align-items-center justify-content-between">
        <img src="movieHeaven.png" alt="Logo" width="60" height="60" style={{ paddingLeft: "30px" }} />
        <nav id="navbar" className="navbar">
          <ul>
            <li>
              <NavLink 
                to="/" 
                className={({ isActive }) => isActive ? "nav-link active" : "nav-link"}
              >
                Home
              </NavLink>
            </li>
            <li>
              <NavLink 
                to="/movies" 
                className={({ isActive }) => isActive ? "nav-link active" : "nav-link"}
              >
                Movies
              </NavLink>
            </li>
            <li>
              <NavLink 
                to="/about-us" 
                className={({ isActive }) => isActive ? "nav-link active" : "nav-link"}
              >
                About Us
              </NavLink>
            </li>
            <li>
              <NavLink 
                to="/login" 
                className={({ isActive }) => isActive ? "nav-link active" : "nav-link"}
              >
                Log In
              </NavLink>
            </li>
            <li>
              <NavLink 
                to="/contact" 
                className={({ isActive }) => isActive ? "nav-link active" : "nav-link"}
              >
                Contact Us
              </NavLink>
            </li>
          </ul>
        </nav>
        {user && ( 
          <div className="user-profile">
            <img 
              src={user.picture || "/default-profile.png"} 
              alt="Profile" 
              width="40" 
              height="40" 
             
            />
            <button onClick={logout}>Logout</button>
          </div>
        )}
      </div>
    </header>
  );
}

export default Header;