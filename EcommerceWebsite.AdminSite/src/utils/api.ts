import axios from 'axios';

//Get base url backend to axios
const api = axios.create({
  baseURL: `${process.env.REACT_APP_BACKEND_URL}`,
});

//Handle return status code
api.interceptors.response.use(
  (res) => res,
  (err) => {
    if (err.response.status === 401) {
      //todo
    }
    return Promise.reject(err);
  }
);
export { api };