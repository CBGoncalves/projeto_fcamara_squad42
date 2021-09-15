import React from 'react';
import { Link } from 'react-router-dom';
import './Form.css';
import FormTexto from './FormTexto'
import Logo from '../../imagens/Logo.png';

const Form = () => {
  return (    
    <div className="container">
      <FormTexto />
      <div className="form">      
        <img src={Logo} className="logo" alt="Logo"/>
        <form>
          <div>     
            <label for="email"></label>
            <input type="email" name="email" id="email" placeholder="E-mail" required/>
          </div>
          <div>
            <label for="password"></label>
            <input type="password" name="password" id="password" placeholder="Senha" required/>         
          </div>
          <span>Esqueci a senha</span>
        <div>
          <button><Link to="/Agendar">▶ ENTRAR</Link></button>
        </div>
          <span><Link to="/FormCadastro">Criar conta</Link></span>
        </form> 
      </div>
      </div>
  );
};

export default Form;
