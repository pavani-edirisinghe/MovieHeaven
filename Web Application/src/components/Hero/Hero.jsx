import React from 'react';
import './Hero.css';


const HeroSection = () => {
  return (
    <section id="hero">
      <div className="hero-container">
        
        <h3>Welcome  </h3>
        <h2>The ultimate destination for movie lovers. Explore Now..</h2>
        <br />
        <a href="#about" className="btn-get-started scrollto">Get Started</a>
      </div>
    </section>
  );
};

export default HeroSection;
