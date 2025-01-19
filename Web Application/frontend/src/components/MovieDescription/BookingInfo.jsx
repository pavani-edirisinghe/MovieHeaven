import React, { useState } from "react";
import { FaCouch } from "react-icons/fa"; // FontAwesome Sofa Icon
import "./BookingInfo.css";

const BookingInfo = ({ movieTitle }) => {
  const [selectedSeats, setSelectedSeats] = useState([]);

  // Function to handle seat selection
  const toggleSeatSelection = (seat) => {
    setSelectedSeats((prevSeats) =>
      prevSeats.includes(seat)
        ? prevSeats.filter((s) => s !== seat) // Remove seat if already selected
        : [...prevSeats, seat] // Add seat to selected seats
    );
  };

  // Define the number of seats in each row
  const seatLayout = [
    9,  // Row 1 (10 seats)
    9,  // Row 2 (10 seats)
    14, // Row 3 (14 seats)
    14, // Row 4 (14 seats)
    14, // Row 5 (14 seats)
    14, // Row 6 (14 seats)
    14, // Row 7 (14 seats)
    14, // Row 8 (14 seats)
    12, // Row 9 (12 seats)
    12  // Row 10 (12 seats)
  ];

  // Create seats based on the layout
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
      <h2>Booking Information</h2>
      <p>
        You can now proceed to book your seat for the movie{" "}
        <strong>{movieTitle}</strong>. Thank you for choosing us!
      </p>

      <div className="seat-selection">
        <h3>Select Your Seat</h3>
        <div className="seats-grid">
          {seats.map((row, rowIndex) => {
            // For rows 3 through 8 (indexes 2 through 7), split into two columns
            if (rowIndex >= 2 && rowIndex <= 7) {
              return (
                <div className="seat-row seat-row-split" key={rowIndex}>
                  <div className="left-column">
                    {row.slice(0, Math.floor(row.length / 2)).map((seat) => (
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
                    {row.slice(Math.floor(row.length / 2)).map((seat) => (
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

            // For rows 9 and 10, split with a 3-square gap in the center
            if (rowIndex >= 8) {
              return (
                <div className="seat-row seat-row-split-wide" key={rowIndex}>
                  <div className="left-column">
                    {row.slice(0, Math.floor(row.length / 2) - 1).map((seat) => (
                      <div
                        key={seat}
                        className={`seat ${selectedSeats.includes(seat) ? "selected" : ""}`}
                        onClick={() => toggleSeatSelection(seat)}
                      >
                        <FaCouch className="sofa-icon" />
                      </div>
                    ))}
                  </div>

                  {/* Middle space */}
                  <div className="middle-space"></div>

                  <div className="right-column">
                    {row.slice(Math.floor(row.length / 2) + 1).map((seat) => (
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

            // For other rows, render normally
            return (
              <div className="seat-row" key={rowIndex}>
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
    </div>
  );
};

export default BookingInfo;
