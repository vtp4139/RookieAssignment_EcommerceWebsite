import {
    DELETE_PRODUCT,
    LOAD_PRODUCTS_FAILURE,
    LOAD_PRODUCTS_REQUEST,
    LOAD_PRODUCTS_SUCCESS,
    ProductsActionTypes,
    ProductList,
    Product
} from '../contains/product.types';

const initialState: ProductList = {
    items: [],
    loading: false,
    error: null
}

const RefreshItems = (productList: ProductList, product: Product) => {
    const lstProduct = [...productList.items];
    const index = lstProduct?.findIndex(u => u.productID === product.productID);
    lstProduct?.splice(index, 1);
    return lstProduct;
}

const productsReducer = (
    state: ProductList = initialState,
    action: ProductsActionTypes
): ProductList => {
    switch (action.type) {
        case LOAD_PRODUCTS_REQUEST: {
            return {
                ...state,
                loading: true
            };
        }
        case LOAD_PRODUCTS_SUCCESS: {
            return {
                ...state,
                items: action.payload.items,
                loading: false,
                error: null
            };
        }
        case LOAD_PRODUCTS_FAILURE: {
            return {
                ...state,
                loading: false,
                error: action.payload.error
            };
        }
        case DELETE_PRODUCT: {
            return {
                ...state,
                items: RefreshItems(state, action.payload.item)
            }
        }
        default:
            return state;
    }
}

export default productsReducer ;