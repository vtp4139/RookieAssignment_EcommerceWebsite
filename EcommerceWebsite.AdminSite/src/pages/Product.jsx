import React from 'react';
import { Link } from 'react-router-dom';
import ProductService from '../services/product.service';
import { withCookies, Cookies } from 'react-cookie';
import history from "../utilities/history";
import { confirmAlert } from 'react-confirm-alert';
import 'react-confirm-alert/src/react-confirm-alert.css';
import { toast } from 'react-toastify';

class Product extends React.Component {
    constructor(props) {
        super(props)

        this.DeleteProduct = this.DeleteProduct.bind(this);

        const { cookies } = this.props;
        if (cookies.get('user') === undefined) {
            history.push('/login');
        }
        this.state = {
            ProductList: []
        }
    }

    componentDidMount() {
        //Show notify when return success requets
        const { cookies } = this.props;
        if (cookies.get('message')) {
            toast.success(cookies.get('message'));
            cookies.remove('message');
        }
        
        ProductService.GetAllProduct().then((response) => {
            this.setState({
                ProductList: response.data
            })
        })
    }

    DeleteProduct = (id) => {
        confirmAlert({
            title: 'Xóa sản phẩm',
            message: 'Bạn muốn xóa sản phẩm này?',
            buttons: [
                {
                    label: 'Yes',
                    onClick: () => {
                        const { cookies } = this.props;

                        ProductService.DeleteProduct(id, cookies.get('user').access_token).then((response) => {
                            const { cookies } = this.props;
                            cookies.set('message', "Xóa sản phẩm thành công!");
                            window.location.reload();
                        });
                    }
                },
                {
                    label: 'No',
                    onClick: () => { }
                }
            ],
        });
    };

    render() {
        return (
            <div className="container">
                <div>
                    <Link to={"/product/create"} type="button" class="btn btn-success">
                        <i class="fas fa-plus-square" />&nbsp;Tạo mới
                    </Link>
                </div>
                <table className="table mt-3 border bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset' }}>
                    <thead className="bg-info text-white">
                        <tr>
                            <th>Hình ảnh</th>
                            <th>Mã </th>
                            <th>Tên sản phẩm</th>
                            <th>Giá</th>
                            <th>Ngày tạo</th>
                            <th>Chức năng</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.ProductList.map((product, index) => {
                            return (
                                <tr key={index}>
                                    <td><img style={{ width: '90px', height: '75px' }} src={process.env.REACT_APP_URL_BACKEND + product.imageLocation[0]} alt={product.productName} /></td>
                                    <td scope="row">{product.productID}</td>
                                    <td> {product.productName}</td>
                                    <td style={{ color: "red" }}> {product.price}&#36;</td>
                                    <td> {product.createdDate}</td>
                                    <td>
                                        <div>
                                            <Link className="badge badge-primary" to={`/product/update/${product.productID}`} style={{ width: 90, height: 22, fontSize: 13 }}>
                                                <i class="fas fa-edit" />&nbsp;Cập nhật
                                        </Link>
                                            <a className="badge badge-danger" style={{ width: 90, height: 22, fontSize: 13 }} onClick={() => this.DeleteProduct(product.productID)} href="#">
                                                <i class="fas fa-trash-alt" />&nbsp;Xóa
                                        </a>
                                        </div>
                                    </td>
                                </tr>
                            )
                        })}
                    </tbody>
                </table>
            </div>
        )
    }
}

export default withCookies(Product)