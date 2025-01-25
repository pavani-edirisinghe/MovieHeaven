import React, { useState } from "react";
import { FaCouch } from "react-icons/fa";
import "./BookingInfo.css";

const BookingInfo = ({ movieTitle }) => {
  const [selectedSeats, setSelectedSeats] = useState([]);
  const [selectedTime, setSelectedTime] = useState(""); 
  const [showtimeSelected, setShowtimeSelected] = useState(false); 
  const [bookingConfirmed, setBookingConfirmed] = useState(false); 
  const [showMessage, setShowMessage] = useState(false); 

  const toggleSeatSelection = (seat) => {

    if (!showtimeSelected) {
      setShowMessage(true); 
      return; 
    }

    setSelectedSeats((prevSeats) =>
      prevSeats.includes(seat)
        ? prevSeats.filter((s) => s !== seat)
        : [...prevSeats, seat]
    );
  };

  const handleShowtimeSelection = (time) => {
    setSelectedTime(time);
    setShowtimeSelected(true);
  };

  const handleConfirmBooking = () => {
    if (selectedSeats.length === 0) {
      setMessage("Please select at least one seat.");
      return;
    }
    setBookingConfirmed(true);
  };

  const closeMessageBox = () => {
    setShowMessage(false);
  };

    const convertSeatToLabel = (seat) => {
      const [row, seatNumber] = seat.split('-');
      const rowLetter = String.fromCharCode(65 + parseInt(row) - 1);
      return `${rowLetter}${seatNumber}`;
    };
  
  const seatLayout = [9, 9, 14, 14, 14, 14, 14, 14, 12, 12];
  const seats = seatLayout.map((numSeats, rowIndex) => {
    const rowSeats = [];
    for (let i = 0; i < numSeats; i++) {
      const seatId = `${rowIndex + 1}-${i + 1}`;
      rowSeats.push(seatId);
    }
    return rowSeats;
  });

  const availableTimes = ["8:00 AM", "11:00 AM", "2:00 PM", "6:00 PM", "8:00 PM"];

  return (
    <div className="booking-section">
      <h1>Book Your Seat</h1>
      <p style={{ fontSize: "20px" }}>
  You can now proceed to book your seat for the movie{" "}
  <strong>{movieTitle}</strong>. Thank you for choosing us!
</p>

      <div className="content-container">
        <div className="left-column1">
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

                 const rowLetter = String.fromCharCode(65 + rowIndex);

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

          <div className="curve" />
          <div className="screen-text">SCREEN</div>
        </div>

        <div className="right-column1">
          <div className="showtime-selection">
            <label htmlFor="showtime" className="showtime-label">Select a ShowTime:</label>
            <div className="showtime-buttons">
              {availableTimes.map((time) => (
                <button
                  key={time}
                  className={`showtime-button ${selectedTime === time ? "selected" : ""}`}
                  onClick={() => handleShowtimeSelection(time)}
                >
                  {time}
                </button>
              ))}
            </div>
          </div>

          <div className="booking-summary">
            <h2>Booking Summary</h2>
            <p>
              Movie: <strong>{movieTitle}</strong>
            </p>
            <p>
              Showtime: <strong>{selectedTime || "Not selected"}</strong>
            </p>
            <p>
              Selected Seats: <strong>
                {selectedSeats.length > 0
                  ? selectedSeats.map((seat) => convertSeatToLabel(seat)).join(", ")
                  : "None"}
              </strong>
            </p>
            <p>
              Price: <strong>Rs. 400 * {selectedSeats.length} = Rs. {selectedSeats.length * 400}</strong>
            </p>
          </div>

          <div className="action-buttons">

            {showtimeSelected && selectedSeats.length > 0 && !bookingConfirmed && (
              <button className="action-button confirm" onClick={handleConfirmBooking}>
                Confirm Booking
              </button>
            )}
            {bookingConfirmed && (
              <>
                <button className="action-button update">Update Booking</button>
                <button className="action-button confirm">Confirm Booking</button>
                <button className="action-button delete">Delete Booking</button>
              </>
            )}
          </div>
        </div>
      </div>

      {showMessage && (
        <div className="message-box">
          <p>Please select a showtime first!</p><br />
          <button onClick={closeMessageBox}>OK</button>
        </div>
      )}
    </div>
  );
};

export default BookingInfo;