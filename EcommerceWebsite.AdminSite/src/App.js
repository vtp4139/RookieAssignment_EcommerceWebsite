import React from 'react'
import {
  HashRouter as Router,
  Switch,
  Route
} from 'react-router-dom';
import Product from "./pages/Product";
import Login from "./pages/Login";


function App() {
  return (
    <React.Fragment>
      <Router>
        <Switch>
        {/* <Route path="/" exact component={Product}></Route> */}
        <Route path="/" component={Login}></Route>
        </Switch>
      </Router>
    </React.Fragment>
  );
}

export default App;
