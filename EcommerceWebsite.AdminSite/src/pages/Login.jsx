import React from "react";
import AccountService from "../services/account.service"
import history from "../utilities/history"
import { connect } from 'react-redux';
import {SetUser} from "../stores/actions/user.actions";
import { instanceOf } from 'prop-types';
import { withCookies, Cookies } from 'react-cookie';
//import {Modal} from "react-responsive-modal";

class Login extends React.Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    constructor(props) {
        super(props)
        //this.btnLoginClick = this.btnLoginClick.bind(this)

        // this.state = {
        //     isModalOpen: false
        // }
    }

    //Set Modal Open State
    // setModalOpenState(state) {
    //     this.setState({
    //         isModalOpen: state
    //     })
    // }

    btnLoginClick() {
        let Email = document.getElementById("txtEmail").value
        let Password = document.getElementById("txtPassword").value

        // if (!CheckValid.isValidEmail(Email)) {
        //     ToastMessage.ToastError("Email Không Đúng Định Dạng")
        //     return
        // }

        // if (!CheckValid.isRightPassword(Password)) {
        //     ToastMessage.ToastError("Mật Khẩu Phải Từ 6 Đến 26 Kí Tự")
        //     return
        // }

        // this.setModalOpenState(true)

        // let parrams = {
        //     email: Email,
        //     password: Password
        // }

        AccountService.login(Email, Password).then((response) => {
            console.log("This row");
            console.log(response.data)
            // if (response.data.status) {
            //     //this.setModalOpenState(false)

            //     const { cookies } = this.props;
            //     //history.push('/')
            //     cookies.set('user', response.data)

            //     console.log("This row");
            //     //console.log(response.data)
            // } else {
            //     this.setModalOpenState(false)
            //     ToastMessage.ToastError("Email hoặc Mật Khẩu Không Chính Xác")
            // }
        })
    }

    render() {
        return (
            <div>
            <div className="container  bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset', width: '40%' }}>
                <h4 className="text-center text-white bg-info p-2 mb-3" style={{ borderWidth: 0 }}>Đăng nhập</h4>
                <div className="row  justify-content-md-center">
                    <div className="col-md-10">
                        <form id="account">
                            <div className="form-group">
                                <p>Email</p>
                                <input type="text" className="form-control" id="txtEmail" placeholder='x@xxx.com' name='username' />
                            </div>
                            <div className="form-group">
                                <p>Password</p>
                                <input type="password" id="txtPassword" className="form-control" placeholder='Enter password' name='password' />
                            </div>
                            <div className="form-group">
                                <button className="btn btn-primary btn-lg btn-block" onClick={this.btnLoginClick}>Đăng nhập</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        )
    }
}

const mapDispatchToProps = dispatch => ({
    SetUser: user => {
        dispatch(SetUser(user))
    }
})

export default connect(null, mapDispatchToProps)(withCookies(Login))