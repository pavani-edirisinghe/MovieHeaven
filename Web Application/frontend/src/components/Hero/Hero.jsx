import React from 'react';
import { Link } from 'react-router-dom';
import './Hero.css';


const trendingMovies = [
  { id: 1, title: 'Wicked', releaseDate: '2023', image: '/movies/Wicked.jpg' },
  { id: 4, title: 'Moana 2', releaseDate: '2024', image: '/movies/Moana 2.jpg' },
  { id: 7, title: 'Squid Game', releaseDate: '2021', image: '/movies/Squid Game.jpg' },
  { id: 5, title: 'Goosebumps', releaseDate: '2023', image: '/movies/Goosebumps.jpg' },
  { id: 14, title: 'American Primeval', releaseDate: '2022', image: '/movies/American Primeval.jpg' },
];

const popularMovies = [
  { id: 2, title: 'Gladiator II', releaseDate: '2025', image: '/movies/Gladiator II.jpg' },
  { id: 8, title: 'The Wild Robot ', releaseDate: '2023', image: '/movies/The Wild Robot.jpg' },
  { id: 6, title: 'The Lord of the Rings', releaseDate: '2022', image: '/movies/The Lord of the Rings.jpg' },
  { id: 20, title: 'Werewolves', releaseDate: '2024', image: '/movies/Werewolves.jpg' },
  { id: 15, title: 'Your Fault', releaseDate: '2022', image: '/movies/Your Fault.jpg' },
];

const topRatedMovies = [
  { id: 10, title: 'Spirited Away', releaseDate: '2023', image: '/movies/Spirited Away.jpg' },
  { id: 12, title: 'Your Name', releaseDate: '2024', image: '/movies/Your Name.jpg' },
  { id: 18, title: 'The Green Mile', releaseDate: '2022', image: '/movies/The Green Mile.jpg' },
  { id: 22, title: 'The Dark Knight', releaseDate: '2025', image: '/movies/The Dark Knight.jpg' },
  { id: 17, title: 'Grave of the Fireflies', releaseDate: '2022', image: '/movies/Grave of the Fireflies.jpg' },
];

const HeroSection = () => {
  return (
    <div>
      <section id="hero">
        <div className="hero-container">
          <br />
          <h3>Welcome</h3>
          <h2>The ultimate destination for movie lovers. Explore Now..</h2>
          <br />
          <a href="#features" className="btn-get-started scrollto">Get Started</a>
        </div>
      </section>

      <section id="trending-movies" className="features-section"> 
        <div className="features-container">
          <h2>Trending</h2>
          <br />
        </div>
      </section>

      <section id="trending-movie-gallery" className="movie-gallery-section"> 
        <div className="movie-gallery-container">
          <div className="movie-gallery">
            {trendingMovies.map((movie) => (
              <div className="movie-item" key={movie.id}>
                <Link to={`/movies/${movie.id}`}>
                  <img src={movie.image} alt={movie.title} width="220px" height="330px" />
                </Link>
                <div className="movie-details">
                  <h4>{movie.title}</h4>
                  <p>Release Date: {movie.releaseDate}</p>
                </div>
              </div>
            ))}
          </div>
        </div>
      </section>
          
          <br /><br /><br /> <br /> <br /><br />

      <section id="popular-movies" className="features-section"> 
        <div className="features-container">
          <h2>What's Popular</h2>
          <br />
        </div>
      </section>

      <section id="movie-gallery" className="movie-gallery-section"> 
        <div className="movie-gallery-container">
          <div className="movie-gallery">
            {popularMovies.map((movie) => (
              <div className="movie-item" key={movie.id}>
                <Link to={`/movies/${movie.id}`}>
                  <img src={movie.image} alt={movie.title} width="220px" height="330px" />
                </Link>
                <div className="movie-details">
                  <h4>{movie.title}</h4>
                  <p>Release Date: {movie.releaseDate}</p>
                </div>
              </div>
            ))}
          </div>
        </div>
      </section>

         
      <br /><br /><br /> <br /> <br />

<section id="popular-movies" className="features-section"> 
  <div className="features-container">
    <h2>Top Rated</h2>
    <br />
  </div>
</section>

<section id="movie-gallery" className="movie-gallery-section"> 
  <div className="movie-gallery-container">
    <div className="movie-gallery">
      {topRatedMovies.map((movie) => (
        <div className="movie-item" key={movie.id}>
          <Link to={`/movies/${movie.id}`}>
            <img src={movie.image} alt={movie.title} width="220px" height="330px" />
          </Link>
          <div className="movie-details">
            <h4>{movie.title}</h4>
            <p>Release Date: {movie.releaseDate}</p>
          </div>
        </div>
      ))}
    </div>
  </div>
</section>

      <br /><br />  
    </div>
  );
};

export default HeroSection;