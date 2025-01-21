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

import LoginForm from './components/Login/Login.jsx';
import SigninForm from './components/Login/Signin.jsx';
import ForgotPassword from './components/Login/ForgotPassword.jsx'; 

import 'boxicons/css/boxicons.min.css';
import 'font-awesome/css/font-awesome.min.css';
import 'remixicon/fonts/remixicon.css';
import 'bootstrap-icons/font/bootstrap-icons.css';

function App() {
  return (
    <Router>
      <ScrollToTop />
      <Header />
      <Routes>

        <Route path="/" element={<HeroSection />} />
  
        <Route path="/about-us" element={<AboutSection />} />
       
        <Route path="/login" element={<LoginForm />} />

        <Route path="/sign-up" element={<SigninForm />} />

        <Route path="/forgot-password" element={<ForgotPassword />} /> 

        <Route path="/contact" element={<ContactSection />} />
       
        <Route path="/movies" element={<MoviesSection />} />
        
        <Route path="/movies/:movieId" element={<MovieDetails />} />

      </Routes>
      <Footer />
    </Router>
  );
}

export default App;
