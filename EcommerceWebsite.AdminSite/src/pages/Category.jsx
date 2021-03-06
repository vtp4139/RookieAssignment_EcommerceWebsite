import React from 'react';
import { Link } from 'react-router-dom';
import CategoryService from '../services/category.service';
import { withCookies, Cookies } from 'react-cookie';
import history from "../utilities/history";
import { confirmAlert } from 'react-confirm-alert';
import 'react-confirm-alert/src/react-confirm-alert.css';
import { toast } from 'react-toastify';

class Category extends React.Component {
    constructor(props) {
        super(props)

        const { cookies } = this.props;
        this.state = {
            CategoryList: [],
            cookies: cookies
        }

        if (this.state.cookies.get('user') === undefined) {
            history.push('/login');
        }

    }

    componentDidMount() {
        //Show notify when return success requets
        const getCookie = this.state.cookies;
        if (getCookie.get('message')) {
            toast.success(getCookie.get('message'));
            getCookie.remove('message');
        }
        else if (getCookie.get('message-error')) {
            toast.error(getCookie.get('message-error'));
            getCookie.remove('message-error');
        }

        CategoryService.GetAllCategory().then((response) => {
            this.setState({
                CategoryList: response.data
            })
        })
    }

    DeleteCategory = (id) => {
        confirmAlert({
            title: 'Xóa sản phẩm',
            message: 'Bạn muốn xóa sản phẩm này?',
            buttons: [
                {
                    label: 'Xác nhận',
                    onClick: () => {
                        CategoryService.DeleteCategory(id, this.state.cookies.get('user').access_token).then((response) => {
                            if (response.status == 204) {
                                this.state.cookies.set('message-error', "Không thể xóa khi tồn tại sản phẩm có loại này!");
                                window.location.reload();
                            }
                            else {
                                this.state.cookies.set('message', "Xóa loại sản phẩm thành công!");
                                window.location.reload();
                            }
                        });
                    }
                },
                {
                    label: 'Hủy',
                    onClick: () => { }
                }
            ],
        });
    };

    render() {
        return (
            <div className="container">
                <div>
                    <Link to={"/category/create"} type="button" class="btn btn-success">
                        <i class="fas fa-plus-square" />&nbsp;Tạo mới
                    </Link>
                </div>
                <table className="table mt-3 bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset' }}>
                    <thead className="bg-info text-white">
                        <tr>
                            <th>Mã</th>
                            <th style={{ width: 100}}>Tên loại</th>
                            <th>Mô tả</th>
                            <th>Chức năng</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.CategoryList.map((item, index) => {
                            return (
                                <tr key={index}>
                                    <td scope="row">{item.categoryID}</td>
                                    <td> {item.categoryName}</td>
                                    <td> {item.description}</td>
                                    <td>
                                        <div>
                                            <Link to={`/category/update/${item.categoryID}`} className="badge badge-info" style={{ width: 90, height: 22, fontSize: 13 }} >
                                                <i class="fas fa-edit" />&nbsp;Cập nhật
                                            </Link>
                                            <a className="badge badge-danger" style={{ width: 90, height: 22, fontSize: 13 }} onClick={() => this.DeleteCategory(item.categoryID)} href="#">
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

export default withCookies(Category)