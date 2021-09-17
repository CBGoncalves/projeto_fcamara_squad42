import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import './style.css';
import FormTexto from '../../Components/Forms/FormTexto'


export default function CadastroUsuario() {

  const [NomeUsuario, setNome] = useState('');
  const [Email, setEmail] = useState('');
  const [Senha, setSenha] = useState('');
  const [IdTipoUsuario, setIdTipoUsuario] = useState(2)
  const cors = require('cors')

  const salvar = () => {
    const form = {
      nomeUsuario: NomeUsuario,
      email: Email,
      senha: Senha,
      idTipoUsuario: IdTipoUsuario 
    };

    fetch('http://localhost:5000/Usuario', {
            method: 'POST',
            body: JSON.stringify(form),
            headers: {
                'content-type': 'application/json',
            }
        })
            .then(() => {
                alert('Usuario cadastrado');
            })
            .catch(err => console.error(err));
  };


  return (
    <div className="container">
      <FormTexto />
      <div className="form FormCadastro">      
        <h1>Cadastre-se</h1>
        <form onSubmit={event => {
          event.preventDefault();
          salvar();
        }}>
        <div>     
            <label for="text"></label>
            <input type="name" name="name" id="name" value={NomeUsuario} onChange={e => setNome(e.target.value)} placeholder="Nome" required/>
          </div>
          <div>     
            <label for="email"></label>
            <input type="email" name="email" id="email" value={Email} onChange={e => setEmail(e.target.value)} placeholder="E-mail" required/>
          </div>
          <div>
            <label for="password"></label>
            <input type="password" name="password" id="password" value={Senha} onChange={e => setSenha(e.target.value)} placeholder="Senha" required/>         
          </div>
          <div>
            <label for="password"></label>
            <input type="password" name="password" id="password" placeholder="Confirmar Senha" required/>         
          </div>
        <div>
          <button onClick={salvar}>▶ ENTRAR</button>
        </div>
        <span><Link to="/">Já tenho conta</Link></span>
        </form> 
      </div>
      </div>
  );
};

