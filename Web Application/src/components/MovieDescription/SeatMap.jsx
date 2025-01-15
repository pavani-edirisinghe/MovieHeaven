import React, { useState } from "react";

// Simulate seat data directly in the component (without a backend)
const initialSeats = [
  { id: 1, row: "A", number: 1, isBooked: false },
  { id: 2, row: "A", number: 2, isBooked: false },
  { id: 3, row: "A", number: 3, isBooked: true },
  { id: 4, row: "B", number: 1, isBooked: false },
  { id: 5, row: "B", number: 2, isBooked: false },
  { id: 6, row: "B", number: 3, isBooked: true },
  // Add more seats as needed
];

const SeatMap = () => {
  const [seats, setSeats] = useState(initialSeats);
  const [selectedSeats, setSelectedSeats] = useState([]);

  // Handle seat selection or deselection
  const handleSeatSelect = (seatId) => {
    const newSeats = [...seats];
    const seatIndex = newSeats.findIndex((seat) => seat.id === seatId);
    const seat = newSeats[seatIndex];

    // Only allow selecting available seats
    if (seat.isBooked) return;

    if (selectedSeats.includes(seatId)) {
      setSelectedSeats(selectedSeats.filter((id) => id !== seatId)); // Deselect seat
    } else {
      setSelectedSeats([...selectedSeats, seatId]); // Select seat
    }
  };

  return (
    <div className="seat-map">
      <div className="seats">
        {seats.map((seat) => (
          <div
            key={seat.id}
            className={`seat ${seat.isBooked ? "booked" : ""} ${
              selectedSeats.includes(seat.id) ? "selected" : ""
            }`}
            onClick={() => handleSeatSelect(seat.id)}
            style={{
              backgroundColor: seat.isBooked
                ? "red"
                : selectedSeats.includes(seat.id)
                ? "yellow"
                : "green",
            }}
          >
            {seat.row}{seat.number}
          </div>
        ))}
      </div>
    </div>
  );
};

export default SeatMap;
