import React, { useState, useRef } from "react";
import { useParams } from "react-router-dom";
import BookingInfo from "./BookingInfo";
import "./MovieDetails.css";

const MovieDescription = () => {
  const { movieId } = useParams();
  const [isPlaying, setIsPlaying] = useState(false);
  const [showBookingParagraph, setShowBookingParagraph] = useState(false);
  const bookingSectionRef = useRef(null); 

  const movieData = {
    1: { 
      title: "Wicked", 
      description: "Wicked is an adventure unlike any other, filled with magical wonders. It's a fantastical story that blends adventure, fantasy, and musical elements. Get swept away in this amazing tale as you experience a world of magic and wonder.", 
      genre1: "Adventure",
      genre2: "Fantasy ",
      genre3: "Musical",
      poster: "/movies/Wicked.jpg", 
      background: "/movieBackground/Wicked.jpg",
      youtubleLink:"https://www.youtube.com/embed/6COmYeLsz4c?si=qDyc7Gvx3O1UCHga",
      ReleaseDate: "November 27, 2024",
      Runtime: "2h 30m",
      Director: " Jon M. Chu",
      Writer: "Winnie Holzman ",
    },

    2: { 
      title: "Gladiator II", 
      description: " A thrilling sequel to the epic battle story, Gladiator II takes viewers back into the arena for an action-packed adventure. Follow the journey of a new hero seeking revenge and justice in a brutal world. With intense action and drama, this film delivers high-octane moments that will keep audiences on the edge of their seats. ",
      genre1: "Action",
      genre2: "Adventure",
      genre3: "Drama",
      poster: "/movies/Gladiator II.jpg", 
      background: "/movieBackground/Gladiator%20II.jpg",
      youtubleLink:"https://www.youtube.com/embed/4rgYUipGJNo?si=a1S6vpYl7ljNKEe_",
       ReleaseDate: "March 15, 2024",
      Runtime: "2h 30m",
      Director:" Ridley Scott",
      Writer: "David Scarpa ",
    },

    3: { 
      title: "Survive", 
      description: "Survive is a gripping adventure film set in a dangerous, post-apocalyptic world. When a group of survivors finds themselves stranded, they must fight for survival against nature’s harshest elements. Filled with action, suspense, and sci-fi thrills, this movie will keep you hooked from start to finish. ",
      releaseDate: "2024", 
      genre1: "Adventure", 
      genre2: "Action",
      genre3: "Sci-Fi",
      poster: "/movies/Survive.jpg",
      background: "/movieBackground/Survive.jpg",
      youtubleLink:"https://www.youtube.com/embed/2sNkmHMLsVw?si=XBh1DgxrE7cabG2f",
      ReleaseDate: "april 20, 2024",
      Runtime: "1h 45m",
      Director:"John Krasinski ",
      Writer: "Richard Abate ",
    },

    4: {  
       title: "Moana 2",
       description: "In this heartwarming sequel, Moana 2 takes us on another epic adventure across the ocean. Filled with beautiful animation and magical songs, Moana embarks on a new journey that tests her courage and leadership. This musical adventure will enchant audiences of all ages.",
       genre1: "Adventure",
       genre2: "Animation",
       genre3: "Musical",
       poster: "/movies/Moana 2.jpg",
       background: "/movieBackground/Moana%2021.jpg",
       youtubleLink:"https://www.youtube.com/embed/hDZ7y8RP5HE?si=mzfP5XCn5wPnmuzM",
      ReleaseDate: "June 5, 2024",
      Runtime: "1h 55m",
      Director:" Ron Clements ",
      Writer: "Jared Bush ",
       },

       5: {  
        title: "Goosebumps",
        description: " Goosebumps is a spooky family-friendly movie that brings the legendary stories of R.L. Stine’s book series to life. A mix of horror, comedy, and mystery, this film follows a group of teens who accidentally unleash creepy creatures. Get ready for a thrilling ride with just the right amount of chills and laughs. ",
        genre1: "Family",
        genre2: "Horror",
        genre3: "Comedy",
        poster: "/movies/Goosebumps.jpg",
        background: "/movieBackground/Goosebumps1.jpeg",
        youtubleLink:"https://www.youtube.com/embed/-NsYcYtDBtc?si=zqlGDS9s6b27dpjs",
        ReleaseDate: "October 13, 2023",
        Runtime: "1h 40m",
        Director:"Rob Letterman ",
        Writer: "R.L. Stine ",
     },
     
     6: {  
        title: "The Lord of the Rings",
        description: " A stunning continuation of the epic Lord of the Rings saga, this film transports audiences back to Middle-earth. Adventure, fantasy, and action collide as the heroes prepare for their greatest battle yet. With breathtaking visuals and a compelling story, this movie is a must-see for fans of the franchise. ", 
        genre1: "Adventure", 
        genre2: "Fantasy", 
        genre3: "Action", 
        poster: "/movies/The Lord of the Rings.jpg",
        background: "/movieBackground/The%20Lord%20of%20the%20Rings1.jpg",
        youtubleLink:"https://www.youtube.com/embed/x8UAUAuKNcU?si=jlYepIuBJGNpLJ_v",
        ReleaseDate: "November 25, 2022",
        Runtime: "3h 10m",
        Director:"  Peter Jackson",
        Writer: "J.R.R. Tolkien ",
     },
     
     7: { 
        title: "Squid Game",     
        description: "Squid Game is a psychological thriller where contestants participate in deadly children's games for a life-changing prize. This intense drama reveals the dark side of human nature as participants are forced to face moral dilemmas and life-threatening challenges. With gripping suspense and high stakes, it’s a series that keeps you guessing. ",
        genre1: "Family", 
        genre2: "Thriller", 
        genre3: "Drama", 
        poster: "/movies/Squid Game.jpg",
        background: "/movieBackground/Squid%20Game.jpg",
        youtubleLink:"https://www.youtube.com/embed/oqxAJKy0ii4?si=9FVe5qmWIOHam010",
        ReleaseDate: "September 17, 2021 ",
        Runtime: "1h 25m",
        Director:"Hwang Dong-hyuk ",
        Writer: "Hwang Dong-hyuk",
     },
     
     8: {  
        title: "The Wild Robot",
        description: "The Wild Robot is a sci-fi adventure that follows the journey of a robot stranded in the wilderness. As she learns to adapt to her surroundings, she forms unexpected friendships with the creatures of the forest. A touching and thought-provoking film about survival, technology, and nature. ",
        genre1: "Family",
        genre2: "Sci-Fi", 
        genre3: "Adventure", 
        poster: "/movies/The Wild Robot.jpg",
        background: "/movieBackground/The%20Wild%20Robot.jpg",
        youtubleLink:"https://www.youtube.com/embed/67vbA5ZJdKQ?si=QP_ppJcDs9i-M1ay",
        ReleaseDate: "December 1, 2023",
        Runtime: "1h 50m",
        Director:" Justin D. Smith",
        Writer: "Peter Brown ",
     },
     
     9: {  
        title: "Heretic", 
        description: "A captivating blend of family, action, and adventure, Heretic tells the story of an unlikely hero discovering their hidden powers. With breathtaking action scenes and an inspiring storyline, this movie explores themes of destiny, courage, and personal growth. Get ready for an unforgettable adventure. ",
        genre1: "Family", 
        genre2: "Action", 
        genre3: "Adventure", 
        poster: "/movies/Heretic.jpg",
        background: "/movieBackground/Heretic1.jpg",
        youtubleLink:"https://www.youtube.com/embed/O9i2vmFhSSY?si=YM_KcsI2OInCBQH5",
        ReleaseDate: "February 10, 2024",
        Runtime: "2h 5m",
        Director:" David O. Russell",
        Writer: "Scott Teems ",
     },
     
     10: {  
         title: "Spirited Away",
         description: "Spirited Away is a visually stunning animated film that takes audiences on a magical journey through a mysterious world. The story follows a young girl as she navigates a realm of spirits and strange creatures. With beautiful animation and a heartfelt narrative, this movie is an unforgettable experience. ",
         genre1: "Animation", 
         genre2: "Fantasy", 
         genre3: "Adventure", 
         poster: "/movies/Spirited Away.jpg" ,
         background: "/movieBackground/Spirited%20Away1.jpg",
         youtubleLink:"https://www.youtube.com/embed/ByXuk9QqQkk?si=ra8unkfUT2OTWzrT",
         ReleaseDate: "October 5, 2023",
         Runtime: "2h 20m",
         Director:" Hayao Miyazaki",
         Writer: "Hayao Miyazaki ",
       },
     
     11: {  
        title: "The Love Scam",
        description: "A lighthearted romance-comedy, The Love Scam follows a woman who gets caught up in a series of unexpected events after falling for a charming scam artist. Filled with humor, heart, and surprising twists, this film explores the complexities of love, trust, and second chances. ",
        genre1: "Romance", 
        genre2: "Comedy", 
        genre3: "Drama", 
        poster: "/movies/The Love Scam.jpg",
        background: "/movieBackground/The%20Love%20Scam1.jpg",
        youtubleLink:"https://www.youtube.com/embed/h6I5pSC0_tY?si=uHpfHINArvRSEkM5",
        ReleaseDate: "January 15, 2025",
        Runtime: "1h 45m",
        Director:" Nancy Meyers",
        Writer: "Fran Walsh ",
     },
     
     12: {  
        title: "Your Name",
        description: "Your Name is an enchanting anime film about two teenagers who mysteriously swap bodies and try to navigate each other’s lives. A touching story of love, fate, and connection, this film blends romance and fantasy, leaving viewers with a sense of wonder and nostalgia. ",
        genre1: "Animation",
        genre2: "Romance",
        genre3: "Drama",
        poster: "/movies/Your Name.jpg",
        background: "/movieBackground/Your%20Name1.jpg",
        youtubleLink:"https://www.youtube.com/embed/xU47nhruN-Q?si=DJ-Wv5VE398U0Hhi",
        ReleaseDate: "May 5, 2024",
        Runtime: "1h 50m",
        Director:"Makoto Shinkai ",
        Writer: "Makoto Shinka ",
     },
     
     13: { 
        title: "A Real Pain",
        description: " A Real Pain is a heartfelt comedy-drama about a young couple navigating the ups and downs of their relationship. With plenty of humor and emotional depth, the film explores themes of love, conflict, and personal growth. It's a relatable story that will make you laugh and reflect. ",
        genre1: "Romance",
        genre2: "Drama",
        genre3: "Comedy",
        poster: "/movies/A Real Pain.jpg",
        background: "/movieBackground/A%20Real%20Pain.jpg",
        youtubleLink:"https://www.youtube.com/embed/b2et8Vpu7Ls?si=BS6snOYAGr5Y2CGD",
        ReleaseDate: "March 25, 2024",
        Runtime: "2h 10m",
        Director:"Craig Johnson ",
        Writer: "Jesse Eisenberg ",
     },
     
     14: { 
        title: "American Primeval", 
        description: "Set in the early days of American history, American Primeval is an action-packed drama about the struggles and conflicts that shaped the nation. With intense action and powerful storytelling, this film brings history to life, offering a thrilling ride through the American frontier. ",
        genre1: "Adventure",
        genre2: "Action",
        genre3: "Drama",
        poster: "/movies/American Primeval.jpg",
        background: "/movieBackground/American%20Primeval.jpeg",
        youtubleLink:"https://www.youtube.com/embed/U8WMvCrywYg?si=aNKHvyZgr_pbZpFc",
        ReleaseDate: "August 10, 2022 ",
        Runtime: "2h 20m",
        Director:"Michael Bay",
        Writer: "Mark L. Smith ",
     },
     
     15: { 
        title: "Your Fault", 
        description: "Your Fault is a heartfelt drama about a woman dealing with the aftermath of a life-changing mistake. Through the pain and conflict, she learns about forgiveness, redemption, and self-discovery. With emotional depth and a strong narrative, this film explores the complexities of personal growth. ",
        genre1: "Family", 
        genre2: "Romance", 
        genre3: "Drama", 
        poster: "/movies/Your Fault.jpg" ,
        background: "/movieBackground/Your%20Fault.avif",
        youtubleLink:"https://www.youtube.com/embed/sOmBXymF3Rk?si=hLo9O1Bk9Y4mEwJm",
        ReleaseDate: "January 21, 2022",
        Runtime: "1h 40m",
        Director:"Mike Nichols ",
        Writer: "Akiyuki Nosaka ",
     },
     
     16: {  
       title: "IF", 
       description: " IF is a romantic drama that blurs the lines between reality and fantasy. A young couple struggles with the reality of their love as they navigate a world filled with possibilities. This thought-provoking film challenges our perceptions of love, fate, and what could have been. ",
       genre1: "Romance", 
       genre2: "Drama", 
       genre3: "Fantasy", 
       poster: "/movies/IF.jpg" ,
       background: "/movieBackground/IF.jpg",
       youtubleLink:"https://www.youtube.com/embed/mb2187ZQtBE?si=QSKNcq6Hg-EyaJ-x",
       ReleaseDate: "Aprial 12, 2024",
       Runtime: "2h ",
       Director:"Nora Ephron ",
       Writer: "Mike White ",
     },
     
     17: {  
       title: "Grave of the Fireflies",
       description: "Grave of the Fireflies is a heart-wrenching animated film about the struggles of two siblings trying to survive in war-torn Japan. A poignant tale of loss, survival, and sibling love, this film is both emotionally powerful and visually stunning. ",
       genre1: "Animation",
       genre2: "War",
       genre3: "Drama",
       poster: "/movies/Grave of the Fireflies.jpg",
       background: "/movieBackground/Grave%20of%20the%20Fireflies.jpg",
       youtubleLink:"https://www.youtube.com/embed/lhlh7JVcTt8?si=PEviVJanEF8R03Mo",
       ReleaseDate: "April 15, 2024",
       Runtime: "2h 30m",
       Director:"Isao Takahata ",
       Writer: "Isao Takahata ",
      },
     
     18: {  
       title: "The Green Mile", 
       description: "The Green Mile is a touching drama set in a prison, where an extraordinary man with a mysterious gift changes the lives of those around him. A heartwarming and emotional film, it explores themes of justice, mercy, and the supernatural in a way that resonates deeply with viewers. ",
       genre1: "Adventure", 
       genre2: "Drama", 
       genre3: "Fantasy", 
       poster: "/movies/The Green Mile.jpg" ,
       background: "/movieBackground/The%20Green%20Mile.jpg",
       youtubleLink:"https://www.youtube.com/embed/Ki4haFrqSrw?si=hFCttnKn-p-C-kRv",
       ReleaseDate: " December 17, 2022",
       Runtime: "3h 15m",
       Director:" Frank Darabont",
       Writer: "Frank Darabont ",
      },
     
     19: {  
       title: "Bagman", 
       description: "Bagman is a thrilling romance-drama that follows a man who becomes entangled in a dangerous criminal underworld while trying to protect his loved ones. A high-stakes thriller that combines drama, suspense, and romance, this film is full of unexpected twists and emotional moments. ",
       genre1: "Romance", 
       genre2: "Drama", 
       genre3: "Thriller", 
       poster: "/movies/Bagman.jpg",
       background: "/movieBackground/Bagman.jpeg",
       youtubleLink:"https://www.youtube.com/embed/slrzCgYIUPM?si=E7wrdQenvzus2BNY",
       ReleaseDate: "June 15, 2024",
      Runtime: "2h 15m",
      Director:"Martin Scorsese ",
      Writer: "Jesse Eisenberg ",
      },
     
     20: {  
       title: "Werewolves",
       description: "Werewolves is a fantasy-horror film that follows a group of people caught in a battle for survival when a pack of werewolves terrorizes a small town. With intense action and supernatural horror, this film combines family-friendly elements with chilling moments. ",
       genre1: "Family", 
       genre2: "Horror", 
       genre3: "Fantasy", 
       poster: "/movies/Werewolves.jpg",
       background: "/movieBackground/Werewolves.jpg",
       youtubleLink:"https://www.youtube.com/embed/iAAUDfGSdqs?si=8b_m7BJi07XqYZNh",
       ReleaseDate: "October 22, 2022",
      Runtime: "2h 5m",
      Director:"  Wes Craven",
      Writer: "Scott Silver ",
      },
     
     21: {  
       title: "Oppenheimer", 
       description: " Oppenheimer is a biography-drama about the life of J. Robert Oppenheimer, the man behind the atomic bomb. A powerful and thought-provoking film, it delves into the moral and ethical questions surrounding the development of nuclear weapons and their impact on history ",
       genre1: "Adventure", 
       genre2: "Biography", 
       genre3: "Drama", 
       poster: "/movies/Oppenheimer.jpg",
       background: "/movieBackground/oppenheminar.jpeg",
       youtubleLink:"https://www.youtube.com/embed/uYPbbksJxIg?si=BRYKp2JHZ-jK3nu4",
       ReleaseDate: "September 7, 2023",
       Runtime: "2h 30m",
       Director:"Christopher Nolan ",
       Writer: "Christopher Nolan ",
      },
     
     22: {  
       title: "The Dark Knight",
       description: " The Dark Knight is an action-packed crime drama about Batman’s ongoing battle against crime in Gotham City. Featuring iconic characters and thrilling action sequences, this film explores the moral dilemmas faced by both the hero and his foes. A cinematic masterpiece that redefines the superhero genre. ",
       genre1: "Family", 
       genre2: "Action", 
       genre3: "Crime", 
       poster: "/movies/The Dark Knight.jpg",
       background: "/movieBackground/The%20Dark%20Knight.jpg",
       youtubleLink:"https://www.youtube.com/embed/EXeTwQWrcwY?si=F7XeR7NtC5mLG1kf",
       ReleaseDate: "January 15, 2025",
      Runtime: "2h 40m",
      Director:"Christopher Nolan ",
      Writer: "Jonathan Nolan  ",
     },
     
     23: {  
       title: "Ferry 2", 
       description: " Ferry 2 is a crime-thriller about a notorious criminal returning to his roots for one final job. With twists and turns, this gripping story delves into the world of crime, loyalty, and betrayal. A fast-paced thriller with high-stakes drama. ",
       genre1: "Adventure", 
       genre2: "Crime", 
       genre3: "Thriller", 
       poster: "/movies/Ferry2.jpg" ,
       background: "/movieBackground/Ferry21.jpg",
       youtubleLink:"https://www.youtube.com/embed/DQ3fSBus-HU?si=lm89mxHj6FPT4LrY",
       ReleaseDate: "March 1, 2024",
      Runtime: "1h",
      Director:"Ruben Vermeersch ",
      Writer: "Christopher Nolan ",
     },
     
     24: {  
       title: "The Return",
       description: "The Return is a fantasy drama that follows a group of people on a quest to bring someone back from the dead. Filled with adventure, mystery, and heartfelt moments, this film explores themes of love, loss, and the cost of bringing back the past. ", 
       genre1: "Family", 
       genre2: "Fantasy", 
       genre3: "Drama", 
       poster: "/movies/The Return.jpg" ,
       background: "/movieBackground/The%20Return.jpg",
       youtubleLink:"https://www.youtube.com/embed/lrZqQBA9v3Q?si=e2hat-B6B7F1FK8c",
       ReleaseDate: "December 12, 2024",
      Runtime: "2h 45m",
      Director:" Benedict Andrews",
      Writer: "Todd Phillips  ",
     },
     
     25: {  
       title: "Joker", 
       description: "Joker is a gritty drama about the transformation of a man into one of the most iconic villains in comic book history. This intense film explores the psychological descent into madness and the consequences of society’s neglect, making it a dark and compelling story about the origin of the Joker. ",
        genre1: "Adventure", 
        genre2: "Crime", 
        genre3: "Drama", 
        poster: "/movies/Joker.jpg" ,
        background: "/movieBackground/Joker.jpg",
        youtubleLink:"https://www.youtube.com/embed/zAGVQLHvwOY?si=4pczqi_ZBMMQnnuB",
        ReleaseDate: "March 21, 2024",
        Runtime: "2h 15m",
        Director:"Todd Phillips ",
        Writer: "Scott Silver ",
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

  const handleBookSeatClick = () => {
    setShowBookingParagraph(true);
  
    if (bookingSectionRef.current) {

      bookingSectionRef.current.scrollIntoView({ behavior: "smooth" });

      setTimeout(() => {
        const headerHeight = document.querySelector("header").offsetHeight; 
        window.scrollBy(0, -(headerHeight+10));
      }, 500); 
    }
  };
  
  
  return (
     <div>
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
      
        <h1>{movieDetails.title}</h1>
        <h5 className="movie-genre">{movieDetails.genre1}</h5>
        <h5 className="movie-genre">{movieDetails.genre2}</h5>
        <h5 className="movie-genre">{movieDetails.genre3}</h5>
        <br /> <br /> <br />

  
        <div className="play-trailer-container">
            <button className="play-button" onClick={handlePlayButtonClick}>
               <i className="fa fa-play" aria-hidden="true"></i>
             </button>

             <div className="watch-trailer-text-container">
                <h5 className="watch-trailer-text">Watch</h5>
                <h5 className="watch-trailer-text">Trailer</h5>
              </div>

             <button className="book-seat-button" onClick={handleBookSeatClick}>
                 <i className="fa fa-ticket" aria-hidden="true"></i> 
             </button>
            <div className="watch-trailer-text-container">
                  <h5 className="watch-trailer-text">Book</h5>
                   <h5 className="watch-trailer-text">Seat</h5>
            </div>
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
      <div class="overview">
          <h2>Overview</h2>
          <p class="description">{movieDetails.description}</p>

             <br />
       <div class="details common-styles">
            <p>Release Date: <span class="release-date-value">{movieDetails.ReleaseDate}</span></p>
           <p>Runtime: <span class="release-date-value">{movieDetails.Runtime}</span></p>
       </div>

      <div class="details common-styles">
            <p>Director: <span class="release-date-value">{movieDetails.Director}</span></p>
      </div>

      <div class="writer common-styles">
            <p>Writer: <span class="release-date-value">{movieDetails.Writer}</span></p>
      </div>
    </div>
    </div>
    </div>
    {showBookingParagraph && (
        <div ref={bookingSectionRef}>
          <BookingInfo movieTitle={movieDetails.title} />
        </div>
      )}

      <br /><br/>
    </div>
   
  );
};
export default MovieDescription;  
