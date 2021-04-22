import { api } from '../utilities/api.config';

class CategoryService {
    static GetAllCategory = () => {
        return api.get('/api/Categories');
    }

    static GetCategory = (id) => {
        return api.get('/api/Categories/' + id);
    }

    static UpdateCategory = (id, params, token) => {
        return api.put('/api/Categories/' + id, params,
            {
                headers: { Authorization: "Bearer " + token }
            });
    }

    static CreateCategory = async (params, token) => {
        return await api.post('/api/Categories', params, {
            headers: { Authorization: "Bearer " + token }
        })
    }

    static DeleteCategory = async (id, token) => {
        return await api.delete('/api/Categories/' + id, {
            headers: { Authorization: "Bearer " + token }
        })
    }
}

export default CategoryService