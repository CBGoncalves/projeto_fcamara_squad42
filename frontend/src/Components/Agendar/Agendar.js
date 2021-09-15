import React from 'react';
// import { Link } from 'react-router-dom';
import Navbar from '../Navbar/Navbar';
import './Agendar.css'; 

const Agendar = () => {
  return (    
    <div> 
      <Navbar />
      <div className="container agendar">
        <h1>Quando você pretende ir à FCamara?</h1>
        <form >
          <div className="agendarForm">
            <div>
              <h2>Data</h2>
              <input id="data" type="date"></input>
            </div>
            <div>
              <h2>Cidade</h2>
              <select name="cidade">
                <option value="Santos">Santos</option>
                <option value="SaoPaulo">Sao Paulo</option>
              </select>
            </div>
          </div>
          <div className="agendarForm">
            <div>
              <h2>Turno</h2>
              <select name="turno">
                <option value="Manha">Manhâ</option>
                <option value="Tarde">Tarde</option>
                <option value="Dia inteiro">Dia inteiro</option>
              </select>
            </div>
            <div>
              <h2>Sala ou mesa</h2>
              <select name="sala">
                <option value="Sala">Sala</option>
                <option value="Mesa">Mesa</option>
              </select>
            </div>
          </div>
          <button>▶ AGENDAR</button>
        </form>
      </div>
    </div>
  );
};

export default Agendar;