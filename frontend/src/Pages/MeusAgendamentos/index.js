import React from 'react';
import { Link } from 'react-router-dom';
import Navbar from '../../Components/Navbar/Navbar'
import './style.css'; 

const Agendamento = () => {
  return (  
    <div className="container agendamentos">
      <Navbar />
      <h1>Meus agendamentos</h1>
      <div className="agendamentosQuadro"></div>
      <div className="notificacao">
        <input type="checkbox" id="notificacao" name="notificacao" ></input>
        <label for="notificacao"> Quero receber notificações para lembrar do meu pagamento</label>
      </div>
      <button><Link to="/Agendar">▶ AGENDAR MAIS</Link></button>
    </div>
  );
};

export default Agendamento;