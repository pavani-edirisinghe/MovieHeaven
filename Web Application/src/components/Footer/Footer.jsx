import React from 'react';
import "./Footer.css";
import SocialLinks from './SocialLinks';


const Footer = () => {

  return (
    <footer id="footer">
      <div className="footer-top">
        <div className="container">
          <div className="row">
            <div className="col-lg-3 col-md-6 footer-contact">
              <img src="movieHeaven.png" alt="Movie Logo" width="120px" />
            </div>
            </div>

            <div className="col-lg-3 col-md-6 footer-contact">

              <h4>Movie Heaven</h4>
              <p>
                Wakwella Road,<br />
                Galle. <br /><br />
                <strong>Phone:</strong> +94771234657<br />
                <strong>Email:</strong> movieHeaven.com<br />
              </p>
            </div>

            <div className="col-lg-3 col-md-6 footer-links">
              <br />
              <h4>Useful Links</h4>
              <ul>
                <li><i className="bx bx-chevron-right"></i> <a href="#hero">Home</a></li>
                <li><i className="bx bx-chevron-right"></i> <a href="#about">About us</a></li>
                <li><i className="bx bx-chevron-right"></i> <a href="terms.html">Terms of service</a></li>
                <li><i className="bx bx-chevron-right"></i> <a href="privacy.html">Privacy policy</a></li>
              </ul>
            </div>
          </div>
        
      </div>

      <div className="container d-md-flex py-4 footer-bottom">
        <div className="me-md-auto text-center text-md-start footer-left">
          <div className="copyright">
            &copy; Copyright <strong><span>Movie Heaven</span></strong>. All Rights Reserved
          </div>
          <div className="credits">
            Designed by <a href="https://www.linkedin.com/in/pavani-edirisinghe-473295318">Pavani Edirisinghe</a>
          </div>
        </div>
        
        <div className="footer-right">
          <SocialLinks /> 
        </div>
      </div>

    
    </footer>

    
  );
};

export default Footer; 