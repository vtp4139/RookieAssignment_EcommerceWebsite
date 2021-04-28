import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import "bootstrap/dist/css/bootstrap.css";
import { Provider } from "react-redux";
import { CookiesProvider } from 'react-cookie';
import store from "./stores/store";
import "./assets/fontawesome-free-5.15.2-web/css/all.css";
import 'react-toastify/dist/ReactToastify.css';

ReactDOM.render(
  <React.StrictMode>
    <Provider store={store}>
      <CookiesProvider>
        <App store={store} />
      </CookiesProvider>
    </Provider>
  </React.StrictMode>,
  document.getElementById('root')
);