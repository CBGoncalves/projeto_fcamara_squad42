import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';
import Logo from '../../imagens/Logo.png';
import sair from '../../imagens/logout_black_24dp.svg';
import perfil from '../../imagens/account_circle_black_24dp.svg'

const Navbar = () => {
  return (    
    <div className="navbar">
      <img src={Logo} className="logoNavbar" alt="Logo"/>
      <span className="agendarMob"><Link to="/Agendar">AGENDAR</Link></span>
      <span className="meusAgendamentosMob"><Link to="/MeusAgendamentos">MEUS AGENDAMENTOS</Link></span>      
      <span className="perfilMob"><img src={perfil}></img></span>
      <span className="sairMob"><img src={sair}></img></span>
      
    </div>
  );
};

export default Navbar;