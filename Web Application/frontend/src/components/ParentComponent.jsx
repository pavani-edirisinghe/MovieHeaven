import React from "react";
import { useNavigate } from "react-router-dom";
import { useAuth } from "./../context/AuthContext";
import BookingInfo from "./MovieDescription/BookingInfo";

const ParentComponent = () => {
  const { isLoggedIn } = useAuth(); 
  const navigate = useNavigate(); 

  return (
    <div>
      <BookingInfo movieTitle="Example Movie" isLoggedIn={isLoggedIn} navigate={navigate} />
    </div>
  );
};

export default ParentComponent;