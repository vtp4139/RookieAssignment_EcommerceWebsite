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

        let params = {
            categoryName: categoryName,
            description: description,
        }

        const { cookies } = this.props;

        if (this.state.id) {
            CategoryService.UpdateCategory(this.state.id, params, cookies.get('user').access_token).then((response) => {
                history.push('/category');
            });
        }
        else {
            CategoryService.CreateCategory(params, cookies.get('user').access_token).then((response) => {
                history.push('/category');
            });
        }
    }

    render() {
        return (
            <div className="container">
                <div class="form-group">
                    <label class="control-label col-md-2"><b>Tên loại: </b></label>
                    <div class="col-md-5">
                        <input type='text' className="form-control" defaultValue={this.state.category.categoryName} id="categoryName" name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Mô tả</b></label>
                    <div class="col-md-7">
                        <textarea className="form-control" id="description" defaultValue={this.state.category.description} name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="col-md-offset-2 col-md-10">
                    <button onClick={this.ButtonClick} class="btn btn-primary"> {this.state.id ? "Cập nhật" : "Thêm mới"}</button>
                </div>

            </div>

        )
    }
}

export default withCookies(CategoryCreate)