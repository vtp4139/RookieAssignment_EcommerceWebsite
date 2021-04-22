import React from 'react'
import {
    Router,
    Switch,
    Route
} from 'react-router-dom';
import Product from "./pages/Product";
import Login from "./pages/Login";
import ProductCreate from "./pages/ProductCreate";
import { connect } from 'react-redux';
import { instanceOf } from 'prop-types';
import { withCookies, Cookies } from 'react-cookie';
import history from './utilities/history';


class App extends React.Component {
    static propTypes = {
        cookies: instanceOf(Cookies).isRequired
    };

    render() {
        return (
            //   <React.Fragment>
            //       <Router>             
            //           <Switch>                                       
            //               <Route path="/" exact component={Login}/>
            //               <Route path="/create" exact component={ProductCreate}/>   
            //               {/* <Route path="/create" exact comp={ProductCreate}>
            //                     <ProductCreate></ProductCreate>
            //                 </Route>  */}
            //           </Switch>
            //       </Router>
            //   </React.Fragment>
            <Router history={history}>
                <Switch>
                    <Route path="/" exact component={Login} />
                    <Route path="/create" exact component={ProductCreate}/>   
                    {/* <Route path="/product/:id" exact component={ProductUpdate} />
                    <Route path="/about" exact component={About} />
                    <Route path="/" exact component={Login} /> */}
                </Switch>
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
