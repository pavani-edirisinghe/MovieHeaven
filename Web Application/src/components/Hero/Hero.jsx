import React from 'react';
import './Hero.css';

const HeroSection = () => {
  return (
    <div>
      <section id="hero">
        <div className="hero-container">
          <br />
          <h3>Welcome  </h3>
          <h2>The ultimate destination for movie lovers. Explore Now..</h2>
          <br />
          <a href="#features" className="btn-get-started scrollto">Get Started</a>
        </div>
      </section>
      <section id="features" className="features-section">
  <div className="features-container">
    <h2>Trending</h2> <br />
  </div>
</section>

<section id="movie-gallery" className="movie-gallery-section">
  <div className="movie-gallery-container">
    <div className="movie-gallery">
      <div className="movie-item">
        <img src="/movies/Wicked.jpg" alt="Movie 1" width="220px" height="330px" />
        <div className="movie-details">
          <h4>Wicked</h4>
          <p>Release Date: 2023</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Moana 2.jpg" alt="Movie 2" />
        <div className="movie-details">
          <h4>Moana 2</h4>
          <p>Release Date: 2024</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Squid Game.jpg" alt="Movie 3" />
        <div className="movie-details">
          <h4>Squid Game</h4>
          <p>Release Date: 2021</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Goosebumps.jpg" alt="Movie 4" />
        <div className="movie-details">
          <h4>Goosebumps</h4>
          <p>Release Date: 2023</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/American Primeval.jpg" alt="Movie 5" />
        <div className="movie-details">
          <h4>American Primeval</h4>
          <p>Release Date: 2022</p>
        </div>
      </div>
    </div>
  </div>
</section>

<section id="features" className="features-section-1">
  <div className="features-container-1">
    <h2>What's Popular</h2> <br />
  </div>
</section>

<section id="movie-gallery" className="movie-gallery-section">
  <div className="movie-gallery-container">
    <div className="movie-gallery">
      <div className="movie-item">
        <img src="/movies/Gladiator II.jpg" alt="Movie 1" width="220px" height="330px" />
        <div className="movie-details">
          <h4>Gladiator II</h4>
          <p>Release Date: 2025</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/The Wild Robot.jpg" alt="Movie 2" />
        <div className="movie-details">
          <h4>The Wild Robot</h4>
          <p>Release Date: 2023</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/The Lord of the Rings.jpg" alt="Movie 3" />
        <div className="movie-details">
          <h4>The Lord of the Rings</h4>
          <p>Release Date: 2022</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Werewolves.jpg" alt="Movie 4" />
        <div className="movie-details">
          <h4>Werewolves</h4>
          <p>Release Date: 2024</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Your Fault.jpg" alt="Movie 5" />
        <div className="movie-details">
          <h4>Your Fault</h4>
          <p>Release Date: 2022</p>
        </div>
      </div>
    </div>
  </div>
</section>

<section id="features" className="features-section-1">
  <div className="features-container-1">
    <h2>Top Rated</h2> <br />
  </div>
</section>

<section id="movie-gallery" className="movie-gallery-section">
  <div className="movie-gallery-container">
    <div className="movie-gallery">
      <div className="movie-item">
        <img src="/movies/Spirited Away.jpg" alt="Movie 1" width="220px" height="330px" />
        <div className="movie-details">
          <h4>Spirited Away</h4>
          <p>Release Date: 2023</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Your Name.jpg" alt="Movie 2" />
        <div className="movie-details">
          <h4>Your Name</h4>
          <p>Release Date: 2024</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/The Green Mile.jpg" alt="Movie 3" />
        <div className="movie-details">
          <h4>The Green Mile</h4>
          <p>Release Date: 2022</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/The Dark Knight.jpg" alt="Movie 4" />
        <div className="movie-details">
          <h4>The Dark Knight</h4>
          <p>Release Date: 2025</p>
        </div>
      </div>
      <div className="movie-item">
        <img src="/movies/Grave of the Fireflies.jpg" alt="Movie 5" />
        <div className="movie-details">
          <h4>Grave of the Fireflies</h4>
          <p>Release Date: 2024</p>
        </div>
      </div>
    </div>
  </div>
</section>


      <br /><br />  <br /><br />

    </div>
  );
};

export default HeroSection;
