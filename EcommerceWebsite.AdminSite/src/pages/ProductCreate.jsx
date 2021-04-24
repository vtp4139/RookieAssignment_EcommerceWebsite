import React, { Component } from 'react';
import { withCookies, Cookies } from 'react-cookie';
import { instanceOf } from 'prop-types';
import ProductService from '../services/product.service';
import CategoryService from '../services/category.service';
import history from "../utilities/history";

class ProductCreate extends Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    constructor(props) {
        super(props);
        //Use this to get variable in constructor into funtion
        this.CreateProduct = this.CreateProduct.bind(this);
        this.PreviewImages = this.PreviewImages.bind(this);

        //Get category to load option
        this.state = {
            CategoryList: [],
        }
    }

    componentDidMount() {
        CategoryService.GetAllCategory().then((response) => {
            this.setState({
                CategoryList: response.data
            })
        });
    }

    CreateProduct() {
        let productName = document.getElementById("productName").value;
        let description = document.getElementById("description").value;
        let price = document.getElementById("price").value;
        let categoryID = document.getElementById("categoryID").value;
        let images = document.getElementById("images").files;

        if (productName == '' || description == '' || price == '') {
            document.getElementById('error').innerHTML = "Không chừa trống dữ liệu!";
        }
        else if (images.length == 0) {
            document.getElementById('errorImage').innerHTML = "Phải thêm tối thiểu 1 hình ảnh cho sản phẩm!";
        }
        else if (parseInt(price) > 10000) {
            document.getElementById('errorPrice').innerHTML = "Giá tiền không được vượt quá 10000!";
        }
        else {
            //Set image list
            const formData = new FormData();
            if (images) {
                for (let i = 0; i < images.length; i++) {
                    formData.append("images", images[i], images[i].name);
                }
            }

            formData.append('productName', productName.toString());
            formData.append('description', description.toString());
            formData.append('price', price.toString());
            formData.append('categoryID', categoryID.toString());

            const { cookies } = this.props;
            ProductService.CreateProduct(formData, cookies.get('user').access_token).then((response) => {
                history.push('/product');
            });
        }
    }

    PreviewImages() {
        var divImage = document.getElementById("preview");
        divImage.innerHTML = '';
        let images = document.getElementById("images").files;
        if (images) {
            for (let i = 0; i < images.length; i++) {
                var image = document.createElement("img");
                image.className = "mr-3";
                image.src = URL.createObjectURL(images[i]);
                image.style.width = "75px";
                image.style.height = "75px";
                divImage.appendChild(image);
            }
        }
    }

    render() {
        return (
            <div className="container">
                <div class="form-group">
                    <label class="control-label col-md-2"><b>Tên sản phẩm:</b></label>
                    <div class="col-md-5">
                        <input type='text' className="form-control" id="productName" name='name' placeholder='Logitech G102,..' />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Giá tiền: </b></label>
                    <div class="col-md-5">
                        <input type='number' className="form-control" id="price" name='name' placeholder='100, 200,...' />
                        <p id="errorPrice" className="text-danger"></p>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Loại sản phẩm</b></label>
                    <div class="col-md-5">
                        <select className='form-control' style={{ height: '50%' }} id="categoryID">
                            {
                                this.state.CategoryList.map((item, index) => {
                                    return <option key={index} value={item.categoryID}>{item.categoryName}</option>
                                })
                            }
                        </select>
                    </div>
                </div>

                <div className='form-group'>
                    <label class="control-label col-md-2"><b>Hình ảnh sản phẩm</b></label>
                    <div class="col-md-5">
                        <input type='file' multiple id="images" className="form-control" onChange={this.PreviewImages} />
                        <p id="errorImage" className="text-danger"></p>
                    </div>
                </div>

                <div className='form-group'>
                    <div class="col-md-5" id="preview">
                        
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-2"><b>Mô tả:</b></label>
                    <div class="col-md-7">
                        <textarea className="form-control" id="description" name='name' />
                    </div>
                </div>

                <div class="col-md-offset-2 col-md-10">
                    <p id="error" className="text-danger"></p>
                    <button onClick={this.CreateProduct} class="btn btn-primary">Cập nhập</button>
                </div>
            </div>

        )
    }
}

export default withCookies(ProductCreate)