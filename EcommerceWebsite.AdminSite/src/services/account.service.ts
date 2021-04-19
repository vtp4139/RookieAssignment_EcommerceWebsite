import {api} from '../utils/api';

const login = async (username: string, password: string): Promise<any> => {
    var urlencoded = new URLSearchParams();
    urlencoded.append("grant_type", "password");
    urlencoded.append("username", username);
    urlencoded.append("password", password);
    urlencoded.append("client_id", "react");
    urlencoded.append("client_secret", "secret");

    return await api.post('/connect/token', urlencoded)
        .then(response => {
            return response.data;
        })
        .catch(error => {
            return Promise.reject(error);
        })
}

export const AccountService = {
    login
}