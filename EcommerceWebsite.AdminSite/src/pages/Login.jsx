import React from "react";
import AccountService from "../services/account.service"
import history from "../utilities/history"
import { connect } from 'react-redux';
import {SetUser} from "../stores/actions/user.actions";
import { instanceOf } from 'prop-types';
import { withCookies, Cookies } from 'react-cookie';

class Login extends React.Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    constructor(props) {
        super(props)

        //Check if user login 
        const { cookies } = this.props;
        if(cookies.get('user') != undefined)
        {
            history.push('/');
        }

        this.btnLoginClick = this.btnLoginClick.bind(this)
    }

    btnLoginClick(e) {
        e.preventDefault();
        let Email = document.getElementById("txtEmail").value;
        let Password = document.getElementById("txtPassword").value;

        if(Email == '' || Password == '')
        {
            document.getElementById('error').innerHTML = "Không chừa trống dữ liệu!";
        }
        else{
            AccountService.login(Email, Password).then((res) => {    
                //Check if email or password invalid       
                if (res.status == 400) {
                    document.getElementById('error').innerHTML = "Email hoặc mật khẩu không chính xác!";
           
                }
                AccountService.CheckRoles(res.access_token).then((response) => {                    
                    if(response.data.role != 'admin')
                    {
                        document.getElementById('error').innerHTML = "Tài khoản không có quyền quản trị!";
                    }
                    else {
                        const { cookies } = this.props;
                        cookies.set('user', res);
                        window.location.reload();
                    }
                })     
            })
        }
    }

    render() {
        return (
            <div className="container  bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset', width: '40%' }}>
                <h4 className="text-center text-white bg-info p-2 mb-3" style={{ borderWidth: 0 }}>Đăng nhập quản trị</h4>
                <div className="row  justify-content-md-center">
                    <div className="col-md-10">                     
                        <form>
                            <div className="form-group">
                                <p>Email</p>
                                <input type="email" className="form-control" id="txtEmail" placeholder='x@xxx.com' name='username' />
                            </div>
                            <div className="form-group">
                                <p>Mật khẩu</p>
                                <input type="password" id="txtPassword" className="form-control" placeholder='Nhập mật khẩu' name='password' />
                            </div>
                            <p id="error" className="text-danger"></p>
                            <div className="form-group">
                                <button className="btn btn-primary btn-lg btn-block" onClick={this.btnLoginClick}>Đăng nhập</button>
                            </div>
                        </form>
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