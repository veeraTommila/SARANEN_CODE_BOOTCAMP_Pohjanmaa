import React from 'react';
class LifeCycleReact extends React.Component {

    constructor(props){
        super(props);
    }

    render() {
      return <h1>Moi, this is the Lifecycle component</h1>;
    }

    componentDidMount(){
        
    }
  }
  
export default LifeCycleReact;