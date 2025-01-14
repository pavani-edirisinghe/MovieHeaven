import { useState } from 'react'
import {Routes,Route} from 'react-router-dom'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Header from "./components/Header/Header.jsx";
import HeroSection from './components/Hero/Hero.jsx';
import AboutSection from './components/About/About.jsx';
import ContactSection from './components/Contact/Contact.jsx';
import Footer from './components/Footer/Footer.jsx';
import 'boxicons/css/boxicons.min.css';
import 'font-awesome/css/font-awesome.min.css';
import 'remixicon/fonts/remixicon.css';
import 'bootstrap-icons/font/bootstrap-icons.css';


function App() {
  const [count, setCount] = useState(0)

  return (
    <div>
      <Header/>
      <HeroSection/>
      <AboutSection />
      <ContactSection />
      <Footer/>
  </div>
  );
}

export default App;
