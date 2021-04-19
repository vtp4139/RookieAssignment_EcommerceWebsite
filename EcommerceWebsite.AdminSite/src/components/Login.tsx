import React, { ChangeEvent, FormEvent, useEffect, useState } from 'react';

const Login = () => {
    //Declare a state
    const [inputs, setInputs] = useState({
        username: '',
        password: '',
    });

    //Get atribute of inputs
    const { username, password } = inputs;

    //Set value input when user typing
    const OnChangeInput = (e: ChangeEvent<HTMLInputElement>) => {
        const { name, value } = e.target;
        setInputs((inputs) => ({ ...inputs, [name]: value }));
        console.log(inputs);
    };

    const OnSubmitForm = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        if (username && password) {
            console.log('username', username);
            console.log('password', password);
            //const { from }: any = location.state || { from: { pathname: '/' } };
            //dispatch(login(username, password, from));
        }
    };


    return (
        <div>
            <div className="container  bg-white" style={{ boxShadow: 'rgba(149, 157, 165, 0.2) 0px 8px 24px', padding: 'unset', width: '40%' }}>
                <h4 className="text-center text-white bg-info p-2 mb-3" style={{ borderWidth: 0 }}>Đăng nhập</h4>
                <div className="row  justify-content-md-center">
                    <div className="col-md-10">
                        <form id="account" onSubmit={OnSubmitForm}>
                            <div className="form-group">
                                <p>Email</p>
                                <input className="form-control" onChange={OnChangeInput} placeholder='x@xxx.com' name='username' />
                            </div>
                            <div className="form-group">
                                <p>Password</p>
                                <input className="form-control" onChange={OnChangeInput} placeholder='Enter password' name='password' />
                            </div>
                            <div className="form-group">
                                <button className="btn btn-primary btn-lg btn-block">Đăng nhập</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    )
}
export default Login;