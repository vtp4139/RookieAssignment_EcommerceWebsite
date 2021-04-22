import React from 'react';
import { Link } from 'react-router-dom';
import UserService from '../services/user.service';
import { withCookies, Cookies } from 'react-cookie';
import history from "../utilities/history"

class User extends React.Component {
    constructor(props) {
        super(props)

        const { cookies } = this.props;
        if (cookies.get('user') === undefined) {
            history.push('/login');
        }
        this.state = {
            UserList: []
        }
    }

    componentDidMount() {
        UserService.GetAllUser().then((response) => {
            this.setState({
                UserList: response.data
            })
        })
    }

    render() {
        return (
            <div className="container">
                <table className="table table-striped mt-3">
                    <tbody>
                        <tr>
                            <th>Mã user</th>
                            <th>Email</th>
                            <th>Họ và tên</th>
                        </tr>
                    </tbody>
                    {this.state.UserList.map((item, index) => {
                        return (
                            <tr key={index}>
                                <td scope="row">{item.userID}</td>
                                <td> {item.email}</td>
                                <td> {item.fullname}</td>                             
                            </tr>
                        )
                    })}
                </table>
            </div>
        )
    }
}

export default withCookies(User)