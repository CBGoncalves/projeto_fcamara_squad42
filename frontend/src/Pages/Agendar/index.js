import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import Navbar from '../../Components/Navbar/Navbar';
import './style.css'; 

export default function Agendar() {

  const [DataAgendamento, setDataAgendamento] = useState('');
  const [TipoAgendamento, setTipoAgendamento] = useState('');
  const [Escritorio, setEscritorio ] = useState('');
  const [Turno, setTurno] = useState('');
  const [ListTipoAgendamento, setListTipoAgendamento] = useState([]);
  const [ListEscritorio, setListEscritorio] = useState([]);
  const [ListTurno, setListTurno] = useState([]);
  const [IdUsuario, setIdUsuario] = useState(1)

  useEffect(() => {
    listarTipoAgendamento();
    listarEscritorio();
    listarTurno();
  }, []);

  const listarTipoAgendamento = () => {
    fetch(`http://localhost:5000/TipoAgendamento`, {
      method: "GET"
    })
      .then((response) => response.json())
      .then((dados) => {
        setListTipoAgendamento(dados);
      })
      .catch((err) => console.error(err));
  };

  const listarEscritorio = () => {
    fetch(`http://localhost:5000/Escritorio`, {
      method: "GET"
    })
      .then((response) => response.json())
      .then((dados) => {
        setListEscritorio(dados);
      })
      .catch((err) => console.error(err));
  };

  const listarTurno = () => {
    fetch(`http://localhost:5000/Turno`, {
      method: "GET"
    })
      .then((response) => response.json())
      .then((dados) => {
        setListTurno(dados);
      })
      .catch((err) => console.error(err));
  };

  const salvar = () => {
    const form = {
      dataAgendamento: DataAgendamento,
      idUsuario: IdUsuario,
      idTipoAgendamento: TipoAgendamento,
      idEscritorio: Escritorio,
      idTurno: Turno,

    };
    fetch('http://localhost:5000/Agendamento', {
      method: 'POST',
      body: JSON.stringify(form),
      headers: {
          'content-type': 'application/json',
      }
  })
      .then(() => {
          alert('Agendamento cadastrado');
      })
      .catch(err => console.error(err));
  };

  
  return (    
    <div> 
      <Navbar />
      <div className="container agendar">
        <h1>Quando você pretende ir à FCamara?</h1>
        <form onSubmit={event => {
          event.preventDefault();
          salvar();
        }}>
          <div className="agendarForm">
            <div>
              <h2>Data</h2>
              <input id="data" type="date" value={DataAgendamento} onChange={e => setDataAgendamento(e.target.value)}></input>
            </div>
            <div>
              <h2>Cidade</h2>
              <select name="cidade" onChange={(e) => setEscritorio(e.target.value)}
                    value={Escritorio}>
                <option value="0">Selecione sua cidade</option>
                {ListEscritorio.map((item) => {
                      return (
                        <option value={item.idEscritorio}>{item.tituloEscritorio},{item.enderecoEscritorio}</option>
                      );
                    })}
              </select>
            </div>
          </div>
          <div className="agendarForm">
            <div>
              <h2>Turno</h2>
              <select name="turno" onChange={(e) => setTurno(e.target.value)}
                    value={Turno}>
                <option value="0">Selecione um turno</option>
                {ListTurno.map((item) => {
                      return (
                        <option value={item.idTurno}>{item.tituloTurno}</option>
                      );
                    })}
              </select>
            </div>
            <div>
              <h2>Sala ou mesa</h2>
              <select name="sala" onChange={(e) => setTipoAgendamento(e.target.value)}
                    value={TipoAgendamento}>
                <option value="0">O que você quer agendar</option>
                {ListTipoAgendamento.map((item) => {
                      return (
                        <option value={item.idTipoAgendamento}>{item.tituloTipoAgendamento}</option>
                      );
                    })}
              </select>
            </div>
          </div>
          <div className='botao'>
          <button onClick={salvar}>▶ AGENDAR</button>
          </div>
          
        </form>
      </div>
    </div>
  );
};
