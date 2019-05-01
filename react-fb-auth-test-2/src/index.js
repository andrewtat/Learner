import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';

import FacebookLogin from 'react-facebook-login';

function login(response) {
    document.getElementById('login').remove();
    ReactDOM.render(<App authenticated_user={response} />, document.getElementById('user'));
}

ReactDOM.render(<FacebookLogin 
                    appId="293770601551708"
                    fields="name,email,picture"
                    scope="public_profile,manage_pages,instagram_basic"
                    callback={(response) => login(response)}
                />, document.getElementById('login'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
