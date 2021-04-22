import {api} from '../utilities/api.config';

class UserService {
    static GetAllUser = () => {
        return api.get('/api/User');
    }
}

export default UserService