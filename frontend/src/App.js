import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Form from './Components/Forms/Form';
import FormCadastro from './Components/Forms/FormCadastro';

function App() {
  return (
      <BrowserRouter>
      <Routes>
        <Route path="/" element={<Form />} />
        <Route path="FormCadastro" element={<FormCadastro />} />
      </Routes>
        </BrowserRouter>
  );
}


export default App;