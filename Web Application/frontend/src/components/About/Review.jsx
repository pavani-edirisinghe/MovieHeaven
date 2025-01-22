import React from 'react';
import './Review.css';

const ReviewSection = () => {
  const reviews = [
    {
      name: 'Kavindu Sanjaya',
      review: 'Amazing experience! The theater is top-notch, and the staff is friendly.',
      rating: 5,
      date: 'Jan 22, 2025',
      profileImage: './profiles/1.jpeg',
    },
    {
      name: 'Tharushi Navodi ',
      review: 'Great movie selection and comfortable seating. Highly recommend!',
      rating: 4,
      date: 'Jan 20, 2025',
      profileImage: './profiles/2.jpg',
    },
    {
      name: 'Tharindu Madushan',
      review: 'The ambiance is perfect for movie lovers. I will definitely return!',
      rating: 5,
      date: 'Jan 18, 2025',
      profileImage: './profiles/3.jpeg',
    },
    {
      name: 'Buddhima Diwyanjali ',
      review: 'Snacks were great, and the screen quality was superb!',
      rating: 4,
      date: 'Jan 15, 2025',
      profileImage: './profiles/4.jpeg',
    },
    {
      name: 'Sajith Pradeep',
      review: 'Perfect place for a weekend movie! Great seating arrangement.',
      rating: 5,
      date: 'Jan 12, 2025',
      profileImage: './profiles/5.jpeg',
    },
    {
      name: 'Wageesha Sewmini',
      review: 'Staff was very welcoming. Overall a good experience.',
      rating: 4,
      date: 'Jan 10, 2025',
      profileImage: './profiles/6.jpg',
    },
    {
      name: 'Nuwan Chathuranga',
      review: 'The prices are reasonable, and the experience is worth it.',
      rating: 5,
      date: 'Jan 8, 2025',
      profileImage: './profiles/7.jpeg',
    },
    {
      name: 'Sulochana Nawodi ',
      review: 'The seats were exceptionally clean and incredibly comfortable, making the experience enjoyable.',
      rating: 5,
      date: 'Jan 5, 2025',
      profileImage: './profiles/8.jpg',
    },
    {
      name: 'Maneesha Wishwani',
      review: 'An incredible experience with outstanding sound and breathtaking visuals that truly captivated me.',
      rating: 5,
      date: 'Jan 2, 2025',
      profileImage: './profiles/9.jpg',
    },
  ];

  return (
    <section className="review-section">
      <div className="review-title">
        <h2>What Our Customers Are Saying</h2>
      </div>
      <div className="reviews-container">
        {reviews.map((review, index) => (
          <div key={index} className="review-card">
            <div className="review-header">
              <div className="stars">
                {'⭐'.repeat(review.rating)}
              </div>
            </div>
            <p className="review-text">{review.review}</p>
            <div className="review-footer">
              <img src={review.profileImage} alt={`${review.name}'s profile`} className="profile-image" />
              <div className="review-details">
                <h4>{review.name}</h4>
                <p className="review-date">{review.date}</p>
              </div>
            </div>
          </div>
        ))}
      </div>
    </section>
  );
};

export default ReviewSection;
