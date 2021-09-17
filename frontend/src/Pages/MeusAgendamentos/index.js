import React, {useState, useEffect} from 'react';
import { Link } from 'react-router-dom';
import Navbar from '../../Components/Navbar/Navbar'
import imgDelete from "../../imagens/delete.svg";
import imgEdit from "../../imagens/lapis.svg";
import Logo from '../../imagens/Feliz.svg';
import './style.css'; 

export default function Agendamento() {
  const [ListAgendameto, setListAgendamento] = useState([]);

  useEffect(() => {
    listarAgendamento();
  }, []);

  const listarAgendamento = () => {
    fetch(`http://localhost:5000/Agendamento/`, {
      method: "GET"
    })
      .then((response) => response.json())
      .then((dados) => {
        setListAgendamento(dados);
      })
      .catch((err) => console.error(err));
  };

  const DeletarAgendamento = (idAgendamento) => {
    fetch(`http://localhost:5000/Agendamento/${idAgendamento}`, {
      method: "DELETE",
      headers: {
        "content-type": "application/json",
      },
    })
      .then((response) => response.json())
      .then((dados) => {
        alert(dados);
        listarAgendamento();
      })
      .catch((err) => console.error(err));
  };


  return (  
    <div className="container agendamentos">
      <Navbar />
      <h1>Meus agendamentos</h1>
      <div className="marginAgendamentos">
        {ListAgendameto.map((item) => {
          return (
            <div key={item.idAgendamento} className="agendamentoBox">
                <div className="agendamento">
                  <img
                    className="user"
                    src={Logo}
                    alt="Imagem agendamento"
                  />
                </div>
                
                  <div className="info">
                    <p>{item.idAgendamento}</p>
                    <p>|</p>
                    <p>{item.dataAgendamento}</p>
                    <p>|</p>
                    <p>São Paulo</p>
                    <p>|</p>
                    <p>Mesa</p>
                  </div>
              
              <div className="data">
                <div className="DeletarAgendamento" onClick={() => DeletarAgendamento(item.idAgendamento)}>
                <img
                    src={imgEdit}
                    className="Edit"
                    alt="Botão que edita o agendamento"
                  />
                  <img
                    src={imgDelete}
                    onClick={() => DeletarAgendamento(item.idAgendamento)}
                    className="Delete"
                    alt="Botão que deleta o agendamento"
                  />
                </div>
              </div>
            </div>
          );
        })}
      </div>
      
      
      <div className="notificacao">
        <input type="checkbox" id="notificacao" name="notificacao" ></input>
        <label for="notificacao"> Quero receber notificações para lembrar do meu pagamento</label>
      </div>
      <button className="agendarButton"><Link to="/Agendar">▶ AGENDAR MAIS</Link></button>
    </div>
  );
};

