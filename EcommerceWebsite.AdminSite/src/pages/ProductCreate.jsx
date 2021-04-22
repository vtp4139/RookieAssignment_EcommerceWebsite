import React, {Component} from 'react';
import {withCookies, Cookies} from 'react-cookie';
import {instanceOf} from 'prop-types';
import ProductService from '../services/product.service';

class ProductCreate extends Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    constructor(props) {
        super(props);
        //Use this to get variable in constructor into funtion
        this.DangBaiViet = this.DangBaiViet.bind(this);

        this.state = {
            Post: {}
        }
        const { cookies } = this.props;
        console.log('Get token: ' + cookies.get('user').access_token);
    }

    componentDidMount() {
        const { cookies } = this.props
    }

    //Click Button Dang Bai Viet
    DangBaiViet() {
        let productName = document.getElementById("productName").value;
        let description = document.getElementById("description").value;
        let price =  document.getElementById("price").value;
        let createdDate = document.getElementById("createdDate").value;
        let updatedDate = document.getElementById("updatedDate").value;
        let categoryID =  document.getElementById("categoryID").value;

        let params = {
            productName: productName,
            description: description,
            price: price,
            images: null,
            createdDate: createdDate,
            updatedDate: updatedDate,
            categoryID: categoryID
        }

        const { cookies } = this.props
        console.log(cookies.get('user').access_token);
        ProductService.CreateProduct(params, cookies.get('user').access_token).then((response) => {
           console.log(response);
        });
    }

    render() {
        return (
           <div>
  <div class="form-group">
                    <label class="control-label col-md-2"><b>Thời gian khởi hành:</b></label>
                    <div class="col-md-10">
                        <input type='text' className="form-control" id="productName" name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                    <div class="col-md-10">
                        <input type='text' className="form-control" id="description" name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                    <div class="col-md-10">
                        <input type='text' className="form-control" id="price" name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                    <div class="col-md-10">
                        <input type='text' className="form-control" id="createdDate" name='name'  placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                    <div class="col-md-10">
                        <input type='text' className="form-control" id="updatedDate" name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                    <div class="col-md-10">
                        <input type='text' className="form-control" id="categoryID" name='name' placeholder='Nhập tên sản phẩm...' />
                    </div>
                </div>

           
                    <div class="col-md-offset-2 col-md-10">
                        <button onClick={this.DangBaiViet}  class="btn btn-primary">Cập nhập</button>
                    </div>

           </div>
              
        )
    }
}

export default withCookies(ProductCreate)