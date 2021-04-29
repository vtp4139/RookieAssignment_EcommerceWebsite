import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import "bootstrap/dist/css/bootstrap.css";
import { CookiesProvider } from 'react-cookie';
import "./assets/fontawesome/css/all.css";
import 'react-toastify/dist/ReactToastify.css';

ReactDOM.render(
  <React.StrictMode>
    <CookiesProvider>
      <App/>
    </CookiesProvider>
  </React.StrictMode>,
  document.getElementById('root')
);