import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import logo from './logo.svg';
import './App.css';

class App extends Component {

  static api = {
    baseURL: 'https://graph.facebook.com/v3.3/',
    getFacebookAccounts: 'me?fields=accounts',
    getInstagramAccount: '?fields=instagram_business_account',
    getInstagramUser: '?fields=name,biography,followers_count,follows_count,id,media_count,profile_picture_url,username,media'
  };

  constructor(props) {
    super(props);
    this.state = {
      authenticatedUser: this.props.authenticated_user,
      instagramUser: null,
    };
  }

  getBusinessID() {
    const facebookAccountsURL = this.api.baseURL + this.api.getFacebookAccounts + '&' + this.state.authenticatedUser.accessToken;
    fetch(facebookAccountsURL)
      .then(result => result.json())
        .then((result) => {
          const bizID = result.accounts.data[0].id;
          

        }, (error) => {

        });
  }

  getInstagramID(businessID) {
    const instagramAccountURL = this.api.baseURL + businessID + this.api.getInstagramAccount + '&' + this.state.authenticatedUser.accessToken;
    fetch(instagramAccountURL)
      .then(result => result.json())
        .then((result) => {
          const igID = result.instagram_business_account.id;

        }, (error) => {

        });
  }

  getInstagramUser(userID) {
    const instagramUserURL = this.api.baseURL + userID + this.api.getInstagramUser + '&' + this.state.authenticatedUser.accessToken;
    fetch(instagramUserURL)
      .then(result => result.json())
        .then((result) => {
          this.setState({
            authenticatedUser: this.state.authenticatedUser,
            instagramUser: result,
          });
        }, (error) => {
          console.log()
        });
  }

  componentDidMount() {
    
  }

  render() {
    return (
      <div className="App">
        <p>{this.state.authenticated_user.accessToken}</p>
      </div>
    );
  }

}

export default App;
