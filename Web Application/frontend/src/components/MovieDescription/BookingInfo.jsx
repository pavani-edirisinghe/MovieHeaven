import React, { useState } from "react";
import { FaCouch } from "react-icons/fa"; 
import "./BookingInfo.css";

const BookingInfo = ({ movieTitle }) => {
  const [selectedSeats, setSelectedSeats] = useState([]);

const toggleSeatSelection = (seat) => {
  console.log("Toggling seat:", seat);
  setSelectedSeats((prevSeats) =>
    prevSeats.includes(seat)
      ? prevSeats.filter((s) => s !== seat) 
      : [...prevSeats, seat] 
  );
};

  const seatLayout = [
    9,  
    9,  
    14, 
    14, 
    14,
    14, 
    14, 
    14,
    12, 
    12 
  ];

  const seats = seatLayout.map((numSeats, rowIndex) => {
    const rowSeats = [];
    for (let i = 0; i < numSeats; i++) {
      const seatId = `${rowIndex + 1}-${i + 1}`;
      rowSeats.push(seatId);
    }
    return rowSeats;
  });

  return (
    <div className="booking-section">
      <h1>Book Your Seat</h1>
      <p>
        You can now proceed to book your seat for the movie{" "}
        <strong>{movieTitle}</strong>. Thank you for choosing us!
      </p>

      <div className="seat-selection">
  <div className="seat-legend">
    <div className="legend-item">
      <FaCouch className="sofa-icon gray-seat" />
      <span>Available</span>
    </div>
    <div className="legend-item">
      <FaCouch className="sofa-icon white-seat" />
      <span>Taken</span>
    </div>
    <div className="legend-item">
      <FaCouch className="sofa-icon brown-seat" />
      <span>Selected</span>
    </div>
  </div>

        <div className="seats-grid">
        {seats.map((row, rowIndex) => {
  if (rowIndex >= 2 && rowIndex <= 7) {
    const midIndex = Math.floor(row.length / 2); 
    return (
      <div className="seat-row seat-row-split" key={`row-${rowIndex}`}>
        <div className="left-column">
          {row.slice(0, midIndex).map((seat) => (
            <div
            key={seat}
            className={`seat ${selectedSeats.includes(seat) ? "selected" : ""}`}
            onClick={() => toggleSeatSelection(seat)}
          >
            <FaCouch className="sofa-icon" />
          </div>
          
          ))}
        </div>
        <div className="right-column">
          {row.slice(midIndex).map((seat) => (
            <div
              key={seat}
              className={`seat ${selectedSeats.includes(seat) ? "selected" : ""}`}
              onClick={() => toggleSeatSelection(seat)}
            >
              <FaCouch className="sofa-icon" />
            </div>
          ))}
        </div>
      </div>
    );
  }

if (rowIndex >= 8) {
  const midIndex = Math.floor(row.length / 2);  
  return (
    <div className="seat-row seat-row-split-wide" key={`row-${rowIndex}`}>
      <div className="left-column">
        {row.slice(0, midIndex).map((seat) => (
          <div
            key={seat}
            className={`seat ${selectedSeats.includes(seat) ? "selected" : ""}`}
            onClick={() => toggleSeatSelection(seat)}
          >
            <FaCouch className="sofa-icon" />
          </div>
        ))}
      </div>
      <div className="middle-space"></div>
      <div className="right-column">
        {row.slice(midIndex).map((seat) => ( 
          <div
            key={seat}
            className={`seat ${selectedSeats.includes(seat) ? "selected" : ""}`}
            onClick={() => toggleSeatSelection(seat)}
          >
            <FaCouch className="sofa-icon" />
          </div>
        ))}
      </div>
    </div>
  );
}

  return (
    <div className="seat-row" key={`row-${rowIndex}`}>
      {row.map((seat) => (
        <div
          key={seat}
          className={`seat ${selectedSeats.includes(seat) ? "selected" : ""}`}
          onClick={() => toggleSeatSelection(seat)}
        >
          <FaCouch className="sofa-icon" />
        </div>
      ))}
    </div>
  );
})}

        </div>
       
      </div>
      <div class ="curve" />
      <div class="screen-text">SCREEN</div> 
    </div>
    
  );
};

export default BookingInfo;
