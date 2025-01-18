import React, { useState } from "react";
import { useParams } from "react-router-dom";
import "./MovieDetails.css";

const MovieDescription = () => {
  const { movieId } = useParams();
  const [isPlaying, setIsPlaying] = useState(false); 


  const movieData = {
    1: { 
      title: "Wicked", 
      description: "An amazing adventure of magical wonders.", 
      genre1: "Adventure",
      genre2: "Fantasy ",
      genre3: "Musical",
      poster: "/movies/Wicked.jpg", 
      background: "/movieBackground/Wicked.jpg",
      youtubleLink:"https://www.youtube.com/embed/6COmYeLsz4c?si=qDyc7Gvx3O1UCHga",
    },

    2: { 
      title: "Gladiator II", 
      genre1: "Action",
      genre2: "Adventure",
      genre3: "Drama",
      description: "A thrilling sequel to the epic battle story.", 
      poster: "/movies/Gladiator II.jpg", 
      background: "/movieBackground/Gladiator%20II.jpg",
      youtubleLink:"https://www.youtube.com/embed/4rgYUipGJNo?si=a1S6vpYl7ljNKEe_",
    },

    3: { 
      title: "Survive", 
      releaseDate: "2024", 
      genre1: "Adventure", 
      genre2: "Action",
      genre3: "Sci-Fi",
      poster: "/movies/Survive.jpg",
      background: "/movieBackground/Survive.jpg",
      youtubleLink:"https://www.youtube.com/embed/2sNkmHMLsVw?si=XBh1DgxrE7cabG2f",
    },

    4: {  
       title: "Moana 2",
       releaseDate: "2024", 
       genre1: "Adventure",
       genre2: "Animation",
       genre3: "Musical",
       poster: "/movies/Moana 2.jpg",
       background: "/movieBackground/Moana%2021.jpg",
       youtubleLink:"https://www.youtube.com/embed/hDZ7y8RP5HE?si=mzfP5XCn5wPnmuzM",
       },

       5: {  
        title: "Goosebumps",
        releaseDate: "2023", 
        genre1: "Family",
        genre2: "Horror",
        genre3: "Comedy",
        poster: "/movies/Goosebumps.jpg",
        background: "/movieBackground/Goosebumps1.jpeg",
        youtubleLink:"https://www.youtube.com/embed/-NsYcYtDBtc?si=zqlGDS9s6b27dpjs",
     },
     
     6: {  
        title: "The Lord of the Rings", 
        releaseDate: "2022",
        genre1: "Adventure", 
        genre2: "Fantasy", 
        genre3: "Action", 
        poster: "/movies/The Lord of the Rings.jpg",
        background: "/movieBackground/The%20Lord%20of%20the%20Rings1.jpg",
        youtubleLink:"https://www.youtube.com/embed/x8UAUAuKNcU?si=jlYepIuBJGNpLJ_v",
     },
     
     7: { 
        title: "Squid Game",
        releaseDate: "2021",
        genre1: "Family", 
        genre2: "Thriller", 
        genre3: "Drama", 
        poster: "/movies/Squid Game.jpg",
        background: "/movieBackground/Squid%20Game.jpg",
        youtubleLink:"https://www.youtube.com/embed/oqxAJKy0ii4?si=9FVe5qmWIOHam010",
     },
     
     8: {  
        title: "The Wild Robot",
        releaseDate: "2023", 
        genre1: "Family",
        genre2: "Sci-Fi", 
        genre3: "Adventure", 
        poster: "/movies/The Wild Robot.jpg",
        background: "/movieBackground/The%20Wild%20Robot.jpg",
        youtubleLink:"https://www.youtube.com/embed/67vbA5ZJdKQ?si=QP_ppJcDs9i-M1ay",
     },
     
     9: {  
        title: "Heretic", 
        releaseDate: "2024",
        genre1: "Family", 
        genre2: "Action", 
        genre3: "Adventure", 
        poster: "/movies/Heretic.jpg",
        background: "/movieBackground/Heretic1.jpg",
        youtubleLink:"https://www.youtube.com/embed/O9i2vmFhSSY?si=YM_KcsI2OInCBQH5",
     },
     
     10: {  
         title: "Spirited Away",
         releaseDate: "2023",
         genre1: "Animation", 
         genre2: "Fantasy", 
         genre3: "Adventure", 
         poster: "/movies/Spirited Away.jpg" ,
         background: "/movieBackground/Spirited%20Away1.jpg",
         youtubleLink:"https://www.youtube.com/embed/ByXuk9QqQkk?si=ra8unkfUT2OTWzrT",
       },
     
     11: {  
        title: "The Love Scam",
        releaseDate: "2025", 
        genre1: "Romance", 
        genre2: "Comedy", 
        genre3: "Drama", 
        poster: "/movies/The Love Scam.jpg",
        background: "/movieBackground/The%20Love%20Scam1.jpg",
        youtubleLink:"https://www.youtube.com/embed/h6I5pSC0_tY?si=uHpfHINArvRSEkM5",
     },
     
     12: {  
        title: "Your Name",
        releaseDate: "2024", 
        genre1: "Animation",
        genre2: "Romance",
        genre3: "Drama",
        poster: "/movies/Your Name.jpg",
        background: "/movieBackground/Your%20Name1.jpg",
        youtubleLink:"https://www.youtube.com/embed/xU47nhruN-Q?si=DJ-Wv5VE398U0Hhi",
     },
     
     13: { 
        title: "A Real Pain",
        releaseDate: "2024",
        genre1: "Romance",
        genre2: "Drama",
        genre3: "Comedy",
        poster: "/movies/A Real Pain.jpg",
        background: "/movieBackground/A%20Real%20Pain.jpg",
        youtubleLink:"https://www.youtube.com/embed/b2et8Vpu7Ls?si=BS6snOYAGr5Y2CGD",
     },
     
     14: { 
        title: "American Primeval", 
        releaseDate: "2022", 
        genre1: "Adventure",
        genre2: "Action",
        genre3: "Drama",
        poster: "/movies/American Primeval.jpg",
        background: "/movieBackground/American%20Primeval.jpeg",
        youtubleLink:"https://www.youtube.com/embed/U8WMvCrywYg?si=aNKHvyZgr_pbZpFc",
     },
     
     15: { 
        title: "Your Fault", 
        releaseDate: "2022", 
        genre1: "Family", 
        genre2: "Romance", 
        genre3: "Drama", 
        poster: "/movies/Your Fault.jpg" ,
        background: "/movieBackground/Your%20Fault.avif",
        youtubleLink:"https://www.youtube.com/embed/sOmBXymF3Rk?si=hLo9O1Bk9Y4mEwJm",
     },
     
     16: {  
       title: "IF", 
       releaseDate: "2024", 
       genre1: "Romance", 
       genre2: "Drama", 
       genre3: "Fantasy", 
       poster: "/movies/IF.jpg" ,
       background: "/movieBackground/IF.jpg",
       youtubleLink:"https://www.youtube.com/embed/mb2187ZQtBE?si=QSKNcq6Hg-EyaJ-x",
     },
     
     17: {  
       title: "Grave of the Fireflies",
       releaseDate: "2024", 
       genre1: "Animation",
       genre2: "War",
       genre3: "Drama",
       poster: "/movies/Grave of the Fireflies.jpg",
       background: "/movieBackground/Grave%20of%20the%20Fireflies.jpg",
       youtubleLink:"https://www.youtube.com/embed/lhlh7JVcTt8?si=PEviVJanEF8R03Mo",
      },
     
     18: {  
       title: "The Green Mile", 
       releaseDate: "2022", 
       genre1: "Adventure", 
       genre2: "Drama", 
       genre3: "Fantasy", 
       poster: "/movies/The Green Mile.jpg" ,
       background: "/movieBackground/The%20Green%20Mile.jpg",
       youtubleLink:"https://www.youtube.com/embed/Ki4haFrqSrw?si=hFCttnKn-p-C-kRv",
      },
     
     19: {  
       title: "Bagman", 
       releaseDate: "2024", 
       genre1: "Romance", 
       genre2: "Drama", 
       genre3: "Thriller", 
       poster: "/movies/Bagman.jpg",
       background: "/movieBackground/Bagman.jpeg",
       youtubleLink:"https://www.youtube.com/embed/slrzCgYIUPM?si=E7wrdQenvzus2BNY",
      },
     
     20: {  
       title: "Werewolves",
       releaseDate: "2022", 
       genre1: "Family", 
       genre2: "Horror", 
       genre3: "Fantasy", 
       poster: "/movies/Werewolves.jpg",
       background: "/movieBackground/Werewolves.jpg",
       youtubleLink:"https://www.youtube.com/embed/iAAUDfGSdqs?si=8b_m7BJi07XqYZNh",
      },
     
     21: {  
       title: "Oppenheimer", 
       releaseDate: "2023", 
       genre1: "Adventure", 
       genre2: "Biography", 
       genre3: "Drama", 
       poster: "/movies/Oppenheimer.jpg",
       background: "/movieBackground/oppenheminar.jpeg",
       youtubleLink:"https://www.youtube.com/embed/uYPbbksJxIg?si=BRYKp2JHZ-jK3nu4",
      },
     
     22: {  
       title: "The Dark Knight",
       releaseDate: "2025", 
       genre1: "Family", 
       genre2: "Action", 
       genre3: "Crime", 
       poster: "/movies/The Dark Knight.jpg",
       background: "/movieBackground/The%20Dark%20Knight.jpg",
       youtubleLink:"https://www.youtube.com/embed/EXeTwQWrcwY?si=F7XeR7NtC5mLG1kf",
     },
     
     23: {  
       title: "Ferry 2", 
       releaseDate: "2024", 
       genre1: "Adventure", 
       genre2: "Crime", 
       genre3: "Thriller", 
       poster: "/movies/Ferry2.jpg" ,
       background: "/movieBackground/Ferry21.jpg",
       youtubleLink:"https://www.youtube.com/embed/DQ3fSBus-HU?si=lm89mxHj6FPT4LrY",
     },
     
     24: {  
       title: "The Return", 
       releaseDate: "2024", 
       genre1: "Family", 
       genre2: "Fantasy", 
       genre3: "Drama", 
       poster: "/movies/The Return.jpg" ,
       background: "/movieBackground/The%20Return.jpg",
       youtubleLink:"https://www.youtube.com/embed/lrZqQBA9v3Q?si=e2hat-B6B7F1FK8c",
     },
     
     25: {  
       title: "Joker", 
       releaseDate: "2024",
        genre1: "Adventure", 
        genre2: "Crime", 
        genre3: "Drama", 
        poster: "/movies/Joker.jpg" ,
        background: "/movieBackground/Joker.jpg",
        youtubleLink:"https://www.youtube.com/embed/zAGVQLHvwOY?si=4pczqi_ZBMMQnnuB",
      },
     
  };

  const movieDetails = movieData[movieId] || { 
    title: "Movie Not Found", 
    description: "Details for this movie are not available.", 
    poster: "/default-poster.jpg", 
    background: "/default-background.jpg",
  };

  const handlePlayButtonClick = () => {
    setIsPlaying(true); 
  };

  const handleCloseButtonClick = () => {
    setIsPlaying(false); 
  };


  return (
   
    <div className="movie-container">
    <br />
    <div className="movie-background">
        <div
            className="backdrop-img"
            style={{
                backgroundImage: `url(${movieDetails.background})`,
            }}
        ></div>
        <div className="opacity-layer"></div>
    </div>
    <br /><br /><br /><br /><br />
    <div className="movie-left">
        <img
            src={movieDetails.poster}
            alt={movieDetails.title}
            className="movie-poster"
        />
    </div>
    <div className="movie-right">
        <br />
        <h1>{movieDetails.title}</h1>
        <h5 className="movie-genre">{movieDetails.genre1}</h5>
        <h5 className="movie-genre">{movieDetails.genre2}</h5>
        <h5 className="movie-genre">{movieDetails.genre3}</h5>
        <br /> <br /> <br />

  

        <div className="play-trailer-container">
 
  <button className="play-button" onClick={handlePlayButtonClick}>
    <i className="fa fa-play" aria-hidden="true"></i>
  
  </button>
  <h5 className="watch-trailer-text">Watch Trailer</h5>
  <button className="play-button" onClick={handlePlayButtonClick}>
    <i className="fa fa-play" aria-hidden="true"></i>
  
  </button>
  <h5 className="watch-trailer-text">Watch Trailer</h5>
</div>


      {isPlaying && (
        <div className="video-overlay">
          <button className="close-button" onClick={handleCloseButtonClick}>
            &times;
          </button>
          <iframe
            width="700"
            height="500"
            src={movieDetails.youtubleLink}
            frameBorder="0"
            allow="autoplay; encrypted-media"
            title="movie-trailer"
          ></iframe>
        </div>
      )}

        
       
    </div>

</div>

  );
};
export default MovieDescription;  