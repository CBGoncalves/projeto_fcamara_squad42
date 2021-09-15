import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

import Login from './Pages/Login';
import CadastroUsuario from './Pages/CadastroUsuario';
import Agendar from './Pages/Agendar/Agendar';
import MeusAgendamentos from './Pages/MeusAgendamentos';
import Popup from './Components/PopUp/Popup';


function Rotas() {
    return (
        <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="CadastroUsuario" element={<CadastroUsuario />} />
          <Route path="Agendar" element={<Agendar />} />
          <Route path="MeusAgendamentos" element={<MeusAgendamentos />} />
          <Route path="Popup" element={<Popup />} />
        </Routes>
          </BrowserRouter>
    );
  }
  
  
  export default Rotas;