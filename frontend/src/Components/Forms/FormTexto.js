import Logotipo from '../../imagens/Logotipo.png';
import Cadeira from '../../imagens/Cadeira.png';

const FormTexto = () => {
  return (
  <div className="logotipo-div">
  <img src={Logotipo} className="logotipo" alt="Logotipo"/> 
  <div className="form-texto">        
    <p>Trabalhe do jeito que você gosta com segurança nível <span>FCamara!</span></p>
    <img src={Cadeira} className="cadeira" alt="Cadeira"/>
  </div>
  </div>
  );
};

export default FormTexto;