import React from "react";
import { instanceOf } from 'prop-types';
import { withCookies, Cookies } from 'react-cookie';

class NavBar extends React.Component {
  static propTypes = {
    cookies: instanceOf(Cookies).isRequired
  };

  constructor(props) {
    super(props)
    this.Logout = this.Logout.bind(this);

    const { cookies } = this.props;

    this.state = {
      cookies: cookies.get('user')
    }
  }

  Logout() {
    const { cookies } = this.props;
    cookies.remove('user'); 
  }

  render() {
    //Check user login or not to render navbar
    if (this.state.cookies === undefined) {
      return (
        <header>
          <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
            <a className="navbar-brand" href="#">Trang quản trị</a>
          </nav>	&nbsp;	&nbsp; 	&nbsp;	&nbsp;
        </header>
      )
    }
    return (
      <header>
        <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
          <a className="navbar-brand" href="#">VTPGear: Trang quản trị</a>
          <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span className="navbar-toggler-icon" />
          </button>
          <div className="collapse navbar-collapse" id="navbarSupportedContent">
            <ul className="navbar-nav mr-auto">
              <li className="nav-item active">
                <a className="nav-link" href="#">Quản lý sản phẩm <span className="sr-only">(current)</span></a>
              </li>
              <li className="nav-item active">
                <a className="nav-link" href="#">Quản lý loại sản phẩm <span className="sr-only">(current)</span></a>
              </li>
            </ul>
            <form className="form-inline my-2 my-lg-0">
              <button className="btn btn-danger my-2 my-sm-0" onClick={this.Logout} type="submit">Đăng xuất</button>
            </form>
          </div>
        </nav>	&nbsp;	&nbsp; 	&nbsp;	&nbsp;
      </header>
    )
  }
}
export default withCookies(NavBar)

