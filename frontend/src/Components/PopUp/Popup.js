import React from 'react';
import { Link } from 'react-router-dom';
import './Popup.css';
import Triste from '../../imagens/Triste.svg';
import Feliz from '../../imagens/Feliz.svg';


const Popup = () => {
  return (    
    <div className="popupContainer">
      <div className="popup">
        <button className="fechar">X</button>
        <div className="realizado">
          <img src={Feliz} className="feliz" alt="feliz"/>
          <p>Agendado com sucesso</p>
          <span>Desfazer</span>
        </div>
        <div className="naoRealizado ativo">
          <img src={Triste} className="triste" alt="triste"/>
          <p>Agendamento não realizado</p>
          <span>Lotado</span>
        </div>
        <span className="atalhoAgendamentos"><Link to="MeusAgendamentos">MEUS AGENDAMENTOS</Link></span>
      </div>
    </div>
  );
};

export default Popup;