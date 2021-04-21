import React from 'react';
import { Link } from 'react-router-dom';
import ProductService from '../services/product.service'

class Product extends React.Component {
    constructor(props) {
        super(props)

        this.state = {
            ProductList: []
        }
    }

    componentDidMount() {
        console.log("ProductList");
        ProductService.GetAllProduct().then((response) => {
            this.setState({
                ProductList: response.data
            })
            console.log(this.state.ProductList);
        })
    }

    render() {
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
                    {this.state.ProductList.map((product, index) => {
                        return (
                            <tr key={index}>
                                <td><img style={{ width: '90px', height: '75px' }} src={'https://vtpshop.azurewebsites.net' + product.imageLocation[0]} alt={product.productName} /></td>
                                <td scope="row">{product.productID}</td>
                                <td> {product.productName}</td>
                                <td> {product.price}</td>
                                <td> {product.createdDate}</td>
                                <td>
                                    <div>
                                        <Link className="badge badge-warning" to={'/product/'+product.productID} style={{ width: 50 }}> Cập nhật</Link>
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
}

export default Product