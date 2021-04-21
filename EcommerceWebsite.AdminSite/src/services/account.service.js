import {api} from '../utilities/api.config';

class AccountService {
    static login =  (username, password) => {
        var urlencoded = new URLSearchParams();
        urlencoded.append("grant_type", "password");
        urlencoded.append("username", username);
        urlencoded.append("password", password);
        urlencoded.append("client_id", "react_admin");
        urlencoded.append("client_secret", "secret");
    
        return api.post('/connect/token', urlencoded);
    }
}

export default AccountService 