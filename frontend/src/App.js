import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Form from './Components/Forms/Form';
import FormCadastro from './Components/Forms/FormCadastro';
import Agendar from './Components/Agendar/Agendar';
import MeusAgendamentos from './Components/MeusAgendamentos/MeusAgendamentos';

function App() {
  return (
      <BrowserRouter>
      <Routes>
        <Route path="/" element={<Form />} />
        <Route path="Cadastro" element={<FormCadastro />} />
        <Route path="Agendar" element={<Agendar />} />
        <Route path="MeusAgendamentos" element={<MeusAgendamentos />} />
      </Routes>
        </BrowserRouter>
  );
}


export default App;