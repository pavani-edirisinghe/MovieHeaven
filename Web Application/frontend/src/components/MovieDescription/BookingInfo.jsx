import React, { useState } from "react";
import { FaCouch } from "react-icons/fa";
import "./BookingInfo.css";

const BookingInfo = ({ movieTitle }) => {
  const [selectedSeats, setSelectedSeats] = useState([]);
  const [selectedTime, setSelectedTime] = useState("");
  const [showtimeSelected, setShowtimeSelected] = useState(false);
  const [bookingConfirmed, setBookingConfirmed] = useState(false);
  const [showMessage, setShowMessage] = useState(false);
  const [bookingDetails, setBookingDetails] = useState(null);
  const [confirmedSeats, setConfirmedSeats] = useState([]);
  const [showConfirmationModal, setShowConfirmationModal] = useState(false);
  const [showDeleteConfirmationModal, setShowDeleteConfirmationModal] = useState(false);
  const [showUpdateConfirmationModal, setShowUpdateConfirmationModal] = useState(false);
  const [paymentConfirmed, setPaymentConfirmed] = useState(false);

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
      alert("Please select at least one seat.");
      return;
    }

    setShowConfirmationModal(true);
  };

  const handleConfirmation = (confirmed) => {
    setShowConfirmationModal(false);

    if (confirmed) {
      const newBooking = {
        movie: movieTitle,
        showtime: selectedTime,
        seats: selectedSeats,
        totalPrice: selectedSeats.length * 400,
      };

      setBookingDetails(newBooking);
      setBookingConfirmed(true);
      setConfirmedSeats((prev) => [...prev, ...selectedSeats]); 

      console.log("Booking confirmed:", newBooking);

      setTimeout(() => {
        alert("Booking confirmed successfully!");
      }, 0);
    } else {
      setTimeout(() => {
        alert("Booking not confirmed.");
      }, 0);
    }
  };

  const handleDeleteConfirmation = (confirmed) => {
    setShowDeleteConfirmationModal(false);

    if (confirmed) {
      setSelectedSeats([]);
      setSelectedTime("");
      setShowtimeSelected(false);
      setBookingConfirmed(false);
      setBookingDetails(null);
      setConfirmedSeats([]);
      setPaymentConfirmed(false); 

      setTimeout(() => {
        alert("Your booking has been deleted.");
      }, 0);
    } else {
      setTimeout(() => {
        alert("Deletion canceled.");
      }, 0);
    }
  };

  const handleUpdateBooking = () => {
    setShowUpdateConfirmationModal(true);
  };

  const handleUpdateConfirmation = (confirmed) => {
    setShowUpdateConfirmationModal(false);

    if (confirmed) {
      setBookingConfirmed(false);
      setConfirmedSeats((prev) => prev.filter((seat) => !bookingDetails.seats.includes(seat)));
      setSelectedSeats(bookingDetails.seats);
      setTimeout(() => {
        alert("Booking updated successfully!");
      }, 0);
    } else {
      setTimeout(() => {
        alert("Update canceled.");
      }, 0);
    }
  };

  const handlePayNow = () => {
    setPaymentConfirmed(true); // Mark payment as confirmed
    setTimeout(() => {
      alert("Payment successful! Thank you for your purchase.");
    }, 0);
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
                            className={`seat 
                              ${confirmedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
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
                            className={`seat 
                              ${confirmedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
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
                            className={`seat 
                              ${confirmedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
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
                            className={`seat 
                              ${confirmedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
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
                        className={`seat 
                          ${confirmedSeats.includes(seat) ? "gray-seat1" : ""}
                          ${selectedSeats.includes(seat) ? "selected" : ""}`}
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

          {/* Conditionally render booking summary */}
          {!paymentConfirmed && (
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
          )}

          {/* Conditionally render action buttons */}
          {!paymentConfirmed && (
            <div className="action-buttons">
              {showtimeSelected && selectedSeats.length > 0 && !bookingConfirmed && (
                <button className="action-button confirm" onClick={handleConfirmBooking}>
                  Confirm Booking
                </button>
              )}
              {bookingConfirmed && (
                <>
                  <button className="action-button update" onClick={handleUpdateBooking}>Update Booking</button>
                  <button className="action-button delete" onClick={() => setShowDeleteConfirmationModal(true)}>
                    Delete Booking
                  </button>
                  <button className="action-button pay" onClick={handlePayNow}>Pay Now</button>
                </>
              )}
            </div>
          )}

          {/* Show a message after payment is confirmed */}
          {paymentConfirmed && (
            <div className="payment-success-message">
              <h2>Payment Successful!</h2>
              <p>Thank you for your purchase. Enjoy the movie!</p>
            </div>
          )}
        </div>
      </div>

      {showMessage && (
        <div className="message-box">
          <p>Please select a showtime first!</p><br />
          <button onClick={closeMessageBox}>OK</button>
        </div>
      )}

      {showConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <p>Are you sure you want to confirm your booking?</p>
            <button className="yes-button" onClick={() => handleConfirmation(true)}>
              Yes
            </button>
            <button className="no-button" onClick={() => handleConfirmation(false)}>
              No
            </button>
          </div>
        </div>
      )}

      {showDeleteConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <p>Are you sure you want to delete your booking?</p>
            <button className="yes-button" onClick={() => handleDeleteConfirmation(true)}>
              Yes
            </button>
            <button className="no-button" onClick={() => handleDeleteConfirmation(false)}>
              No
            </button>
          </div>
        </div>
      )}

      {showUpdateConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <p>Are you sure you want to update your booking?</p>
            <button className="yes-button" onClick={() => handleUpdateConfirmation(true)}>
              Yes
            </button>
            <button className="no-button" onClick={() => handleUpdateConfirmation(false)}>
              No
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default BookingInfo;