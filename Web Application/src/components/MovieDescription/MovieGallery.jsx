import React, { useState } from "react";
import { Link } from "react-router-dom";

const movies = [
  { id: 1, title: "Wicked", releaseDate: "2023", genre: "Adventure", imageUrl: "/movies/Wicked.jpg" },
  { id: 2, title: "Gladiator II", releaseDate: "2025", genre: "Adventure", imageUrl: "/movies/Gladiator II.jpg" },
  { id: 3, title: "Survive", releaseDate: "2024", genre: "Adventure", imageUrl: "/movies/Survive.jpg"},
  { id: 4, title: "Moana", releaseDate: "2024", genre: "Animation", imageUrl: "/movies/Moana 2.jpg" },
  { id: 5, title: "Goosebumps", releaseDate: "2023", genre: "Family", imageUrl: "/movies/Goosebumps.jpg" },
  { id: 6, title: "The Lord of the Rings", releaseDate: "2022", genre: "Adventure", imageUrl: "/movies/The Lord of the Rings.jpg"},
  { id: 7, title: "Squid Game", releaseDate: "2021", genre: "Family", imageUrl: "/movies/Squid Game.jpg" },
  { id: 8, title: "The Wild Robot", releaseDate: "2023", genre: "Family", imageUrl: "/movies/The Wild Robot.jpg" },
  { id: 9, title: "Heretic", releaseDate: "2024", genre: "Family", imageUrl: "/movies/Heretic.jpg" },
  { id: 10, title: "Spirited Away", releaseDate: "2023", genre: "Animation", imageUrl: "/movies/Spirited Away.jpg" },
  { id: 11, title: "The Love Scam", releaseDate: "2025", genre: "Romance", imageUrl: "/movies/The Love Scam.jpg" },
  { id: 12, title: "Your Name", releaseDate: "2024", genre: "Animation", imageUrl: "/movies/Your Name.jpg" },
  { id: 13, title: "A Real Pain", releaseDate: "2024", genre: "Romance", imageUrl: "/movies/A Real Pain.jpg" },
  { id: 14, title: "American Primeval", releaseDate: "2022", genre: "Adventure", imageUrl: "/movies/American Primeval.jpg" },
  { id: 15, title: "Your Fault", releaseDate: "2022", genre: "Family", imageUrl: "/movies/Your Fault.jpg" },
  { id: 16, title: "IF", releaseDate: "2024", genre: "Romance", imageUrl: "/movies/IF.jpg" },
  { id: 17, title: "Grave of the Fireflies", releaseDate: "2024", genre: "Animation", imageUrl: "/movies/Grave of the Fireflies.jpg" },
  { id: 18, title: "The Green Mile", releaseDate: "2022", genre: "Adventure", imageUrl: "/movies/The Green Mile.jpg" },
  { id: 19, title: "Bagman", releaseDate: "2024", genre: "Romance", imageUrl: "/movies/Bagman.jpg" },
  { id: 20, title: "Werewolves", releaseDate: "2022", genre: "Family", imageUrl: "/movies/Werewolves.jpg" },
  { id: 21, title: "Oppenheimer", releaseDate: "2023", genre: "Adventure", imageUrl: "/movies/Oppenheimer.jpg" },
  { id: 22, title: "The Dark Knight", releaseDate: "2025", genre: "Family", imageUrl: "/movies/The Dark Knight.jpg" },
  { id: 23, title: "Ferry 2", releaseDate: "2024", genre: "Adventure", imageUrl: "/movies/Ferry2.jpg" },
  { id: 24, title: "The Return", releaseDate: "2024", genre: "Family", imageUrl: "/movies/The Return.jpg" },
  { id: 25, title: "Joker", releaseDate: "2024", genre: "Adventure", imageUrl: "/movies/Joker.jpg" },
];

const genres = ["All Movies", "Adventure", "Animation", "Family", "Romance"];

const MovieGallery = () => {
  const [selectedGenre, setSelectedGenre] = useState("All");

  const handleGenreChange = (event) => {
    setSelectedGenre(event.target.value);
  };

  const filteredMovies = selectedGenre === "All" 
    ? movies 
    : movies.filter((movie) => movie.genre === selectedGenre);

  return (
    <section id="movie-gallery" className="movie-gallery-section">
     <div className="movie-gallery-container">
  <div
    className="gallery-header"
    style={{
      display: "flex",
      justifyContent: "space-between",
      alignItems: "center",
      marginBottom: "40px",
      paddingTop: "100px",
    }}
  >

    <h2
      className="gallery-heading"
      style={{
        fontSize: "2rem",
        fontWeight: 500,
        color: "white",
        margin: 0, 
      }}
    >
      Explore Movies
    </h2>

    <div
      style={{
        display: "flex",
        alignItems: "center",
        gap: "10px", 
      }}
    >

    <span
        style={{
          fontSize: "1.5rem",
          color: "white",
          fontWeight: "300px",
        }}
      >
        Select Genre :
      </span>

    <select
      onChange={handleGenreChange}
      value={selectedGenre}
      style={{
        padding: "5px",
        fontSize: "1rem",
        borderRadius: "15px",
        outline: "none",
        width:"140px",
      }}
    >
      {genres.map((genre) => (
        <option key={genre} value={genre}>
          {genre}
        </option>
      ))}
    </select>
  </div>
  </div>

        <div className="movie-gallery">
          {filteredMovies.map((movie) => (
            <div className="movie-item" key={movie.id}>
              <Link to={`/movies/${movie.id}`}>
                <img
                  src={movie.imageUrl}
                  alt={movie.title}
                  width="220px"
                  height="330px"
                  style={{
                    objectFit: "cover",
                    borderRadius: "10px",
                    transition: "transform 0.3s ease",
                  }}
                />
              </Link>
              <div className="movie-details" style={{ marginTop: "10px", textAlign: "left" }}>
                <h4 style={{ fontSize: "1.2rem", color: "white" }}>{movie.title}</h4>
                <p style={{ color: "#ccc" }}>Release Year: {movie.releaseDate}</p>
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
};

export default MovieGallery;
