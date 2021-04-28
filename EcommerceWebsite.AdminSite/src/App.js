import React from 'react'
import {
    Router,
    Switch,
    Route
} from 'react-router-dom';
import { connect } from 'react-redux';
import { instanceOf } from 'prop-types';
import { withCookies, Cookies } from 'react-cookie';
import { ToastContainer, toast } from 'react-toastify';
import history from './utilities/history';
import NavBar from "./containers/NavBar";
import Footer from "./containers/Footer";

import Product from "./pages/Product";
import Login from "./pages/Login";
import ProductCreate from "./pages/ProductCreate";
import Category from "./pages/Category";
import CategoryCreate from "./pages/CategoryCreate";
import User from "./pages/User";

class App extends React.Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    constructor(props) {
        super(props);
        this.render = this.render.bind(this);
        const { cookies } = this.props;

        this.state = {
            cookies: cookies
        }
    }

    componentWillMount() {
        document.body.style.backgroundColor = " #F2F2F2";
    }

    render() {
        if(this.state.cookies === undefined)
        {
            return (
                <Router history={history}>
                    <ToastContainer />
                    <NavBar/>
                    <Switch>
                        <Route path="/" exact component={Login} />  
                    </Switch>
                    <Footer/>
                </Router>
            )
        }
        return (
            <Router history={history}>
                <ToastContainer />
                <NavBar/>
                <Switch>
                    <Route path={["/", "/product"]} exact component={Product} />
                    <Route path={["/product/create", "/product/update/:id" ]}exact component={ProductCreate} />
                    <Route path="/login" exact component={Login} />            
                    <Route path="/category" exact component={Category} /> 
                    <Route path={["/category/create", "/category/update/:id" ]}exact component={CategoryCreate} /> 
                    <Route path="/user" exact component={User} /> 
                </Switch>
                <Footer/>
            </Router>
        )
    }
}

function mapStateToProps(state) {
    return {
        user: state.user
    }
}

export default connect(mapStateToProps)(withCookies(App))
