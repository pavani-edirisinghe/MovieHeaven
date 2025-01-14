import React from "react";
import "./About.css";
import 'remixicon/fonts/remixicon.css';
import 'bootstrap-icons/font/bootstrap-icons.css';

const AboutSection = () => {
  return (
    <>
      <section id="about" className="about">
        <div className="container-1">
          <div className="section-title">
            
            <h3>
              We are &nbsp; <span>Movie Heaven</span>
            </h3>
            <h4>The Ultimate Destination for Movie Lovers</h4>
          </div>
        </div>

        <div class="row content">
  <div class="col-left">
    <p>
      Movie Heaven is a renowned movie theater that has been delighting movie lovers for over a decade. Founded by Ms. Edirisinghe, 
      Movie Heaven started as a small cinema and has grown into a state-of-the-art entertainment hub. The theater offers a wide variety of films,
      from the latest blockbusters to classic favorites, ensuring there's something for everyone. With luxurious seating, cutting-edge sound and
      projection systems, and top-tier customer service, Movie Heaven provides an unforgettable movie-watching experience.
      Whether you're here for a casual outing or a special movie night, Movie Heaven is your go-to destination for all things cinema.
    </p>
  </div>
  <div class="col-right">
    
      <h3>Vision</h3>
    
    <p>
      To become the ultimate movie destination worldwide, 
      offering an unparalleled cinematic experience that brings stories to life and creates lasting memories for all movie enthusiasts.
    </p>

   
      <h3>Mission & Our Values</h3>
   

    <ul>
      <li><i class="ri-check-double-line"></i> We are passionate about film and entertainment</li>
      <li><i class="ri-check-double-line"></i> We prioritize our customers' enjoyment and satisfaction</li>
      <li><i class="ri-check-double-line"></i> We ensure the highest quality in every screening, sound, and visual experience</li>
      <li><i class="ri-check-double-line"></i> We support and empower our employees, fostering a creative and dedicated team</li>
      <li><i class="ri-check-double-line"></i> We embrace the latest technologies to continuously enhance our theater experience</li>
    </ul>
  </div>
</div>

      </section>

      <div className="counts container">
        <div className="row">
          <div className="col-lg-3 col-md-6">
            <div className="count-box">
              <i className="bi bi-emoji-smile"></i>
              <span>1450</span>
              <p>Happy Clients</p>
            </div>
          </div>

          <div className="col-lg-3 col-md-6 mt-5 mt-md-0">
            <div className="count-box">
              <i className="bi bi-clock"></i>
              <span>18</span>
              <p>Years of experience</p>
            </div>
          </div>

          <div className="col-lg-3 col-md-6 mt-5 mt-lg-0">
            <div className="count-box">
              <i className="bi bi-award"></i>
              <span>28</span>
              <p>Awards</p>
            </div>
          </div>

          <div className="col-lg-3 col-md-6 mt-5 mt-lg-0">
            <div className="count-box">
              <i className="bi bi-clock"></i>
              <span
                data-purecounter-start="0"
                data-purecounter-end="1463"
                data-purecounter-duration="1"
                className="purecounter"
              ></span>
              <p>
                Opening Times
                <br />
                <br />
                Monday - Sunday: 9:00am - 7:00pm
              </p>
            </div>
          </div>
        </div>
      </div>

      <div className="map-container">
  <iframe
    title="Google Map"
    src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d63480.8374898179!2d80.17697731341235!3d6.055975780910134!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3ae173bb6932fce3%3A0x4a35b903f9c64c03!2sGalle!5e0!3m2!1sen!2slk!4v1669952452895!5m2!1sen!2slk"
    allowFullScreen
    loading="lazy"
    referrerPolicy="no-referrer-when-downgrade"
  ></iframe>
</div>

    </>
  );
};


export default AboutSection;
