import { useState } from 'react'
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./App.css";

import Header from "./components/Header/Header.jsx";
import HeroSection from './components/Hero/Hero.jsx';
import AboutSection from './components/About/About.jsx';
import ContactSection from './components/Contact/Contact.jsx';
import Footer from './components/Footer/Footer.jsx';
import MovieGallery from "./components/MovieDescription/MovieGallery.jsx";  // Import MovieGallery component
import MovieDetails from "./components/MovieDescription/MovieDetails.jsx";  // Import MovieDetails component

import 'boxicons/css/boxicons.min.css';
import 'font-awesome/css/font-awesome.min.css';
import 'remixicon/fonts/remixicon.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'

function App() {

  return (
    
    <Router>
      <Header/>
      <Routes>
      <Route path="/" element={<HeroSection />} />
        <Route path="/about-us" element={<AboutSection />} />
        <Route path="/contact" element={<ContactSection />} />

         {/* Movie Gallery Route */}
         <Route path="/movies" element={<MovieGallery />} />  {/* Updated path for MovieGallery */}

         {/* Dynamic Route for each movie's details page */}
         <Route path="/movie/:id" element={<MovieDetails />} />  {/* Updated dynamic path */}


      </Routes>
     
      <Footer/>
      </Router>
  
  );
}

export default App;
