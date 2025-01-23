import React from "react";
import "./Contact.css";

const ContactSection = () => {

  return (
    <section id="contact" className="contact">
  <div className="container-1">
    <div className="section-title">
      <h3>Got a&nbsp;<span> Question?</span></h3>
      <p>We’re Here to Help! </p> 
      <h5>The Art of Visual Effects in Today’s Movies</h5>
   </div>
</div>
<div className="container-1">
<div class="row mt-5">

<div class="col-lg-4">
  <div class="info">
  <div class="address">
      <i class="bi bi-geo-alt"></i>
      <h4>Location:</h4>
      <p>No.253,Wakwella Road,Galle.</p>
    </div>

    <div class="email">
      <i class="bi bi-envelope"></i>
      <h4>Email:</h4>
      <p>movieHeaven@gmail.com</p>
    </div>

    <div class="phone">
      <i class="bi bi-phone"></i>
      <h4>Call:</h4>
      <p>+94771234657</p>
    </div>

  </div>

</div>

<div class="col-lg-8 mt-5 mt-lg-0">

  <form action="forms/contact.php" method="post" role="form" class="php-email-form">
    <div class="row">
      <div class="col-md-6 form-group">
        <input type="text" name="name" class="form-control" id="name" placeholder="  Your Name" required />
      </div>
      <div class="col-md-6 form-group">
        <input type="email" class="form-control" name="email" id="email" placeholder="  Your Email" required />
      </div>
    </div>
    <br />
    <div class="form-group mt-3">
      <textarea class="form-control" name="message" rows="5" placeholder="Message" required></textarea>
    </div>
  
    <br />
    <div class="text-center"><button type="submit">Send Message</button></div>
  </form>

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


</div>
 
</section>


  );
};

export default ContactSection;



