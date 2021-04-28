import React, { Component } from 'react';
import { withCookies, Cookies } from 'react-cookie';
import { instanceOf } from 'prop-types';
import CategoryService from '../services/category.service';
import history from "../utilities/history"

class CategoryCreate extends Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    constructor(props) {
        super(props);

        const { cookies } = this.props;
        if (cookies.get('user') === undefined) {
            history.push('/login');
        }

        //Use this to get variable in constructor into funtion
        this.ButtonClick = this.ButtonClick.bind(this);

        this.state = {
            id: this.props.match.params.id,
            category: {
                categoryName: "",
                description: "",
            }
        }
    }

    componentDidMount() {
        if (this.state.id) {
            CategoryService.GetCategory(this.state.id).then((response) => {
                this.setState({
                    category: response.data
                })
            });
        }
    }

    ButtonClick() {
        let categoryName = document.getElementById("categoryName").value;
        let description = document.getElementById("description").value;

        if (categoryName == '' || description == '') {
            document.getElementById('error').innerHTML = "Không chừa trống dữ liệu!";
        }
        else {
            let params = {
                categoryName: categoryName,
                description: description,
            }

            const { cookies } = this.props;

            if (this.state.id) {
                CategoryService.UpdateCategory(this.state.id, params, cookies.get('user').access_token).then((response) => {
                    cookies.set('message', "Cập nhật loại sản phẩm thành công!");
                    history.push('/category');
                });
            }
            else {
                CategoryService.CreateCategory(params, cookies.get('user').access_token).then((response) => {
                    cookies.set('message', "Thêm loại sản phẩm thành công!");
                    history.push('/category');
                });
            }
        }
    }

    render() {
        return (
            <div className="container  bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset', width: '40%' }}>
                <h5 className="text-center text-white bg-info p-2 mb-3" style={{ borderWidth: 0 }}>{this.state.id ? "Cập nhật loại" : "Thêm mới loại"}</h5>
                <div className="row  justify-content-md-center">
                    <div className="col-md-10">
                        <div className="container">
                            <div class="form-group">
                                <label class="control-label "><b>Tên loại: </b></label>
                                <input type='text' className="form-control" defaultValue={this.state.category.categoryName} id="categoryName" name='name' placeholder='Nhập tên sản phẩm...' />
                            </div>
                            <div class="form-group">
                                <label class="control-label "><b>Mô tả</b></label>
                                <textarea className="form-control" id="description" style={{ height: 150}} defaultValue={this.state.category.description} name='name' placeholder='Nhập tên sản phẩm...' />
                            </div>
                            <div class="col-md-offset-2 ">
                                <p id="error" className="text-danger"></p>
                                <button onClick={this.ButtonClick} class="btn btn-primary mb-4"> {this.state.id ? "Cập nhật" : "Thêm mới"}</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}

export default withCookies(CategoryCreate)