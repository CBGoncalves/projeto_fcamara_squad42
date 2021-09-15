import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Form from './Components/Forms/Form';
import FormCadastro from './Components/Forms/FormCadastro';
import Agendar from './Components/Agendar/Agendar';
import MeusAgendamentos from './Components/MeusAgendamentos/MeusAgendamentos';
import Popup from './Components/PopUp/Popup';

function App() {
  return (
      <BrowserRouter>
      <Routes>
        <Route path="/" element={<Form />} />
        <Route path="Cadastrar" element={<FormCadastro />} />
        <Route path="Agendar" element={<Agendar />} />
        <Route path="MeusAgendamentos" element={<MeusAgendamentos />} />
        <Route path="Popup" element={<Popup />} />
      </Routes>
        </BrowserRouter>
  );
}


export default App;