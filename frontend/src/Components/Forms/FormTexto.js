import Cadeira from '../../imagens/Cadeira.png';
import './style.css';

const FormTexto = () => {
  return (
  <div className="form-texto">        
    <p>Trabalhe do jeito que você gosta com segurança nível <span>FCamara!</span></p>
    <img src={Cadeira} className="cadeira" alt="Cadeira"/>
  </div>
  );
};

export default FormTexto;