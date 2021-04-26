import axios from 'axios';

//Get base url backend to axios
const api = axios.create({
  baseURL: process.env.REACT_APP_URL_BACKEND,
});


//Handle return status code
api.interceptors.response.use(
  (res) => { console.log(res.data); return res; },
  (err) => {
    if (err.response.status === 401) {
      //todo
    }
    return Promise.reject(err);
  }
);
export { api };