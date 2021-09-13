import React from 'react';
import { Link } from 'react-router-dom';
import './Form.css';
import FormTexto from './FormTexto'
import Logo from '../../imagens/Logo.png';


const FormCadastro = () => {
  return (
    <div className="container">
      <FormTexto />
      <div className="form FormCadastro">      
        <img src={Logo} className="logo" alt="Logo"/>
        <form>
        <div>     
            <label for="text"></label>
            <input type="name" name="name" id="name" placeholder="Nome" required/>
          </div>
          <div>     
            <label for="email"></label>
            <input type="email" name="email" id="email" placeholder="E-mail" required/>
          </div>
          <div>
            <label for="password"></label>
            <input type="password" name="password" id="password" placeholder="Senha" required/>         
          </div>
          <div>
            <label for="password"></label>
            <input type="password" name="password" id="password" placeholder="Confirmar Senha" required/>         
          </div>
        <div>
          <button>ENTRAR</button>
        </div>
        <span><Link to="/">Já tenho conta</Link></span>
        </form> 
      </div>
      </div>
  );
};

export default FormCadastro;