import { api } from '../utilities/api.config';

class AccountService {
    static login =  async (username, password) => {
        var urlencoded = new URLSearchParams();
        urlencoded.append("grant_type", "password");
        urlencoded.append("username", username);
        urlencoded.append("password", password);
        urlencoded.append("client_id", "react_admin");
        urlencoded.append("client_secret", "secret");

        return await api.post('/connect/token', urlencoded)
            .then(response => {
                return response.data;
            })
            .catch(error => {
                if (error.response) {
                    return error.response;
                  }
            })
    }

    static CheckRoles = async (token) => {
        api.defaults.headers.common['Authorization'] = `Bearer ${token}`
        return await api.get('/connect/userinfo');
    }
}

export default AccountService