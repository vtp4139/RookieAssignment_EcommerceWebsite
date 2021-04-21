import {api} from '../utils/api';

class ProductService {
    static GetAllProduct = () => {
        return api.get<any>('/api/Product').then((response) => {
            return response.data;
        });;
    }

    static GetProduct = (id: number) => {
        return api.get('/api/Product/' + id);
    }

    static UpdateProduct = (id: number, params: FormData) => {
        return api.put('/api/Product/' + id, params);
    }
}

export default ProductService