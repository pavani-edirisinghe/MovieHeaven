import React from "react";
import "./About.css";

const AboutSection = () => {
  return (
    <>
      {/* About Section */}
      <section id="about" className="about">
        <div className="container">
          <div className="section-title">
            <h2>About us</h2>
            <h3>
              We are <span>Salon Liyasara</span>
            </h3>
            <p>Professional in Hair Care and Beauty</p>
          </div>

          <div className="row content">
            <div className="col-lg-6">
              <p>
                Salon Liyasara network is a pioneer in its industry for more
                than a decade and now provides the best quality services to its
                customers. Mrs. Edirisinghe is the founder of the salon Liyasara
                network which started as a small-scale business organization and
                gradually developed to the position it is now. The salon provides
                services such as Skin Care, hair care, Nail care, dressmaking, and
                fashion designing.
              </p>
            </div>
            <div className="col-lg-6 pt-4 pt-lg-0">
              <u>
                <h3 >Vision</h3>
              </u>
              <p>
                To establish as the best salon network in the globe and to
                discover the true beauty of our clients by providing quality
                services
              </p>

              <u>
                <h3>Mission & Our Values</h3>
              </u>

              <ul>
                <li>
                  <i className="ri-check-double-line"></i> We are passionate
                  about our work
                </li>
                <li>
                  <i className="ri-check-double-line"></i> We are Customer
                  focused
                </li>
                <li>
                  <i className="ri-check-double-line"></i> We ensure the quality
                  of the work
                </li>
                <li>
                  <i className="ri-check-double-line"></i> We uplift our
                  employees
                </li>
                <li>
                  <i className="ri-check-double-line"></i> We are eager to
                  engage totally with the latest technologies
                </li>
              </ul>
            </div>
          </div>
        </div>
      </section>
      {/* End About Section */}

      {/* Counts Section */}
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
      {/* End Counts Section */}
    </>
  );
};

export default AboutSection;
