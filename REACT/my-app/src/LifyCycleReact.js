import React from 'react';
class LifeCycleReact extends React.Component {    
    //This creates an instance of a class. Constructor is also a method.
    //The console logs are to see the calling order of these functions
    //in the Console / Konsoli -window in the development tools of a browser. 
    constructor(props){
        super(props);
        console.log("In LifeCycleReact.constructor");
        this.state = {title: ""}; //Empty object (value) and a property called Title.
    }

    componentDidMount(){
        console.log("In LifeCycleReact.componentDidMount");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
        .then(response => response.json())
        .then(json => {
            console.log(json.title);
            this.setState({title: json.title}); //Update the state. Then call the render(){}
            console.log("Component state has been modified.")
        });
        console.log("One made the fetch call.");
    }
    //This returns the HTML code that we want to see.

    //To run a javascript
    render() {
        console.log("In LifeCycleReact.render");
      return(
            <div>
                <h1>Moi, this is the Lifecycle component</h1>
                <p> The title is coming from a back-end: {this.state.title} </p> 
            </div>);      
    }         
    
  }
  
export default LifeCycleReact;
