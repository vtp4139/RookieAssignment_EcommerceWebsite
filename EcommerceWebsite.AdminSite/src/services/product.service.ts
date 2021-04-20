import {api} from '../utils/api';

class ProductService {
    static GetAllProduct = () => {
        return api.get('/api/Product');
    }
}

export default ProductService