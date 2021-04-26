import { api } from '../utilities/api.config';

class ProductService {
    static GetAllProduct = () => {
        return api.get('/api/Product');
    }

    static GetProduct = (id) => {
        return api.get('/api/Product/' + id);
    }

    static UpdateProduct = (id, params) => {
        return api.put('/api/Product/' + id, params);
    }

    static CreateProduct = async (params, token) => {
        return await api.post('/api/Product', params, {
            headers: { Authorization: "Bearer " + token }
        })
    }

    static DeleteProduct = async (id, token) => {
        return await api.delete('/api/Product/' + id, {
            headers: { Authorization: "Bearer " + token }
        })
    }

    static DeleteImage = async (id, token) => {
        return await api.delete(`/api/Product/DeleteImages/${id}`, {
            headers: { Authorization: "Bearer " + token }
        })
    }
}

export default ProductService