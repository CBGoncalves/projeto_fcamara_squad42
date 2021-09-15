import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';
import Logo from '../../imagens/Logo.png';

const Navbar = () => {
  return (    
    <div className="navbar">
      <img src={Logo} className="logoNavbar" alt="Logo"/>
      <span><Link to="/Agendar">AGENDAR</Link></span>
      <span><Link to="/MeusAgendamentos">MEUS AGENDAMENTOS</Link></span>      
      <span>PERFIL</span>
      <span>LOGOUT</span>
    </div>
  );
};

export default Navbar;