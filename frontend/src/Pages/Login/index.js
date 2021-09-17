import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import './style.css';
import FormTexto from '../../Components/Forms/FormTexto'

export default function Login (){

  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('')

  //criando função de acesso aos dados da API para realização do login
  const salvar = () => {
    const login = {
      email: email,
      senha: senha
    }
    //utilizando fetch para acesso à API, determinando o método, body e headers
    fetch('https://localhost:5000/Login', {
      method: 'POST',
      body: JSON.stringify(login),
      headers: {
        'content-type': 'application/json'
      }
    })
      //promises
      .then(response => response.json())
      .then(dados => {
        //Verificação se 
        if (dados.token !== undefined) {
          console.log(dados.status)
          localStorage.setItem('token', dados.token)
        } else {
          alert('Senha ou Email incorretos! Tente novamente! :(')
        }
      })
      .catch(err => console.error(err))
  }


  return (    
    <div className="container formContainer">
      <FormTexto />
      <div className="form">    
        <h1>Entrar</h1>  
        <form onSubmit={event => { event.preventDefault(); salvar(); }}>
          <div>     
            <label for="email"></label>
            <input type="email" name="email" id="email" placeholder="E-mail" onChange={(e) => setEmail(e.target.value)} required/>
          </div>
          <div>
            <label for="password"></label>
            <input type="password" name="password" id="password" placeholder="Senha" onChange={(e) => setSenha(e.target.value)} required/>         
          </div>
          <span>Esqueci a senha</span>
        <div>
          <button onClick={salvar}><Link to="/Agendar">▶ ENTRAR</Link></button>
        </div>
          <span><Link to="/CadastroUsuario">Criar conta</Link></span>
        </form> 
      </div>
      </div>
  );
};

