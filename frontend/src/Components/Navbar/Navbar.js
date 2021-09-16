import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';
import Logo from '../../imagens/Logo.png';
import Perfil from '../../imagens/Perfil.png'
import Sair from '../../imagens/Sair.png'

const Navbar = () => {
  return (    
    <div className="navbar">
      <img src={Logo} className="logoNavbar" alt="Logo"/>
      <span className="agendarMob"><Link to="/Agendar">AGENDAR</Link></span>
      <span className="meusAgendamentosMob"><Link to="/MeusAgendamentos">MEUS AGENDAMENTOS</Link></span>  
      <img src={Perfil} className="perfilMob" alt="Perfil"/>
      {/* <span className="perfilMob">PERFIL</span> */}
      <img src={Sair} className="sairMob" alt="Sair"/>
      {/* <span className="sairMob">SAIR</span> */}
    </div>
  );
};

export default Navbar;