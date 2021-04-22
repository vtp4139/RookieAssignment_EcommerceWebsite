import React, { useEffect, useState } from 'react';
import { RootStateOrAny, useDispatch, useSelector } from 'react-redux';
import { Product, ProductList } from '../store/contains/product.types'
import { GetProduct } from '../store/actions/product.actions';
import ProductService from '../services/product.service';
import { Link } from 'react-router-dom';
import { AppState } from '../../store';

const Products = () => {
    //const products = useSelector((state: RootStateOrAny) => state.productsReducer) as ProductList;
    const products = useSelector<AppState>((state) => state.products) as ProductsState;
    const dispatch = useDispatch();

    const [productItem, SetProductItem] = useState([]);

    useEffect(() => {
        dispatch(GetProduct());
        console.log(products);
        // ProductService.GetAllProduct().then((response) => {
        //     SetProductItem(response.data);
        //     //console.log(response.data);
        // });
    }, [dispatch]);

    return (
        <div>
            <div className="container">
                <table className="table table-striped">
                    <tbody>
                        <tr>
                            <th>Hình ảnh</th>
                            <th>Mã sản phẩm</th>
                            <th>Tên sản phẩm</th>
                            <th>Giá</th>
                            <th>Ngày tạo</th>
                            <th>Chức năng</th>
                        </tr>
                    </tbody>
                    {/* {productItem.map((product, index) => {
                        return (
                            <tr key={index}> */}
                                {/* <td><img style={{ width: '90px', height: '75px' }} src={'https://localhost:44387' + product.imageLocation[0]} alt={product.productName} /></td>
                                <td scope="row">{product.productID}</td>
                                <td> {product.productName}</td>
                                <td> {product.price}</td>
                                <td> {product.createdDate}</td>
                                <td>
                                    <div>
                                        <Link className="badge badge-warning" to={'/product/'+product.productID} style={{ width: 50 }}> Cập nhật</Link>
                                        <span className="badge badge-info" style={{ width: 50 }} >Xóa</span>
                                    </div>
                                </td> */}
                            {/* </tr>
                        )
                    })} */}
                </table>
            </div>
        </div>
    )
}
export default Products;