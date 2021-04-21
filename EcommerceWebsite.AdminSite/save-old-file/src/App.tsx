import React from "react";
import { Router, Switch, Route, Link } from "react-router-dom";
import Home from "./components/Home";
import About from "./components/About";
import NavMenu from "./containers/NavMenu";
import Login from "./components/Login";
import Product from "./pages/Product";
import ProductUpdate from "./pages/ProductUpdate";
import { history } from './helpers/history';


function App() {
  return (
    <Router history={history}>
      <NavMenu />
      <Link to="/about">About</Link>
      <Switch>
        <Route path="/product" exact component={Product} />
        <Route path="/product/:id" exact component={ProductUpdate} />
        <Route path="/about" exact component={About} />
        <Route path="/" exact component={Login} />
      </Switch>
    </Router>
  );
}

export default App;
