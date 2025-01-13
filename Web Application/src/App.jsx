import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Header from "./components/Header/Header.jsx";
import HeroSection from './components/Hero/Hero.jsx';
import AboutSection from './components/About/About.jsx';
import Footer from './components/Footer/Footer.jsx';
import 'boxicons/css/boxicons.min.css';
// src/index.js or src/App.js
import 'font-awesome/css/font-awesome.min.css';



function App() {
  const [count, setCount] = useState(0)

  return (
    <div>
      <Header/>
      <HeroSection/>
     
      <AboutSection />
      <Footer/>

   
   
  </div>
  );
}

export default App;
