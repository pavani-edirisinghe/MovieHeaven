import React, { useState, useEffect } from "react";
import { FaCouch } from "react-icons/fa";
import { useNavigate } from "react-router-dom";
import { useAuth } from "../../context/AuthContext";
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";
import "./BookingInfo.css";
import { FaCalendarAlt } from "react-icons/fa";
import "react-datepicker/dist/react-datepicker.css";
import { format } from "date-fns";

const BookingInfo = ({ movieTitle }) => {
  const [selectedSeats, setSelectedSeats] = useState([]);
  const [selectedTime, setSelectedTime] = useState("");
  const [selectedDate, setSelectedDate] = useState(null);
  const [showtimeSelected, setShowtimeSelected] = useState(false);
  const [bookingConfirmed, setBookingConfirmed] = useState(false);
  const [showMessage, setShowMessage] = useState(false);
  const [bookingDetails, setBookingDetails] = useState(null);
  const [confirmedSeats, setConfirmedSeats] = useState([]);
  const [showConfirmationModal, setShowConfirmationModal] = useState(false);
  const [showDeleteConfirmationModal, setShowDeleteConfirmationModal] = useState(false);
  const [showUpdateConfirmationModal, setShowUpdateConfirmationModal] = useState(false);
  const [paymentConfirmed, setPaymentConfirmed] = useState(false);
  const [bookedSeats, setBookedSeats] = useState([]);
  const [showPaymentConfirmationModal, setShowPaymentConfirmationModal] = useState(false);

  const { isLoggedIn } = useAuth();
  const navigate = useNavigate();

  const toggleSeatSelection = (seat) => {
    if (!selectedDate) {
      setShowMessage("Please select a date first!");
      return;
    }

    if (!selectedTime) {
      setShowMessage("Please select a showtime!");
      return;
    }

    if (bookedSeats.includes(seat)) {
      alert("This seat is already booked. Please select another seat.");
      return;
    }

    setSelectedSeats((prevSeats) =>
      prevSeats.includes(seat)
        ? prevSeats.filter((s) => s !== seat)
        : [...prevSeats, seat]
    );
  };

  const CustomDatePickerInput = ({ value, onClick }) => (
    <div className="custom-date-picker-input" onClick={onClick}>
      <input
        type="text"
        value={value}
        readOnly
        className="date-picker-input"
        placeholder="Select a date"
      />
      <FaCalendarAlt className="calendar-icon" />
    </div>
  );

  const handleShowtimeSelection = (time) => {
    setSelectedTime(time);
    setShowtimeSelected(true);
  
    const formattedDate = format(selectedDate, "yyyy-MM-dd"); 
  
    fetch(`http://localhost:5148/api/booked-seats?movieTitle=${movieTitle}&showtime=${time}&selectedDate=${formattedDate}`)
      .then(response => response.json())
      .then(data => {
        setBookedSeats(data.bookedSeats);
      })
      .catch(error => {
        console.error("Error fetching booked seats:", error);
      });
  };

  const handleDateChange = (date) => {
    setSelectedDate(date);
    setSelectedTime("");
    setShowtimeSelected(false);
    setSelectedSeats([]);
  };

  const isSeatAvailable = (seat) => {
    return !bookedSeats.includes(seat);
  };

  const handleConfirmBooking = () => {
    if (!isLoggedIn) {
      alert("You need to log in first.");
      navigate("/login");
      return;
    }

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
        date: selectedDate,
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
      setSelectedDate(null);
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
    setShowPaymentConfirmationModal(true);
  };

  const handlePaymentConfirmation = () => {
    setShowPaymentConfirmationModal(false);
  
    const formattedDate = format(selectedDate, "yyyy-MM-dd"); 
  
    const bookingData = {
      movieTitle: movieTitle,
      showtime: selectedTime,
      selectedDate: formattedDate, 
      seats: selectedSeats,
      totalPrice: selectedSeats.length * 400,
    };
  
    console.log("Sending to backend:", bookingData); 
  
    fetch('http://localhost:5148/api/bookings', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(bookingData),
    })
      .then(response => response.json())
      .then(data => {
        setPaymentConfirmed(true);
        setBookedSeats((prev) => [...prev, ...selectedSeats]);
        alert("Payment successful! Thank you for your purchase.");
      })
      .catch((error) => {
        console.error('Error:', error);
      });
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
                              ${bookedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
                            onClick={() => toggleSeatSelection(seat)}
                            style={{ cursor: bookedSeats.includes(seat) ? "not-allowed" : "pointer" }}
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
                              ${bookedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
                            onClick={() => toggleSeatSelection(seat)}
                            style={{ cursor: bookedSeats.includes(seat) ? "not-allowed" : "pointer" }}
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
                              ${bookedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
                            onClick={() => toggleSeatSelection(seat)}
                            style={{ cursor: bookedSeats.includes(seat) ? "not-allowed" : "pointer" }}
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
                              ${bookedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
                            onClick={() => toggleSeatSelection(seat)}
                            style={{ cursor: bookedSeats.includes(seat) ? "not-allowed" : "pointer" }}
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
                              ${bookedSeats.includes(seat) ? "gray-seat1" : ""}
                              ${selectedSeats.includes(seat) ? "selected" : ""}`}
                            onClick={() => toggleSeatSelection(seat)}
                            style={{ cursor: bookedSeats.includes(seat) ? "not-allowed" : "pointer" }}
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
          <div className="date-selection">
           <label htmlFor="date" className="date-label">Select a Date:</label>
              <DatePicker
                 selected={selectedDate}
                 onChange={handleDateChange}
                 minDate={new Date()}
                 maxDate={new Date(new Date().setDate(new Date().getDate() + 5))}
                 dateFormat="yyyy-MM-dd"
                 customInput={<CustomDatePickerInput />}
               />
           </div>

          <div className="showtime-selection">
            <label htmlFor="showtime" className="showtime-label">Select a Show Time:</label>
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

          {!paymentConfirmed ? (
            <div className="booking-summary">
              <h2>Booking Summary</h2>
              <p>
                Movie: <strong>{movieTitle}</strong>
              </p>
              <p>
                Date: <strong>{selectedDate ? selectedDate.toDateString() : "Not selected"}</strong>
              </p>
              <p>
                Show Time: <strong>{selectedTime || "Not selected"}</strong>
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
          ) : (
            <div className="payment-success-message">
              <h2>Payment Successful!</h2>
              <p>Thank you for your purchase. Enjoy the movie!</p>
            </div>
          )}

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
        </div>
      </div>

      {showMessage && (
        <div className="message-box">
          <p>{showMessage}</p><br />
          <button onClick={closeMessageBox}>OK</button>
        </div>
      )}

      {showConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <div className="modal-text">
              <h3>Confirm Booking?</h3>
              <p>Are you sure you want to confirm your booking?</p>
            </div>
            <div className="modal-buttons">
              <button className="no-button" onClick={() => handleConfirmation(false)}>
                No
              </button>
              <button className="yes-button" onClick={() => handleConfirmation(true)}>
                Yes
              </button>
            </div>
          </div>
        </div>
      )}

      {showDeleteConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <div className="modal-text">
              <h3>Delete Booking?</h3>
              <p>Are you sure you want to delete your booking?</p>
            </div>
            <div className="modal-buttons">
              <button className="no-button" onClick={() => handleDeleteConfirmation(false)}>
                No
              </button>
              <button className="yes-button" onClick={() => handleDeleteConfirmation(true)}>
                Yes
              </button>
            </div>
          </div>
        </div>
      )}

      {showPaymentConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <div className="modal-text">
              <h3>Confirm Payment?</h3>
              <p>Are you sure you want to proceed with the payment?</p>
            </div>
            <div className="modal-buttons">
              <button className="no-button" onClick={() => setShowPaymentConfirmationModal(false)}>
                No
              </button>
              <button className="yes-button" onClick={handlePaymentConfirmation}>
                Yes
              </button>
            </div>
          </div>
        </div>
      )}

     
      {showUpdateConfirmationModal && (
        <div className="confirmation-modal">
          <div className="confirmation-modal-content">
            <div className="modal-text">
              <h3>Update Booking?</h3>
              <p>Are you sure you want to update your booking?</p>
            </div>
            <div className="modal-buttons">
              <button className="no-button" onClick={() => handleUpdateConfirmation(false)}>
                No
              </button>
              <button className="yes-button" onClick={() => handleUpdateConfirmation(true)}>
                Yes
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default BookingInfo;