import {api} from '../utilities/api.config';

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
}

export default ProductService