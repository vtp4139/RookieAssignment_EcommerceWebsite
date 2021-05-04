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
        this.DeleteImage = this.DeleteImage.bind(this);

        //Get category to load option
        this.state = {
            id: this.props.match.params.id,
            CategoryList: [],
            product:
            {
                productName: "",
                price: "",
                description: "",
                categoryName: "",
                imageLocation: [],
            },
        }
    }

    componentDidMount() {
        CategoryService.GetAllCategory().then((response) => {
            this.setState({
                CategoryList: response.data
            })
        });

        if (this.state.id) {
            ProductService.GetProduct(this.state.id).then((response) => {
                this.setState({
                    product: response.data
                })
            });
        }
    }

    CreateProduct() {
        let productName = document.getElementById("productName").value;
        let description = document.getElementById("description").value;
        let price = document.getElementById("price").value;
        let categoryID = document.getElementById("categoryID").value;
        let images = document.getElementById("images").files;

        console.log(price);

        if (productName == '' || description == '' || price == '') {
            document.getElementById('error').innerHTML = "Không chừa trống dữ liệu!";
        }
        else if (images.length == 0 && this.state.id == undefined) {
            document.getElementById('errorImage').innerHTML = "Phải thêm tối thiểu 1 hình ảnh cho sản phẩm!";
        }
        else if (parseInt(price) > 100000) {
            document.getElementById('errorPrice').innerHTML = "Giá tiền không được vượt quá 100000!";
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
            if (this.state.id) {
                ProductService.UpdateProduct(this.state.id, formData, cookies.get('user').access_token).then((response) => {
                    cookies.set('message', "Cập nhật sản phẩm thành công!");
                    history.goBack();
                });
            }
            else {
                ProductService.CreateProduct(formData, cookies.get('user').access_token).then((response) => {
                    cookies.set('message', "Thêm sản phẩm thành công!");
                    history.goBack();
                });
            }
        }
    }

    PreviewImages() {
        var divImage = document.getElementById("preview");
        divImage.innerHTML = '';
        let images = document.getElementById("images").files;
        if (images) {
            for (let i = 0; i < images.length; i++) {
                var image = document.createElement("img");
                var spanImg = document.createElement("span");
                var spanPlus = document.createElement("span");

                //Set style
                spanImg.style.cssText = 'position: relative ';
                spanPlus.style.cssText = 'position: absolute; right: 10px';
                image.style.cssText = 'width: 75px; height: 75px';

                //Set class
                spanPlus.className = 'badge badge-pill badge-success';
                image.className = "mr-3 mb-2";

                //Set data
                image.src = URL.createObjectURL(images[i]);
                spanPlus.innerText = 'Mới';

                //Return
                divImage.appendChild(spanImg);
                spanImg.appendChild(image);
                spanImg.appendChild(spanPlus);
            }
        }
    }

    DeleteImage(imageLocation) {
        const { cookies } = this.props;
        //var str = imageLocation.replaceAll("/", "%5F");
        var str = imageLocation.replace("/images/","");
        console.log(str);
        ProductService.DeleteImage(str, cookies.get('user').access_token).then((response) => {
            window.location.reload();
        });
    }

    render() {
        return (
            <div className="container  bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset', width: '40%' }}>
                <h5 className="text-center text-white bg-info p-2 mb-3" style={{ borderWidth: 0 }}>{this.state.id ? "Cập nhật sản phẩm" : "Thêm mới sản phẩm"}</h5>
                <div className="row  justify-content-md-center">
                    <div className="col-md-10">
                        <div class="form-group">
                            <label class="control-label"><b>Tên sản phẩm:</b></label>
                            <input type='text' className="form-control" id="productName" name='name' defaultValue={this.state.product.productName} placeholder='Logitech G102,..' />
                        </div>

                        <div class="form-group">
                            <label class="control-label "><b>Giá tiền: </b></label>
                            <input type='number' className="form-control" id="price" name='name' defaultValue={this.state.product.price} placeholder='100, 200,...' min="1" max="10000" />
                            <p id="errorPrice" className="text-danger"></p>
                        </div>

                        <div class="form-group">
                            <label class="control-label "><b>Loại sản phẩm</b></label>
                            <select className='form-control' style={{ height: '50%' }} id="categoryID">
                                {
                                    this.state.CategoryList.map((item, index) => {
                                        return <option key={index} value={item.categoryID} selected={item.categoryName == this.state.product.categoryName ? true : false}>{item.categoryName}</option>
                                    })
                                }
                            </select>
                        </div>

                        <div className='form-group'>
                            <label class="control-label "><b>Hình ảnh sản phẩm</b></label>
                            <input type='file' multiple id="images" className="form-control" onChange={this.PreviewImages} />
                            <p id="errorImage" className="text-danger"></p>

                        </div>

                        <div className='form-group'>
                            {
                                this.state.product.imageLocation.map((item, index) => {
                                    return (
                                        <span style={{ position: 'relative' }} key={index}>
                                            <img className="mr-3 mb-2" style={{ width: '75px', height: '75px' }} src={process.env.REACT_APP_URL_BACKEND + item} />
                                            {this.state.product.imageLocation.length != 1 && (<a style={{ position: 'absolute', right: 10 }} onClick={() => this.DeleteImage(item)} className="badge badge-pill badge-danger" href="#">&#x2715;</a>)}
                                        </span>
                                    )
                                })
                            }
                        </div>

                        <div className='form-group'>
                            <div id="preview">
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="control-label"><b>Mô tả:</b></label>
                            <textarea className="form-control" defaultValue={this.state.product.description} style={{ height: 100}}  id="description" name='name' />
                        </div>

                        <div class="col-md-offset-2 ">
                            <p id="error" className="text-danger"></p>
                            <button onClick={this.CreateProduct} class="btn btn-primary mb-4">{this.state.id ? "Cập nhật" : "Thêm mới"}</button>
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}

export default withCookies(ProductCreate)