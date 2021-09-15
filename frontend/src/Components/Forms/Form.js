import React from 'react';
import { Link } from 'react-router-dom';
import './Form.css';
import FormTexto from './FormTexto'

const Form = () => {
  return (    
    <div className="container formContainer">
      <FormTexto />
      <div className="form">    
        <h1>Entrar</h1>  
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
