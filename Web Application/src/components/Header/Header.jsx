import React, { useState } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./Header.css";
import About from "../About/About.jsx";
import Contact from "../About/About.jsx";

function Header() {
  const [isActive, setIsActive] = useState(false);

  const toggleMenu = () => {
    setIsActive(!isActive);
  };

  return (
    <header id="header" className="fixed-top header-inner-pages">
      <div className="container d-flex align-items-center justify-content-between">
    
          <img src="movieHeaven.png" alt="Logo" width="60" height="60" padding-left= "30px" />
        <nav id="navbar" className="navbar">
          <ul>
            <li><a className="nav-link scrollto" href="index.html">Home</a></li>
            <li><a className="nav-link scrollto" to="/about">Movies</a></li>
            <li><a className="nav-link scrollto" href="About.jsx">About Us</a></li>           
            <li><a className="nav-link scrollto" href="index.html">Log In</a></li>
            <li><a className="nav-link scrollto" href="index.html">Contact Us</a></li>
          </ul>
        </nav>
      </div>
    </header>
  );
}

export default Header;
