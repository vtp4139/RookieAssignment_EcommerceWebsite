import ProductService from '../../services/product.service';
import {
    ProductsActionTypes,
    LOAD_PRODUCTS_REQUEST,
    LOAD_PRODUCTS_SUCCESS,
    LOAD_PRODUCTS_FAILURE,
    DELETE_PRODUCT
} from '../contains/product.types';
import { Dispatch } from "react";

export const GetProduct = () => {
    return async (dispatch: Dispatch<ProductsActionTypes>) => {
        dispatch({
            type: LOAD_PRODUCTS_REQUEST,
            payload: {
                loading: true
            }
        });
        try {
            const response = await ProductService.GetAllProduct();
            dispatch({
                type: LOAD_PRODUCTS_SUCCESS,
                payload: {
                    items: response.items,
                    loading: false,
                    error: null
                }
            });
        } catch (error) {
            dispatch({
                type: LOAD_PRODUCTS_FAILURE,
                payload: {
                    loading: false,
                    error: error.toString()
                }
            });
        }
    }
}

// export const deleteProduct = (id: number) => {
//     return async (dispatch: Dispatch<ProductsActionTypes>) => {
//         const response = await productService.DeleteProduct(id);
//         dispatch({
//             type: DELETE_PRODUCT,
//             payload: {
//                 item: response
//             }
//         });
//     }
// }