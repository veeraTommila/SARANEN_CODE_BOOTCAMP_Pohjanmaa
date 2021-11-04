import logo from './logo.svg'; //Visual stuff.
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <h1>Hello React from Visual Studio Code!</h1>
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <p>Some other text. React is new to me.</p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
