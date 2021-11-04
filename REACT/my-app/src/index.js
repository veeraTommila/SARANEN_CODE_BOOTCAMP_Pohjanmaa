import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import MyComponent from './MyComponent';
import MySecondComponent from './MySecondComponent';
import MyClassComponent from './MyClassComponent';


//To boot up the application and to show the stuff on a browser screen.
ReactDOM.render(
  <React.StrictMode>    
    <App />
    <MyComponent />
    <MySecondComponent />    
    <MyClassComponent />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
