import React from 'react';
import { Link } from 'react-router-dom';
import CategoryService from '../services/category.service';
import { withCookies, Cookies } from 'react-cookie';
import history from "../utilities/history"

class Category extends React.Component {
    constructor(props) {
        super(props)

        const { cookies } = this.props;
        if (cookies.get('user') === undefined) {
            history.push('/login');
        }
        this.state = {
            CategoryList: []
        }
    }

    componentDidMount() {
        CategoryService.GetAllCategory().then((response) => {
            this.setState({
                CategoryList: response.data
            })
        })
    }

    DeleteCategory(id) {
        const { cookies } = this.props;

        CategoryService.DeleteCategory(id, cookies.get('user').access_token).then((response) => {
            window.location.reload();
        });
    }

    render() {
        return (
            <div className="container">
                <div>
                    <Link to={"/category/create"} type="button" class="btn btn-success">Tạo mới</Link>
                </div>
                <table className="table table-striped mt-3">
                    <tbody>
                        <tr>
                            <th>Mã loại</th>
                            <th>Tên loại</th>
                            <th>Mô tả</th>
                            <th>Chức năng</th>
                        </tr>
                    </tbody>
                    {this.state.CategoryList.map((item, index) => {
                        return (
                            <tr key={index}>
                                <td scope="row">{item.categoryID}</td>
                                <td> {item.categoryName}</td>
                                <td> {item.description}</td>
                                <td>
                                    <div>
                                        <Link to={`/category/update/${item.categoryID}`} className="badge badge-info" style={{ width: 70, height: 20 }} >Cập nhập</Link>
                                        <a className="badge badge-danger" style={{ width: 70, height: 20 }} onClick={() => this.DeleteCategory(item.categoryID)} href="#">Xóa</a>
                                    </div>
                                </td>
                            </tr>
                        )
                    })}
                </table>
            </div>
        )
    }
}

export default withCookies(Category)