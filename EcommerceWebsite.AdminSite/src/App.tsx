import React from "react";
import { BrowserRouter, Switch, Route, Link } from "react-router-dom";
import Home from "./components/Home";
import About from "./components/About";
import NavMenu from "./containers/NavMenu";
import Login from "./components/Login";

function App() {
  return (
    <BrowserRouter basename={"/"}>
    <NavMenu />
    <div className="container">
      <div>
        <Link to="/about">About</Link>
      </div>
      <Switch>
        <Route path="/about" component={About} />
        <Route path="/" component={Login} />
      </Switch>
    </div>
  </BrowserRouter>
  );
}

export default App;
