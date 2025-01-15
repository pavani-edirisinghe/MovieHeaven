import React from "react";
import { useParams } from "react-router-dom";

const MovieDescription = () => {
  const { movieId } = useParams(); 

  const movieData = {
    1: { 
      title: "Wicked", 
      description: "An amazing adventure of magical wonders.", 
      poster: "/movies/Wicked.jpg", 
    },

    2: { 
      title: "Gladiator II", 
      description: "A thrilling sequel to the epic battle story.", 
      poster: "/movies/Gladiator II.jpg", 
    },

    3: { 
      title: "Survive", 
      releaseDate: "2024", 
      genre: "Adventure", 
      poster: "/movies/Survive.jpg",
    },

    4: {  
       title: "Moana",
       releaseDate: "2024", 
       genre: "Animation", 
       poster: "/movies/Moana 2.jpg"
       },

    5: {  
       title: "Goosebumps",
       releaseDate: "2023", 
       genre: "Family",
       poster: "/movies/Goosebumps.jpg"
       },

    6: {  
       title: "The Lord of the Rings", 
       releaseDate: "2022",
       genre: "Adventure", 
       poster: "/movies/The Lord of the Rings.jpg"
       },

    7: { 
       title: "Squid Game",
       releaseDate: "2021",
       genre: "Family", 
       poster: "/movies/Squid Game.jpg"
       },

    8: {  
       title: "The Wild Robot",
       releaseDate: "2023", 
       genre: "Family",
       poster: "/movies/The Wild Robot.jpg"
       },

    9: {  
       title: "Heretic", 
       releaseDate: "2024",
       genre: "Family", 
       poster: "/movies/Heretic.jpg"
       },

    10: {  
        title: "Spirited Away",
        releaseDate: "2023",
        genre: "Animation", 
        poster: "/movies/Spirited Away.jpg" 
      },

    11: {  
       title: "The Love Scam",
       releaseDate: "2025", 
       genre: "Romance", 
       poster: "/movies/The Love Scam.jpg"
       },

    12: {  
       title: "Your Name",
       releaseDate: "2024", 
       genre: "Animation",
       poster: "/movies/Your Name.jpg"
       },

    13: { 
       title: "A Real Pain",
       releaseDate: "2024",
       genre: "Romance",
       poster: "/movies/A Real Pain.jpg"
       },

    14: { 
       title: "American Primeval", 
       releaseDate: "2022", 
       genre: "Adventure",
       poster: "/movies/American Primeval.jpg"
       },

    15: { 
       title: "Your Fault", 
       releaseDate: "2022", 
       genre: "Family", 
       poster: "/movies/Your Fault.jpg" 
      },

    16: {  
      title: "IF", 
      releaseDate: "2024", 
      genre: "Romance", 
      poster: "/movies/IF.jpg" 
      },

    17: {  
      title: "Grave of the Fireflies",
      releaseDate: "2024", 
      genre: "Animation",
      poster: "/movies/Grave of the Fireflies.jpg"
     },

    18: {  
      title: "The Green Mile", 
      releaseDate: "2022", 
      genre: "Adventure", 
      poster: "/movies/The Green Mile.jpg" 
     },

    19: {  
      title: "Bagman", 
      releaseDate: "2024", 
      genre: "Romance", 
      poster: "/movies/Bagman.jpg"
     },

    20: {  
      title: "Werewolves",
      releaseDate: "2022", 
      genre: "Family", 
      poster: "/movies/Werewolves.jpg"
     },

    21: {  
      title: "Oppenheimer", 
      releaseDate: "2023", 
      genre: "Adventure", 
      poster: "/movies/Oppenheimer.jpg"
     },

    22: {  
      title: "The Dark Knight",
      releaseDate: "2025", 
      genre: "Family", 
      poster: "/movies/The Dark Knight.jpg"
      },

    23: {  
      title: "Ferry 2", 
      releaseDate: "2024", 
      genre: "Adventure", 
      poster: "/movies/Ferry2.jpg" 
      },

    24: {  
      title: "The Return", 
      releaseDate: "2024", 
      genre: "Family", 
      poster: "/movies/The Return.jpg" 
    },

    25: {  
      title: "Joker", 
      releaseDate: "2024",
       genre: "Adventure", 
       poster: "/movies/Joker.jpg" 
      },
   
  };

  const movieDetails = movieData[movieId] || { 
    title: "Movie Not Found", 
    description: "Details for this movie are not available.", 
    poster: "/default-poster.jpg", 
  };

  return (
    <div className="movie-description">
      <br /> <br />
      <h1>{movieDetails.title}</h1>
      <img src={movieDetails.poster} alt={movieDetails.title} />
      <p>{movieDetails.description}</p>
    </div>
  );
};

export default MovieDescription;