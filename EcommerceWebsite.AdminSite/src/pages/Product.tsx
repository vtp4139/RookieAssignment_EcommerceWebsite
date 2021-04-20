import React, { useEffect, useState } from 'react';
import ProductService from '../services/product.service';

const Product = () => {
    const [productItem, SetProductItem] = useState([]);
    const [goals, setGoals] = useState <Array<{
        productID: string,
        productName: string,
        price: number,
        createdDate: Date,
    }>>([])


    useEffect(() => {
        ProductService.GetAllProduct().then((response) => {
            SetProductItem(response.data);
            // setGoals(
            //     productID: 'aaa'
            // );
            console.log(productItem);
        });
    }, []);

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
                    {productItem.map((product, index) => {
                        return (
                            <tr key={index}>
                                <td><img style={{ width: '90px', height: '75px' }} src={'https://localhost:44387' + product.imageLocation[0]} alt={product.productName} /></td>
                                <td scope="row">{product.productID}</td>
                                <td> {product.productName}</td>
                                <td> {product.price}</td>
                                <td> {product.createdDate}</td>
                                <td>
                                    <div>
                                        <span className="badge badge-warning" style={{ width: 50 }}> Cập nhật</span>
                                        <span className="badge badge-info" style={{ width: 50 }} >Xóa</span>
                                    </div>
                                </td>
                            </tr>
                        )
                    })}
                </table>
            </div>
        </div>
    )
}
export default Product;