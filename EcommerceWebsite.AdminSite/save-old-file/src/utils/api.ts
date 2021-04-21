import axios from 'axios';

//Get base url backend to axios
const api = axios.create({
  baseURL: 'https://vtpshop.azurewebsites.net',
});

export { api };