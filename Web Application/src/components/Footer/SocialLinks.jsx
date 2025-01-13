import React from 'react';
import './Footer.css'; 

function SocialLinks() {
  return (
    <div className="social-links text-center text-md-right pt-3 pt-md-0">
      <a href="https://twitter.com" target="_blank" rel="noopener noreferrer" className="twitter">
        <i className="bx bxl-twitter"></i>
      </a>
      <a href="https://facebook.com" target="_blank" rel="noopener noreferrer" className="facebook">
        <i className="bx bxl-facebook"></i>
      </a>
      <a href="https://instagram.com" target="_blank" rel="noopener noreferrer" className="instagram">
        <i className="bx bxl-instagram"></i>
      </a>
      <a href="https://skype.com" target="_blank" rel="noopener noreferrer" className="google-plus">
        <i className="bx bxl-skype"></i>
      </a>
      <a href="https://linkedin.com" target="_blank" rel="noopener noreferrer" className="linkedin">
        <i className="bx bxl-linkedin"></i>
      </a>
    </div>
  );
}

export default SocialLinks;
