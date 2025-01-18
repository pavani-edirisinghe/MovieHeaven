const express = require('express');
const app = express();

const seats = [
  { id: 1, row: 'A', number: 1, is_booked: false },
  { id: 2, row: 'A', number: 2, is_booked: false },
  { id: 3, row: 'A', number: 3, is_booked: true },
  // Add more seat data here...
];

app.get('/seats', (req, res) => {
  res.json(seats); // Send seat data to the frontend
});

app.listen(3001, () => {
  console.log('Server running on http://localhost:3001');
});
