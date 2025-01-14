import React from "react";
import { useParams } from "react-router-dom";

const MovieDetails = () => {
  const { id } = useParams();

  // This would be replaced by a real database or API call
  const movieDetails = {
    1: { title: "Wicked", description: "A musical fantasy movie", releaseDate: "2023" },
    2: { title: "Moana", description: "A Disney animated adventure", releaseDate: "2016" },
    3: { title: "Moana", description: "A Disney animated adventure", releaseDate: "2017" },
    // Add more movies as needed
    
  };

  const movie = movieDetails[id];

  if (!movie) {
    return <p>Movie not found</p>;
  }

  return (
    <div>
      <h1>{movie.title}</h1>
      <p>{movie.description}</p>
      <p>Release Date: {movie.releaseDate}</p>
    </div>
  );
};

export default MovieDetails;
