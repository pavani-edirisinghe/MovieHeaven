import { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./App.css";

import ScrollToTop from "./components/ScrollToTop"; 

import Header from "./components/Header/Header.jsx";
import HeroSection from './components/Hero/Hero.jsx';
import AboutSection from './components/About/About.jsx';
import ContactSection from './components/Contact/Contact.jsx';
import MoviesSection from './components/MovieDescription/MovieGallery.jsx';
import MovieDetails from './components/MovieDescription/MovieDetails.jsx';
import Footer from './components/Footer/Footer.jsx';

import 'boxicons/css/boxicons.min.css';
import 'font-awesome/css/font-awesome.min.css';
import 'remixicon/fonts/remixicon.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'

function App() {

  return (
    
    <Router>
      <ScrollToTop />
      <Header/>
      <Routes>
      <Route path="/" element={<HeroSection />} />
        <Route path="/about-us" element={<AboutSection />} />
        <Route path="/contact" element={<ContactSection />} />
        <Route path="/movies" element={<MoviesSection />} />
        <Route path="/movies/:movieId" element={<MovieDetails />} />

     
      </Routes>
     
      <Footer/>
      </Router>

      
  
  );
}

export default App;
