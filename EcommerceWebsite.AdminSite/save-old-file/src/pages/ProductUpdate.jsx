import React, { useEffect, useState } from 'react';
import ProductService from '../services/product.service';
import { Link } from 'react-router-dom';

// const UpdateProduct = () => {       
//     let productName = document.getElementById("idpro").value;
//    // let price = document.getElementById("price").value;
//    // let createdDate = document.getElementById("createdate").value;
//    // let description = document.getElementById("description").value;
//    // let updatedDate = createdDate;

//    // let params = {
//    //     productName: productName,
//    //     description: description,
//    //     price: price,
//    //     createdDate: createdDate,
//    //     updatedDate: updatedDate
//    // }

//    // ProductService.UpdateProduct(id, params).then((response) => {
//    //    console.log(response);
//    // })
// }



const ProductUpdate = (props) => {
    const id = props.match.params.id;
    const [productItem, SetProductItem] = useState([]);
    const [formData, setFormData] = useState([]);

    useEffect(() => {
        ProductService.GetProduct(id).then((response) => {
            SetProductItem(response.data);
            console.log(productItem);
        });
    }, []);

    const handleChange = e => {
        setFormData({
          ...formData,
          [e.target.name]: e.target.value
        });
        console.log(formData);
      };
  
    return (
        <form>
            <div class="form-group">
                <label class="control-label col-md-2"><b>Tên tour:</b></label>
                <div class="col-md-10">
                <input type='text'  onChange={handleChange} className="form-control" id="idpro" name='idpro' defaultValue={productItem.productName} placeholder='Nhập tên sản phẩm...' />
                </div>  
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Thời gian khởi hành:</b></label>
                <div class="col-md-10">
                <input type='text'  onChange={handleChange} className="form-control" id="price" name='name' defaultValue={productItem.price} placeholder='Nhập tên sản phẩm...' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                <div class="col-md-10">
                <input type='text'  onChange={handleChange} className="form-control" id="createdate" name='name' defaultValue={productItem.createdDate} placeholder='Nhập tên sản phẩm...' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Thời gian đi (ngày):</b></label>
                <div class="col-md-10">
                <input type='text'  onChange={handleChange} className="form-control" id="description" name='name' defaultValue={productItem.description } placeholder='Nhập tên sản phẩm...' />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <button type="submit" class="btn btn-primary">Cập nhập</button>
                </div>
            </div>
        </form>
    )
}
export default ProductUpdate;