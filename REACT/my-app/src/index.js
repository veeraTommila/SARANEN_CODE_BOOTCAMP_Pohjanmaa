import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
//import App from './App';
import reportWebVitals from './reportWebVitals';
//import MyComponent from './MyComponent';
//import MySecondComponent from './MySecondComponent';
//import MyClassComponent from './MyClassComponent';
import LifeCycleReact from './LifyCycleReact';



//To boot up the application and to show the stuff on a browser screen.
ReactDOM.render( //JavaScript.
  <React.StrictMode>   {/*This is XML.*/} 
      <LifeCycleReact />    {/**Referring the component LifeCycleReact.*/}
  </React.StrictMode>,
  document.getElementById('root')//JavaScript again.
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
