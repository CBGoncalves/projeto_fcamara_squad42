import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';
import Logo from '../../imagens/Logo.png';

const Navbar = () => {
  return (    
    <div className="navbar">
      <img src={Logo} className="logoNavbar" alt="Logo"/>
      <span className="agendarMob"><Link to="/Agendar">AGENDAR</Link></span>
      <span className="meusAgendamentosMob"><Link to="/MeusAgendamentos">MEUS AGENDAMENTOS</Link></span>      
      <span className="perfilMob">PERFIL</span>
      <span className="sairMob">SAIR</span>
    </div>
  );
};

export default Navbar;